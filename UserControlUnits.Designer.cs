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
            this.userControlStatus1 = new APP.UserControlStatus();
            this.userControlStatus4 = new APP.UserControlStatus();
            this.userControlStatus5 = new APP.UserControlStatus();
            this.userControlStatus6 = new APP.UserControlStatus();
            this.userControlStatus2 = new APP.UserControlStatus();
            this.userControlStatus3 = new APP.UserControlStatus();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userControlRegister6 = new APP.UserControlRegister();
            this.userControlRegister5 = new APP.UserControlRegister();
            this.userControlRegister4 = new APP.UserControlRegister();
            this.userControlRegister3 = new APP.UserControlRegister();
            this.userControlRegister2 = new APP.UserControlRegister();
            this.userControlRegister1 = new APP.UserControlRegister();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1105, 730);
            this.tabControl1.TabIndex = 164;
            // 
            // tabPage1
            // 
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
    }
}
