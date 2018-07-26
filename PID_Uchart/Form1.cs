using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Collections;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Diagnostics;

namespace PID_Uchart
{
    public partial class Form1 : Form
    {
        string ShowStr = "";                                    //字符串缓存
        public delegate void MyInvoke(string str);              //开启一个线程invoke
        string IDStr = "";               //波形号
        string NumStr = "";

        ArrayList ID1_Array = new ArrayList();
        ArrayList ID2_Array = new ArrayList();

        ArrayList ID3_Array = new ArrayList();
        ArrayList ID4_Array = new ArrayList();
                             //存放曲线1的数据
                              //存放曲线2的数据

        bool ChooseSerialEnable = false;                       //串口开关标志
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Baudrate.Text = "115200";             //先给一个开机默认波特率
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPortDataReceived); //将收到的数据传给串口
            SearchAndAddSerialToConmbox(serialPort1, Serial_Port);       //此时再进行搜索串口的操作

            ID1.Text = "A";
            ID2.Text = "B";

            ID3.Text = "C";
            ID4.Text = "D";


        }

        //定义串口触发接收函数    
        //类似在单片机中的串口中断，但要在窗体创建时调用此函数并传给串口事件触发函数
        private void SerialPortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ShowStr = serialPort1.ReadExisting();                           //这里只接收缓冲的串口数据，字符处理等操作我开启一个线程使用托管来做
            Thread UpdataThread = new Thread(new ThreadStart(DoWork));      //开启一个新线程同步更新text
            UpdataThread.Start();                                           //线程开启
        }

        //寻找端口号并添加到Combox  即端口框
        private void SearchAndAddSerialToConmbox(SerialPort MyPort,ComboBox MyBox)
        {
            string buffer;
            bool SerialIsOk = false;    //判断
            MyBox.Items.Clear();        //清除框内的信息

            for (int i=1; i < 20; i++)    //对PC机进行20个端口的遍历，一般PC机不会有20个串口，基本可以完全扫描
            {
                try                     //try  语法，尝试给串口赋值端口号
                {
                    buffer = "COM" + i.ToString();
                    MyPort.PortName = buffer;      //遍历COM1->COM20,并赋值给串口号
                    MyPort.Open();     //尝试打开串口     能成功打开则说明成功扫描到串口，打开失败则跳到catch并继续循环    
                    MyBox.Items.Add(buffer);  //将端口号添加到端口框
                    MyBox.Text = buffer;      //自动将扫描成功的串口显示端口框
                    MyPort.Close();           //保证在扫描完成时，串口是关闭的
                    SerialIsOk = true;                      //该端口正常
                }
                catch 
                {
                }
            }
            if (SerialIsOk)
            {
                //成功扫描到串口  则表示正常 无提示 打开串口
            }
            else 
            {
                MessageBox.Show("未找到串口", "提示");
            }
        }
        //扫描端口号函数   此函数是防止连接过程中串口拔出或因接触不良等原因意外中断，再次插上可直接按键搜索，无需重新打开
        private void SerialScan_Click(object sender, EventArgs e)
        {
            SearchAndAddSerialToConmbox(serialPort1, Serial_Port);   //查找端口号
        }

        private void OpenSerial_Click(object sender, EventArgs e)
        {
            ChooseSerialEnable = !ChooseSerialEnable;       //串口取反操作
            if (ChooseSerialEnable)                          //如果串口打开
            {
                try
                {
                    serialPort1.PortName = Serial_Port.Text;        //选择串口
                    serialPort1.BaudRate = Convert.ToInt32(Baudrate.Text, 10);   //将波特率框中的值转化为10进制数，并赋值给串口波特率
                    serialPort1.Open();                             //打开串口
                    OpenSerial.Text = "关闭串口";                   //按钮改为新状态
                }
                catch
                {
                    MessageBox.Show("端口错误，请检查", "ERROR");       //端口错误
                    ChooseSerialEnable = !ChooseSerialEnable;
                }
            }
            else {
                serialPort1.Close();            //关闭串口
                OpenSerial.Text = "打开串口";
            }
        }
        public void DoWork()
        {
            MyInvoke mi = new MyInvoke(UpdataForm);         //使用代理更新界面
            this.BeginInvoke(mi, new Object[] { ShowStr }); //开始代理
        }

        public void UpdataForm(string str)                  //界面更新函数
        {
            //当显示选项不同的时候 显示的东西不同
            if (DataShow.Checked || DCShow.Checked)     //允许字符接收区显示时
            {
                if (HEXShow.Checked)                    //判断  是否要求16进制显示
                {
                    foreach (byte hex in str)           //遍历接收到的字符，将其转化为16进制
                    {
                        string buffer = Convert.ToString(hex, 16).ToUpper();        //规范起见 将每byte数据转化为16进制大写显示
                        ShowText.AppendText("0x" + ((buffer.Length == 1) ? ("0" + buffer) : buffer)/* 三目运算符 编程技巧*/ + " ");  //显示在text box上
                    }
                }
                else                                //正常显示  直接显示在text box上即可。
                {
                    ShowText.AppendText(str);       
                }
            }
            if (ChartShow.Checked || DCShow.Checked)
            {
                foreach (byte hex in str)           //遍历接收到的字符，将其转化为16进制
                {
                    if (hex == 0x0d)                    //判断是不是此次数据接收完成
                    {
                        if (IDStr == ID1.Text)              //判断符合哪个ID
                        {
                            try
                            {
                                this.chart1.Series[0].Points.AddY(Convert.ToDouble(NumStr));
                                ID1_Array.Add(NumStr);
                                IDWarn.Text = "ID提示:正常";
                            }
                            catch
                            {
                                //MessageBox.Show("数据异常", "提示");
                            }

                        }
                        else if (IDStr == ID2.Text)
                        {
                            try
                            {
                                this.chart1.Series[1].Points.AddY(Convert.ToDouble(NumStr));
                                ID2_Array.Add(NumStr);                //将接收到的数据存放至数组
                                IDWarn.Text = "ID提示:正常";
                            }
                            catch
                            {
                                //MessageBox.Show("数据异常", "提示");
                            }
                        }else if (IDStr == ID3.Text)
                        {
                            try
                            {
                                this.chart1.Series[2].Points.AddY(Convert.ToDouble(NumStr));
                                ID3_Array.Add(NumStr);                //将接收到的数据存放至数组
                                IDWarn.Text = "ID提示:正常";
                            }
                            catch
                            {
                               // MessageBox.Show("数据异常", "提示");
                            }
                        }
                        else if (IDStr == ID4.Text)
                        {
                            try
                            {
                                this.chart1.Series[3].Points.AddY(Convert.ToDouble(NumStr));
                                ID4_Array.Add(NumStr);                //将接收到的数据存放至数组
                                IDWarn.Text = "ID提示:正常";
                            }
                            catch
                            {
                               // MessageBox.Show("数据异常", "提示");
                            }
                        }
                        else
                        {
                            IDWarn.Text = "ID提示:无对应ID";
                        }

                        IDStr = "";             //清除缓存
                        NumStr = "";
                    }
                    else 
                    {
                        if (hex > 64 && hex < 123)          //判断为字母
                        {
                            IDStr += (char)hex;             //ID使用字符显示
                        }
                        else if ((hex > 47 && hex < 58) || hex == 46 || hex == 45)        //判断为数字
                        {
                            if (hex == 46 || hex == 45)
                            {
                                NumStr += (char)hex;
                            }
                            else
                            {
                                NumStr += hex - '0';            //使用数字显示
                            }
                        }
                    }
                }
            }
        }

        private void clearShow_Click(object sender, EventArgs e)
        {
            ShowText.Clear();                       //清除显示区数据
        }




        private void clearChart_Click(object sender, EventArgs e)       //清除图像
        {
            chart1.Series[0].Points.Clear();        //清除图像
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();        //清除图像
            chart1.Series[3].Points.Clear();
            //清除数组数据
            ID1_Array.Clear();
            ID2_Array.Clear();
            ID3_Array.Clear();
            ID4_Array.Clear();

            ExcelProgress.Value = 0;
        }

        private void educeExcel_Click(object sender, EventArgs e)
        {
            String ObjectPath = Directory.GetCurrentDirectory() + "\\曲线数据";        //获取当前目录路径
            ExcelProgress.Maximum = ID1_Array.Count + ID2_Array.Count + ID3_Array.Count + ID4_Array.Count;
            try
            {
                ExcelWarn.Text = "~导出ing";
                CreateExcelFile(ObjectPath);     //创建文件并命名至相对路径下
                MessageBox.Show("导出完毕", "提示");
                ExcelWarn.Text = "~导出完毕";
            }
            catch 
            {
                MessageBox.Show("未成功创建", "提示");
                ExcelWarn.Text = "~Error";
            }
            
        }
        //创建EXCEL函数  学习而来
        private void CreateExcelFile(string FileName)       //参数为路径 + 文件名
        {
            //create  
            object Nothing = System.Reflection.Missing.Value;           //这个我不知道是什么意思，但是好像必须有
            var app = new Excel.Application();

            app.Visible = false;                
            Excel.Workbook workBook = app.Workbooks.Add(Nothing);
            Excel.Worksheet worksheet = (Excel.Worksheet)workBook.Sheets[1];
            worksheet.Name = "YANJUN_Cheng";                            //sheet名
            //headline  
            worksheet.Cells[1, 1] = "index";                            //设置单元格的字
            worksheet.Cells[1, 2] = ID1.Text;
            worksheet.Cells[1, 3] = "index";
            worksheet.Cells[1, 4] = ID2.Text;
            worksheet.Cells[1, 5] = "index";                            //设置单元格的字
            worksheet.Cells[1, 6] = ID3.Text;
            worksheet.Cells[1, 7] = "index";
            worksheet.Cells[1, 8] = ID4.Text;

            for (int i = 0; i < ID1_Array.Count; i++)               //循环写入数据
            {
                worksheet.Cells[i + 2, 1] = i.ToString();
                worksheet.Cells[i + 2, 2] = ID1_Array[i];
            }
            ExcelProgress.Value = ID1_Array.Count;
            for (int i = 0; i < ID2_Array.Count; i++)           //循环写入另一个曲线的数据
            {
                worksheet.Cells[i + 2, 3] = i.ToString();      
                worksheet.Cells[i + 2, 4] = ID2_Array[i];
            }
            ExcelProgress.Value += ID2_Array.Count;
            for (int i = 0; i < ID3_Array.Count; i++)           //循环写入另一个曲线的数据
            {
                worksheet.Cells[i + 2, 5] = i.ToString();
                worksheet.Cells[i + 2, 6] = ID3_Array[i];
            }
            ExcelProgress.Value += ID3_Array.Count;
            for (int i = 0; i < ID4_Array.Count; i++)           //循环写入另一个曲线的数据
            {
                worksheet.Cells[i + 2, 7] = i.ToString();
                worksheet.Cells[i + 2, 8] = ID4_Array[i];
            }
            ExcelProgress.Value += ID4_Array.Count;
            //保存
            worksheet.SaveAs(FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
            workBook.Close(false, Type.Missing, Type.Missing);
            //退出
            app.Quit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.yanjun.tech");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   燕山大学\r\n   燕骏团队\r\n  联系方式 cheng_2014@foxmail.com", "surpise");
        }

        private void HowToUse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("可以当做简单的串口助手使用，不兼容中文字符\r\n使用波形显示时，必须先设置曲线ID默认为A,B\r\n可自定义，仅支持字母\r\n下位机与上位机通讯格式为 ID+数据+换行\r\n示例  printf(A12.3\\r\\nB123.1\\r\\n);\r\n支持小数显示，鼠标选中波形可放大显示\r\n欢迎反馈bug，联系方式请点击图片logo", "Help");
        }

        private void UP_Click(object sender, EventArgs e)
        {
            byte[] upvalue = new byte[2] { 0XAA, 0XFF };
            if (ChooseSerialEnable)
            {
                try
                {
                    serialPort1.Write(upvalue, 0, 2);
                }
                catch
                {
                    MessageBox.Show("请检查一下串口哦亲", "error");
                }
                
            }
            else
            {
                MessageBox.Show("请先打开串口哦亲", "hi");
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            byte[] pausevalue = new byte[2] { 0XAA, 0XF0 };
            if (ChooseSerialEnable)
            {
                try
                {
                    serialPort1.Write(pausevalue, 0, 2);
                }
                catch
                {
                    MessageBox.Show("请检查一下串口哦亲", "error");
                }
                
            }
            else
            {
                MessageBox.Show("请先打开串口哦亲", "hi");
            }
        }

        private void DOWN_Click(object sender, EventArgs e)
        {
            byte[] downvalue = new byte[2] { 0XAA, 0XF3 };
            if (ChooseSerialEnable)
            {
                try
                {
                    serialPort1.Write(downvalue, 0, 2);
                }
                catch
                {
                    MessageBox.Show("请检查一下串口哦亲", "error");
                }
                
            }
            else
            {
                MessageBox.Show("请先打开串口哦亲", "hi");
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            byte[] resetvalue = new byte[2] { 0XAA, 0XF1 };
            if (ChooseSerialEnable)
            {
                try
                {
                    serialPort1.Write(resetvalue, 0, 2);
                }
                catch
                {
                    MessageBox.Show("请检查一下串口哦亲", "error");
                }
                
            }
            else
            {
                MessageBox.Show("请先打开串口哦亲", "hi");
            }
        }

        private void SEND_Click(object sender, EventArgs e)
        {
            byte[] sendvalue = new byte[2] { 0XAA, 0X00 };
            sendvalue[1] = Convert.ToByte(LenText.Text);
            if (ChooseSerialEnable)
            {
                try
                {
                    serialPort1.Write(sendvalue, 0, 2);
                }
                catch
                {
                    MessageBox.Show("请检查一下串口哦亲", "error");
                }
                
            }
            else
            {
                MessageBox.Show("请先打开串口哦亲", "hi");
            }
        }
    }
}
