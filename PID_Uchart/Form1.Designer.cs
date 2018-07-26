namespace PID_Uchart
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ExcelWarn = new System.Windows.Forms.Label();
            this.IDWarn = new System.Windows.Forms.Label();
            this.educeExcel = new System.Windows.Forms.Button();
            this.clearChart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ID4 = new System.Windows.Forms.ComboBox();
            this.ID2 = new System.Windows.Forms.ComboBox();
            this.ID3 = new System.Windows.Forms.ComboBox();
            this.ID1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChartShow = new System.Windows.Forms.RadioButton();
            this.DCShow = new System.Windows.Forms.RadioButton();
            this.DataShow = new System.Windows.Forms.RadioButton();
            this.SerialScan = new System.Windows.Forms.Button();
            this.OpenSerial = new System.Windows.Forms.Button();
            this.Baudrate = new System.Windows.Forms.ComboBox();
            this.Serial_Port = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HowToUse = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clearShow = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CharShow = new System.Windows.Forms.RadioButton();
            this.HEXShow = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowText = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ExcelProgress = new System.Windows.Forms.ProgressBar();
            this.UP = new System.Windows.Forms.Button();
            this.DOWN = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.LenText = new System.Windows.Forms.TextBox();
            this.Len = new System.Windows.Forms.Label();
            this.SEND = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ExcelWarn);
            this.groupBox1.Controls.Add(this.IDWarn);
            this.groupBox1.Controls.Add(this.educeExcel);
            this.groupBox1.Controls.Add(this.clearChart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ID4);
            this.groupBox1.Controls.Add(this.ID2);
            this.groupBox1.Controls.Add(this.ID3);
            this.groupBox1.Controls.Add(this.ID1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.SerialScan);
            this.groupBox1.Controls.Add(this.OpenSerial);
            this.groupBox1.Controls.Add(this.Baudrate);
            this.groupBox1.Controls.Add(this.Serial_Port);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(197, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // ExcelWarn
            // 
            this.ExcelWarn.AutoSize = true;
            this.ExcelWarn.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExcelWarn.Location = new System.Drawing.Point(74, 498);
            this.ExcelWarn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ExcelWarn.Name = "ExcelWarn";
            this.ExcelWarn.Size = new System.Drawing.Size(45, 15);
            this.ExcelWarn.TabIndex = 10;
            this.ExcelWarn.Text = "~提示";
            // 
            // IDWarn
            // 
            this.IDWarn.AutoSize = true;
            this.IDWarn.Location = new System.Drawing.Point(16, 422);
            this.IDWarn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IDWarn.Name = "IDWarn";
            this.IDWarn.Size = new System.Drawing.Size(86, 19);
            this.IDWarn.TabIndex = 9;
            this.IDWarn.Text = "ID提示：";
            // 
            // educeExcel
            // 
            this.educeExcel.Location = new System.Drawing.Point(13, 486);
            this.educeExcel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.educeExcel.Name = "educeExcel";
            this.educeExcel.Size = new System.Drawing.Size(57, 30);
            this.educeExcel.TabIndex = 8;
            this.educeExcel.Text = "导出Excel";
            this.educeExcel.UseVisualStyleBackColor = true;
            this.educeExcel.Click += new System.EventHandler(this.educeExcel_Click);
            // 
            // clearChart
            // 
            this.clearChart.Location = new System.Drawing.Point(13, 451);
            this.clearChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearChart.Name = "clearChart";
            this.clearChart.Size = new System.Drawing.Size(112, 30);
            this.clearChart.TabIndex = 8;
            this.clearChart.Text = "清除图像";
            this.clearChart.UseVisualStyleBackColor = true;
            this.clearChart.Click += new System.EventHandler(this.clearChart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 395);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "（可自定义）";
            // 
            // ID4
            // 
            this.ID4.FormattingEnabled = true;
            this.ID4.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "G",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.ID4.Location = new System.Drawing.Point(108, 350);
            this.ID4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID4.Name = "ID4";
            this.ID4.Size = new System.Drawing.Size(54, 26);
            this.ID4.TabIndex = 6;
            // 
            // ID2
            // 
            this.ID2.FormattingEnabled = true;
            this.ID2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "G",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.ID2.Location = new System.Drawing.Point(108, 309);
            this.ID2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID2.Name = "ID2";
            this.ID2.Size = new System.Drawing.Size(54, 26);
            this.ID2.TabIndex = 6;
            // 
            // ID3
            // 
            this.ID3.FormattingEnabled = true;
            this.ID3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "G",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.ID3.Location = new System.Drawing.Point(26, 350);
            this.ID3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID3.Name = "ID3";
            this.ID3.Size = new System.Drawing.Size(50, 26);
            this.ID3.TabIndex = 6;
            // 
            // ID1
            // 
            this.ID1.FormattingEnabled = true;
            this.ID1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "G",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.ID1.Location = new System.Drawing.Point(26, 311);
            this.ID1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ID1.Name = "ID1";
            this.ID1.Size = new System.Drawing.Size(50, 26);
            this.ID1.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 356);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 356);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChartShow);
            this.panel1.Controls.Add(this.DCShow);
            this.panel1.Controls.Add(this.DataShow);
            this.panel1.Location = new System.Drawing.Point(11, 122);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 114);
            this.panel1.TabIndex = 4;
            // 
            // ChartShow
            // 
            this.ChartShow.AutoSize = true;
            this.ChartShow.Location = new System.Drawing.Point(19, 41);
            this.ChartShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ChartShow.Name = "ChartShow";
            this.ChartShow.Size = new System.Drawing.Size(103, 23);
            this.ChartShow.TabIndex = 3;
            this.ChartShow.Text = "波形显示";
            this.ChartShow.UseVisualStyleBackColor = true;
            // 
            // DCShow
            // 
            this.DCShow.AutoSize = true;
            this.DCShow.Location = new System.Drawing.Point(19, 78);
            this.DCShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DCShow.Name = "DCShow";
            this.DCShow.Size = new System.Drawing.Size(141, 23);
            this.DCShow.TabIndex = 3;
            this.DCShow.Text = "数据波形显示";
            this.DCShow.UseVisualStyleBackColor = true;
            // 
            // DataShow
            // 
            this.DataShow.AutoSize = true;
            this.DataShow.Checked = true;
            this.DataShow.Location = new System.Drawing.Point(19, 4);
            this.DataShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataShow.Name = "DataShow";
            this.DataShow.Size = new System.Drawing.Size(103, 23);
            this.DataShow.TabIndex = 3;
            this.DataShow.TabStop = true;
            this.DataShow.Text = "数据显示";
            this.DataShow.UseVisualStyleBackColor = true;
            // 
            // SerialScan
            // 
            this.SerialScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SerialScan.Location = new System.Drawing.Point(8, 38);
            this.SerialScan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SerialScan.Name = "SerialScan";
            this.SerialScan.Size = new System.Drawing.Size(58, 27);
            this.SerialScan.TabIndex = 2;
            this.SerialScan.Text = "端口";
            this.SerialScan.UseVisualStyleBackColor = false;
            this.SerialScan.Click += new System.EventHandler(this.SerialScan_Click);
            // 
            // OpenSerial
            // 
            this.OpenSerial.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.OpenSerial.Location = new System.Drawing.Point(11, 257);
            this.OpenSerial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OpenSerial.Name = "OpenSerial";
            this.OpenSerial.Size = new System.Drawing.Size(159, 46);
            this.OpenSerial.TabIndex = 2;
            this.OpenSerial.Text = "打开串口";
            this.OpenSerial.UseVisualStyleBackColor = false;
            this.OpenSerial.Click += new System.EventHandler(this.OpenSerial_Click);
            // 
            // Baudrate
            // 
            this.Baudrate.FormattingEnabled = true;
            this.Baudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "9600",
            "19200",
            "115200",
            "38400",
            "自定义"});
            this.Baudrate.Location = new System.Drawing.Point(70, 74);
            this.Baudrate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Baudrate.Name = "Baudrate";
            this.Baudrate.Size = new System.Drawing.Size(105, 26);
            this.Baudrate.TabIndex = 1;
            // 
            // Serial_Port
            // 
            this.Serial_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Serial_Port.FormattingEnabled = true;
            this.Serial_Port.Items.AddRange(new object[] {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""});
            this.Serial_Port.Location = new System.Drawing.Point(70, 38);
            this.Serial_Port.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Serial_Port.Name = "Serial_Port";
            this.Serial_Port.Size = new System.Drawing.Size(105, 26);
            this.Serial_Port.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "波特率";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Location = new System.Drawing.Point(216, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(786, 513);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "波形区";
            // 
            // chart1
            // 
            chartArea6.CursorX.IsUserEnabled = true;
            chartArea6.CursorX.IsUserSelectionEnabled = true;
            chartArea6.CursorX.LineColor = System.Drawing.Color.DarkRed;
            chartArea6.CursorY.IsUserEnabled = true;
            chartArea6.CursorY.IsUserSelectionEnabled = true;
            chartArea6.CursorY.LineColor = System.Drawing.Color.Black;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(11, 20);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series21.BorderWidth = 2;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series21.Legend = "Legend1";
            series21.Name = "one";
            series22.BorderWidth = 2;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series22.Legend = "Legend1";
            series22.Name = "two";
            series23.BorderWidth = 2;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series23.Legend = "Legend1";
            series23.Name = "three";
            series24.BorderWidth = 2;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series24.Legend = "Legend1";
            series24.Name = "four";
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Size = new System.Drawing.Size(763, 497);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Len);
            this.groupBox3.Controls.Add(this.LenText);
            this.groupBox3.Controls.Add(this.DOWN);
            this.groupBox3.Controls.Add(this.SEND);
            this.groupBox3.Controls.Add(this.Reset);
            this.groupBox3.Controls.Add(this.pause);
            this.groupBox3.Controls.Add(this.UP);
            this.groupBox3.Controls.Add(this.HowToUse);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.clearShow);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.ShowText);
            this.groupBox3.Location = new System.Drawing.Point(9, 547);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(992, 164);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据操作";
            // 
            // HowToUse
            // 
            this.HowToUse.Location = new System.Drawing.Point(8, 18);
            this.HowToUse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HowToUse.Name = "HowToUse";
            this.HowToUse.Size = new System.Drawing.Size(74, 26);
            this.HowToUse.TabIndex = 10;
            this.HowToUse.Text = "使用说明";
            this.HowToUse.UseVisualStyleBackColor = true;
            this.HowToUse.Click += new System.EventHandler(this.HowToUse_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 75);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(11, 138);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cheng";
            // 
            // clearShow
            // 
            this.clearShow.Location = new System.Drawing.Point(915, 29);
            this.clearShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearShow.Name = "clearShow";
            this.clearShow.Size = new System.Drawing.Size(66, 31);
            this.clearShow.TabIndex = 5;
            this.clearShow.Text = "清除显示";
            this.clearShow.UseVisualStyleBackColor = true;
            this.clearShow.Click += new System.EventHandler(this.clearShow_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CharShow);
            this.panel2.Controls.Add(this.HEXShow);
            this.panel2.Location = new System.Drawing.Point(908, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 63);
            this.panel2.TabIndex = 4;
            // 
            // CharShow
            // 
            this.CharShow.AutoSize = true;
            this.CharShow.Checked = true;
            this.CharShow.Location = new System.Drawing.Point(3, 34);
            this.CharShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CharShow.Name = "CharShow";
            this.CharShow.Size = new System.Drawing.Size(71, 16);
            this.CharShow.TabIndex = 2;
            this.CharShow.TabStop = true;
            this.CharShow.Text = "字符显示";
            this.CharShow.UseVisualStyleBackColor = true;
            // 
            // HEXShow
            // 
            this.HEXShow.AutoSize = true;
            this.HEXShow.Location = new System.Drawing.Point(3, 14);
            this.HEXShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HEXShow.Name = "HEXShow";
            this.HEXShow.Size = new System.Drawing.Size(65, 16);
            this.HEXShow.TabIndex = 2;
            this.HEXShow.Text = "HEX显示";
            this.HEXShow.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "显示区";
            // 
            // ShowText
            // 
            this.ShowText.Location = new System.Drawing.Point(596, 31);
            this.ShowText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowText.Multiline = true;
            this.ShowText.Name = "ShowText";
            this.ShowText.ReadOnly = true;
            this.ShowText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ShowText.Size = new System.Drawing.Size(301, 107);
            this.ShowText.TabIndex = 0;
            // 
            // ExcelProgress
            // 
            this.ExcelProgress.Location = new System.Drawing.Point(216, 527);
            this.ExcelProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExcelProgress.Name = "ExcelProgress";
            this.ExcelProgress.Size = new System.Drawing.Size(784, 18);
            this.ExcelProgress.TabIndex = 3;
            // 
            // UP
            // 
            this.UP.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UP.Location = new System.Drawing.Point(218, 31);
            this.UP.Name = "UP";
            this.UP.Size = new System.Drawing.Size(61, 51);
            this.UP.TabIndex = 11;
            this.UP.Text = "UP";
            this.UP.UseVisualStyleBackColor = true;
            this.UP.Click += new System.EventHandler(this.UP_Click);
            // 
            // DOWN
            // 
            this.DOWN.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DOWN.Location = new System.Drawing.Point(218, 102);
            this.DOWN.Name = "DOWN";
            this.DOWN.Size = new System.Drawing.Size(61, 51);
            this.DOWN.TabIndex = 11;
            this.DOWN.Text = "DO";
            this.DOWN.UseVisualStyleBackColor = true;
            this.DOWN.Click += new System.EventHandler(this.DOWN_Click);
            // 
            // pause
            // 
            this.pause.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pause.Location = new System.Drawing.Point(306, 31);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(61, 51);
            this.pause.TabIndex = 11;
            this.pause.Text = "P";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Reset.Location = new System.Drawing.Point(306, 102);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(61, 51);
            this.Reset.TabIndex = 11;
            this.Reset.Text = "R";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // LenText
            // 
            this.LenText.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LenText.Location = new System.Drawing.Point(457, 45);
            this.LenText.Multiline = true;
            this.LenText.Name = "LenText";
            this.LenText.Size = new System.Drawing.Size(50, 34);
            this.LenText.TabIndex = 12;
            this.LenText.Text = "25";
            this.LenText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Len
            // 
            this.Len.AutoSize = true;
            this.Len.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Len.Location = new System.Drawing.Point(407, 50);
            this.Len.Name = "Len";
            this.Len.Size = new System.Drawing.Size(47, 25);
            this.Len.TabIndex = 13;
            this.Len.Text = "LEN";
            // 
            // SEND
            // 
            this.SEND.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SEND.Location = new System.Drawing.Point(412, 89);
            this.SEND.Name = "SEND";
            this.SEND.Size = new System.Drawing.Size(146, 51);
            this.SEND.TabIndex = 11;
            this.SEND.Text = "Send";
            this.SEND.UseVisualStyleBackColor = true;
            this.SEND.Click += new System.EventHandler(this.SEND_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(510, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "mm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1009, 718);
            this.Controls.Add(this.ExcelProgress);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1025, 757);
            this.Name = "Form1";
            this.Text = "串口波形助手";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Baudrate;
        private System.Windows.Forms.ComboBox Serial_Port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton ChartShow;
        private System.Windows.Forms.RadioButton DCShow;
        private System.Windows.Forms.RadioButton DataShow;
        private System.Windows.Forms.Button SerialScan;
        private System.Windows.Forms.Button OpenSerial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton CharShow;
        private System.Windows.Forms.RadioButton HEXShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ShowText;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button clearShow;
        private System.Windows.Forms.Button educeExcel;
        private System.Windows.Forms.Button clearChart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ID2;
        private System.Windows.Forms.ComboBox ID1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IDWarn;
        private System.Windows.Forms.Label ExcelWarn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button HowToUse;
        private System.Windows.Forms.ComboBox ID4;
        private System.Windows.Forms.ComboBox ID3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar ExcelProgress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Len;
        private System.Windows.Forms.TextBox LenText;
        private System.Windows.Forms.Button DOWN;
        private System.Windows.Forms.Button SEND;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button UP;
    }
}

