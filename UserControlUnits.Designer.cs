namespace APP
{
    partial class UserControlUnits
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSensor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrRead = new System.Windows.Forms.Timer(this.components);
            this.labelRunTime = new System.Windows.Forms.Label();
            this.buttonPath = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.userControlStatus1 = new APP.UserControlStatus();
            this.userControlStatus4 = new APP.UserControlStatus();
            this.userControlStatus5 = new APP.UserControlStatus();
            this.userControlStatus6 = new APP.UserControlStatus();
            this.userControlStatus2 = new APP.UserControlStatus();
            this.userControlStatus3 = new APP.UserControlStatus();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.userControlRegister6 = new APP.UserControlRegister();
            this.userControlRegister5 = new APP.UserControlRegister();
            this.userControlRegister4 = new APP.UserControlRegister();
            this.userControlRegister3 = new APP.UserControlRegister();
            this.userControlRegister2 = new APP.UserControlRegister();
            this.userControlRegister1 = new APP.UserControlRegister();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.userControlMonitor = new APP.UserControlMonitor();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSensor
            // 
            chartArea3.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisX2.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY2.MajorGrid.Enabled = false;
            chartArea3.CursorY.IsUserEnabled = true;
            chartArea3.CursorY.IsUserSelectionEnabled = true;
            chartArea3.Name = "ChartArea";
            this.chartSensor.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.chartSensor.Legends.Add(legend3);
            this.chartSensor.Location = new System.Drawing.Point(1111, 158);
            this.chartSensor.Margin = new System.Windows.Forms.Padding(0);
            this.chartSensor.Name = "chartSensor";
            series13.ChartArea = "ChartArea";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.Red;
            series13.Legend = "Legend1";
            series13.Name = "濃度1";
            series14.ChartArea = "ChartArea";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.Aqua;
            series14.Legend = "Legend1";
            series14.Name = "濃度2";
            series15.ChartArea = "ChartArea";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Color = System.Drawing.Color.Lime;
            series15.Legend = "Legend1";
            series15.Name = "濃度3";
            series16.ChartArea = "ChartArea";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series16.Legend = "Legend1";
            series16.Name = "濃度4";
            series17.ChartArea = "ChartArea";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Color = System.Drawing.Color.Fuchsia;
            series17.Legend = "Legend1";
            series17.Name = "濃度5";
            series18.ChartArea = "ChartArea";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series18.Legend = "Legend1";
            series18.Name = "濃度6";
            this.chartSensor.Series.Add(series13);
            this.chartSensor.Series.Add(series14);
            this.chartSensor.Series.Add(series15);
            this.chartSensor.Series.Add(series16);
            this.chartSensor.Series.Add(series17);
            this.chartSensor.Series.Add(series18);
            this.chartSensor.Size = new System.Drawing.Size(462, 300);
            this.chartSensor.TabIndex = 0;
            this.chartSensor.Text = "chart";
            // 
            // chartTemperature
            // 
            chartArea4.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea4.AxisX.LineWidth = 0;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisX2.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY2.MajorGrid.Enabled = false;
            chartArea4.CursorY.IsUserEnabled = true;
            chartArea4.CursorY.IsUserSelectionEnabled = true;
            chartArea4.Name = "ChartArea";
            this.chartTemperature.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend4);
            this.chartTemperature.Location = new System.Drawing.Point(1111, 465);
            this.chartTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.chartTemperature.Name = "chartTemperature";
            series19.ChartArea = "ChartArea";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Color = System.Drawing.Color.Red;
            series19.Legend = "Legend1";
            series19.Name = "温度1";
            series20.ChartArea = "ChartArea";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Color = System.Drawing.Color.Aqua;
            series20.Legend = "Legend1";
            series20.Name = "温度2";
            series21.ChartArea = "ChartArea";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Color = System.Drawing.Color.Lime;
            series21.Legend = "Legend1";
            series21.Name = "温度3";
            series22.ChartArea = "ChartArea";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series22.Legend = "Legend1";
            series22.Name = "温度4";
            series23.ChartArea = "ChartArea";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Color = System.Drawing.Color.Fuchsia;
            series23.Legend = "Legend1";
            series23.Name = "温度5";
            series24.ChartArea = "ChartArea";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series24.Legend = "Legend1";
            series24.Name = "温度6";
            this.chartTemperature.Series.Add(series19);
            this.chartTemperature.Series.Add(series20);
            this.chartTemperature.Series.Add(series21);
            this.chartTemperature.Series.Add(series22);
            this.chartTemperature.Series.Add(series23);
            this.chartTemperature.Series.Add(series24);
            this.chartTemperature.Size = new System.Drawing.Size(462, 300);
            this.chartTemperature.TabIndex = 1;
            this.chartTemperature.Text = "chart1";
            // 
            // tmrRead
            // 
            this.tmrRead.Interval = 200;
            this.tmrRead.Tick += new System.EventHandler(this.tmrRead_Tick);
            // 
            // labelRunTime
            // 
            this.labelRunTime.Font = new System.Drawing.Font("メイリオ", 9F);
            this.labelRunTime.Location = new System.Drawing.Point(165, 742);
            this.labelRunTime.Name = "labelRunTime";
            this.labelRunTime.Size = new System.Drawing.Size(91, 19);
            this.labelRunTime.TabIndex = 146;
            this.labelRunTime.Text = "XX:XX:XX";
            this.labelRunTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRunTime.Visible = false;
            // 
            // buttonPath
            // 
            this.buttonPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPath.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Bold);
            this.buttonPath.ForeColor = System.Drawing.Color.White;
            this.buttonPath.Location = new System.Drawing.Point(899, 737);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(80, 26);
            this.buttonPath.TabIndex = 149;
            this.buttonPath.Text = "参照";
            this.buttonPath.UseVisualStyleBackColor = false;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBoxPath.Location = new System.Drawing.Point(315, 740);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(570, 21);
            this.textBoxPath.TabIndex = 148;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label4.Location = new System.Drawing.Point(247, 742);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 147;
            this.label4.Text = "ログ保存先";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1105, 730);
            this.tabControl1.TabIndex = 164;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.userControlStatus1);
            this.tabPage1.Controls.Add(this.userControlStatus4);
            this.tabPage1.Controls.Add(this.userControlStatus5);
            this.tabPage1.Controls.Add(this.userControlStatus6);
            this.tabPage1.Controls.Add(this.userControlStatus2);
            this.tabPage1.Controls.Add(this.userControlStatus3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1097, 704);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Status";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(19, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 22);
            this.label7.TabIndex = 170;
            this.label7.Text = "1ch";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(747, 365);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 22);
            this.label8.TabIndex = 175;
            this.label8.Text = "6ch";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(382, 365);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 22);
            this.label9.TabIndex = 174;
            this.label9.Text = "5ch";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(19, 365);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 22);
            this.label10.TabIndex = 173;
            this.label10.Text = "4ch";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(747, 18);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 22);
            this.label11.TabIndex = 172;
            this.label11.Text = "3ch";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(381, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 22);
            this.label12.TabIndex = 171;
            this.label12.Text = "2ch";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userControlStatus1
            // 
            this.userControlStatus1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlStatus1.Location = new System.Drawing.Point(5, 8);
            this.userControlStatus1.Name = "userControlStatus1";
            this.userControlStatus1.Size = new System.Drawing.Size(358, 340);
            this.userControlStatus1.TabIndex = 2;
            // 
            // userControlStatus4
            // 
            this.userControlStatus4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlStatus4.Location = new System.Drawing.Point(5, 356);
            this.userControlStatus4.Name = "userControlStatus4";
            this.userControlStatus4.Size = new System.Drawing.Size(358, 340);
            this.userControlStatus4.TabIndex = 5;
            // 
            // userControlStatus5
            // 
            this.userControlStatus5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlStatus5.Location = new System.Drawing.Point(369, 356);
            this.userControlStatus5.Name = "userControlStatus5";
            this.userControlStatus5.Size = new System.Drawing.Size(358, 340);
            this.userControlStatus5.TabIndex = 6;
            // 
            // userControlStatus6
            // 
            this.userControlStatus6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlStatus6.Location = new System.Drawing.Point(732, 356);
            this.userControlStatus6.Name = "userControlStatus6";
            this.userControlStatus6.Size = new System.Drawing.Size(358, 340);
            this.userControlStatus6.TabIndex = 7;
            // 
            // userControlStatus2
            // 
            this.userControlStatus2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlStatus2.Location = new System.Drawing.Point(369, 8);
            this.userControlStatus2.Name = "userControlStatus2";
            this.userControlStatus2.Size = new System.Drawing.Size(358, 340);
            this.userControlStatus2.TabIndex = 3;
            // 
            // userControlStatus3
            // 
            this.userControlStatus3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlStatus3.Location = new System.Drawing.Point(733, 8);
            this.userControlStatus3.Name = "userControlStatus3";
            this.userControlStatus3.Size = new System.Drawing.Size(358, 340);
            this.userControlStatus3.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.userControlRegister6);
            this.tabPage2.Controls.Add(this.userControlRegister5);
            this.tabPage2.Controls.Add(this.userControlRegister4);
            this.tabPage2.Controls.Add(this.userControlRegister3);
            this.tabPage2.Controls.Add(this.userControlRegister2);
            this.tabPage2.Controls.Add(this.userControlRegister1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1097, 704);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "設定";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 22);
            this.label1.TabIndex = 176;
            this.label1.Text = "1ch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(747, 365);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 22);
            this.label2.TabIndex = 181;
            this.label2.Text = "6ch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(382, 365);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 180;
            this.label3.Text = "5ch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gray;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 22);
            this.label5.TabIndex = 179;
            this.label5.Text = "4ch";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Gray;
            this.label6.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(747, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 22);
            this.label6.TabIndex = 178;
            this.label6.Text = "3ch";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Gray;
            this.label13.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(381, 18);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 22);
            this.label13.TabIndex = 177;
            this.label13.Text = "2ch";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userControlRegister6
            // 
            this.userControlRegister6.BackColor = System.Drawing.SystemColors.Control;
            this.userControlRegister6.Location = new System.Drawing.Point(733, 355);
            this.userControlRegister6.Name = "userControlRegister6";
            this.userControlRegister6.Size = new System.Drawing.Size(358, 340);
            this.userControlRegister6.TabIndex = 175;
            // 
            // userControlRegister5
            // 
            this.userControlRegister5.BackColor = System.Drawing.SystemColors.Control;
            this.userControlRegister5.Location = new System.Drawing.Point(370, 355);
            this.userControlRegister5.Name = "userControlRegister5";
            this.userControlRegister5.Size = new System.Drawing.Size(358, 340);
            this.userControlRegister5.TabIndex = 174;
            // 
            // userControlRegister4
            // 
            this.userControlRegister4.BackColor = System.Drawing.SystemColors.Control;
            this.userControlRegister4.Location = new System.Drawing.Point(6, 355);
            this.userControlRegister4.Name = "userControlRegister4";
            this.userControlRegister4.Size = new System.Drawing.Size(358, 340);
            this.userControlRegister4.TabIndex = 173;
            // 
            // userControlRegister3
            // 
            this.userControlRegister3.BackColor = System.Drawing.SystemColors.Control;
            this.userControlRegister3.Location = new System.Drawing.Point(733, 6);
            this.userControlRegister3.Name = "userControlRegister3";
            this.userControlRegister3.Size = new System.Drawing.Size(358, 340);
            this.userControlRegister3.TabIndex = 172;
            // 
            // userControlRegister2
            // 
            this.userControlRegister2.BackColor = System.Drawing.SystemColors.Control;
            this.userControlRegister2.Location = new System.Drawing.Point(369, 6);
            this.userControlRegister2.Name = "userControlRegister2";
            this.userControlRegister2.Size = new System.Drawing.Size(358, 340);
            this.userControlRegister2.TabIndex = 171;
            // 
            // userControlRegister1
            // 
            this.userControlRegister1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlRegister1.Location = new System.Drawing.Point(6, 6);
            this.userControlRegister1.Name = "userControlRegister1";
            this.userControlRegister1.Size = new System.Drawing.Size(358, 340);
            this.userControlRegister1.TabIndex = 170;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.userControlMonitor);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1097, 704);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "レジスタ操作";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // userControlMonitor
            // 
            this.userControlMonitor.Location = new System.Drawing.Point(9, 13);
            this.userControlMonitor.Name = "userControlMonitor";
            this.userControlMonitor.Size = new System.Drawing.Size(1080, 680);
            this.userControlMonitor.TabIndex = 0;
            // 
            // UserControlUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRunTime);
            this.Controls.Add(this.chartTemperature);
            this.Controls.Add(this.chartSensor);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlUnits";
            this.Size = new System.Drawing.Size(1580, 770);
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart chartSensor;
        public System.Windows.Forms.DataVisualization.Charting.Chart chartTemperature;
        private System.Windows.Forms.Label labelRunTime;
        private System.Windows.Forms.Button buttonPath;
        public System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label4;
        public UserControlStatus userControlStatus1;
        public UserControlStatus userControlStatus2;
        public UserControlStatus userControlStatus3;
        public UserControlStatus userControlStatus4;
        public UserControlStatus userControlStatus5;
        public UserControlStatus userControlStatus6;
        public System.Windows.Forms.Timer tmrRead;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private UserControlRegister userControlRegister6;
        private UserControlRegister userControlRegister5;
        private UserControlRegister userControlRegister4;
        private UserControlRegister userControlRegister3;
        private UserControlRegister userControlRegister2;
        private UserControlRegister userControlRegister1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private UserControlMonitor userControlMonitor;
    }
}
