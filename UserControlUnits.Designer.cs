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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSensor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tmrRead = new System.Windows.Forms.Timer(this.components);
            this.labelRunTime = new System.Windows.Forms.Label();
            this.buttonPath = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userControlUnit6 = new APP.UserControlUnit();
            this.userControlUnit5 = new APP.UserControlUnit();
            this.userControlUnit4 = new APP.UserControlUnit();
            this.userControlUnit3 = new APP.UserControlUnit();
            this.userControlUnit2 = new APP.UserControlUnit();
            this.userControlUnit1 = new APP.UserControlUnit();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSensor
            // 
            chartArea1.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX2.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY2.MajorGrid.Enabled = false;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea";
            this.chartSensor.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chartSensor.Legends.Add(legend1);
            this.chartSensor.Location = new System.Drawing.Point(870, 8);
            this.chartSensor.Margin = new System.Windows.Forms.Padding(0);
            this.chartSensor.Name = "chartSensor";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "濃度1";
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Aqua;
            series2.Legend = "Legend1";
            series2.Name = "濃度2";
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Lime;
            series3.Legend = "Legend1";
            series3.Name = "濃度3";
            series4.ChartArea = "ChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend1";
            series4.Name = "濃度4";
            series5.ChartArea = "ChartArea";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Fuchsia;
            series5.Legend = "Legend1";
            series5.Name = "濃度5";
            series6.ChartArea = "ChartArea";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series6.Legend = "Legend1";
            series6.Name = "濃度6";
            this.chartSensor.Series.Add(series1);
            this.chartSensor.Series.Add(series2);
            this.chartSensor.Series.Add(series3);
            this.chartSensor.Series.Add(series4);
            this.chartSensor.Series.Add(series5);
            this.chartSensor.Series.Add(series6);
            this.chartSensor.Size = new System.Drawing.Size(360, 300);
            this.chartSensor.TabIndex = 0;
            this.chartSensor.Text = "chart";
            // 
            // chartTemperature
            // 
            chartArea2.AxisX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            chartArea2.AxisX.LineWidth = 0;
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX2.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY2.MajorGrid.Enabled = false;
            chartArea2.CursorY.IsUserEnabled = true;
            chartArea2.CursorY.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea";
            this.chartTemperature.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chartTemperature.Legends.Add(legend2);
            this.chartTemperature.Location = new System.Drawing.Point(870, 314);
            this.chartTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.chartTemperature.Name = "chartTemperature";
            series7.ChartArea = "ChartArea";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.Name = "温度1";
            series8.ChartArea = "ChartArea";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Aqua;
            series8.Legend = "Legend1";
            series8.Name = "温度2";
            series9.ChartArea = "ChartArea";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Lime;
            series9.Legend = "Legend1";
            series9.Name = "温度3";
            series10.ChartArea = "ChartArea";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series10.Legend = "Legend1";
            series10.Name = "温度4";
            series11.ChartArea = "ChartArea";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.Fuchsia;
            series11.Legend = "Legend1";
            series11.Name = "温度5";
            series12.ChartArea = "ChartArea";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series12.Legend = "Legend1";
            series12.Name = "温度6";
            this.chartTemperature.Series.Add(series7);
            this.chartTemperature.Series.Add(series8);
            this.chartTemperature.Series.Add(series9);
            this.chartTemperature.Series.Add(series10);
            this.chartTemperature.Series.Add(series11);
            this.chartTemperature.Series.Add(series12);
            this.chartTemperature.Size = new System.Drawing.Size(360, 300);
            this.chartTemperature.TabIndex = 1;
            this.chartTemperature.Text = "chart1";
            // 
            // tmrRead
            // 
            this.tmrRead.Interval = 1000;
            this.tmrRead.Tick += new System.EventHandler(this.tmrRead_Tick);
            // 
            // labelRunTime
            // 
            this.labelRunTime.Font = new System.Drawing.Font("メイリオ", 9F);
            this.labelRunTime.Location = new System.Drawing.Point(179, 622);
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
            this.buttonPath.Location = new System.Drawing.Point(796, 618);
            this.buttonPath.Name = "buttonPath";
            this.buttonPath.Size = new System.Drawing.Size(67, 23);
            this.buttonPath.TabIndex = 149;
            this.buttonPath.Text = "参照";
            this.buttonPath.UseVisualStyleBackColor = false;
            this.buttonPath.Click += new System.EventHandler(this.buttonPath_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(325, 621);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(465, 19);
            this.textBoxPath.TabIndex = 148;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label4.Location = new System.Drawing.Point(261, 622);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 147;
            this.label4.Text = "ログ保存先";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userControlUnit6
            // 
            this.userControlUnit6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlUnit6.Location = new System.Drawing.Point(582, 314);
            this.userControlUnit6.Name = "userControlUnit6";
            this.userControlUnit6.Size = new System.Drawing.Size(280, 300);
            this.userControlUnit6.TabIndex = 7;
            // 
            // userControlUnit5
            // 
            this.userControlUnit5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlUnit5.Location = new System.Drawing.Point(296, 312);
            this.userControlUnit5.Name = "userControlUnit5";
            this.userControlUnit5.Size = new System.Drawing.Size(280, 300);
            this.userControlUnit5.TabIndex = 6;
            // 
            // userControlUnit4
            // 
            this.userControlUnit4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlUnit4.Location = new System.Drawing.Point(10, 313);
            this.userControlUnit4.Name = "userControlUnit4";
            this.userControlUnit4.Size = new System.Drawing.Size(280, 300);
            this.userControlUnit4.TabIndex = 5;
            // 
            // userControlUnit3
            // 
            this.userControlUnit3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlUnit3.Location = new System.Drawing.Point(582, 8);
            this.userControlUnit3.Name = "userControlUnit3";
            this.userControlUnit3.Size = new System.Drawing.Size(280, 300);
            this.userControlUnit3.TabIndex = 4;
            // 
            // userControlUnit2
            // 
            this.userControlUnit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlUnit2.Location = new System.Drawing.Point(296, 7);
            this.userControlUnit2.Name = "userControlUnit2";
            this.userControlUnit2.Size = new System.Drawing.Size(280, 300);
            this.userControlUnit2.TabIndex = 3;
            // 
            // userControlUnit1
            // 
            this.userControlUnit1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userControlUnit1.Location = new System.Drawing.Point(10, 7);
            this.userControlUnit1.Name = "userControlUnit1";
            this.userControlUnit1.Size = new System.Drawing.Size(280, 300);
            this.userControlUnit1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(592, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 18);
            this.label1.TabIndex = 163;
            this.label1.Text = "6ch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 162;
            this.label2.Text = "5ch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 320);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 18);
            this.label3.TabIndex = 161;
            this.label3.Text = "4ch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(592, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 18);
            this.label9.TabIndex = 160;
            this.label9.Text = "3ch";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(306, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 18);
            this.label8.TabIndex = 159;
            this.label8.Text = "2ch";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 18);
            this.label7.TabIndex = 158;
            this.label7.Text = "1ch";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRunTime);
            this.Controls.Add(this.userControlUnit6);
            this.Controls.Add(this.userControlUnit5);
            this.Controls.Add(this.userControlUnit4);
            this.Controls.Add(this.userControlUnit3);
            this.Controls.Add(this.userControlUnit2);
            this.Controls.Add(this.userControlUnit1);
            this.Controls.Add(this.chartTemperature);
            this.Controls.Add(this.chartSensor);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlUnits";
            this.Size = new System.Drawing.Size(1240, 650);
            ((System.ComponentModel.ISupportInitialize)(this.chartSensor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
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
        public UserControlUnit userControlUnit1;
        public UserControlUnit userControlUnit2;
        public UserControlUnit userControlUnit3;
        public UserControlUnit userControlUnit4;
        public UserControlUnit userControlUnit5;
        public UserControlUnit userControlUnit6;
        public System.Windows.Forms.Timer tmrRead;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}
