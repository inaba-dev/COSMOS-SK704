namespace APP
{
    partial class FormMain
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMessages = new System.Windows.Forms.ListView();
            this.clhType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clhData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupSetup = new System.Windows.Forms.GroupBox();
            this.radioTypeC = new System.Windows.Forms.RadioButton();
            this.radioTypeB = new System.Windows.Forms.RadioButton();
            this.radioTypeA = new System.Windows.Forms.RadioButton();
            this.cbbChannel6 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbChannel5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbChannel4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbChannel3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbChannel2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonScan = new System.Windows.Forms.Button();
            this.cbbChannel1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbBaudrates = new System.Windows.Forms.ComboBox();
            this.laBaudrate = new System.Windows.Forms.Label();
            this.buttonDisConnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.userControlUnits = new APP.UserControlUnits();
            this.buttonLog = new System.Windows.Forms.Button();
            this.groupSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMessages
            // 
            this.lstMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clhType,
            this.clhID,
            this.clhLength,
            this.clhData});
            this.lstMessages.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lstMessages.FullRowSelect = true;
            this.lstMessages.HideSelection = false;
            this.lstMessages.Location = new System.Drawing.Point(739, 11);
            this.lstMessages.MultiSelect = false;
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(510, 140);
            this.lstMessages.TabIndex = 137;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.Details;
            // 
            // clhType
            // 
            this.clhType.Text = "Type";
            this.clhType.Width = 70;
            // 
            // clhID
            // 
            this.clhID.Text = "ID";
            this.clhID.Width = 100;
            // 
            // clhLength
            // 
            this.clhLength.Text = "Len";
            this.clhLength.Width = 40;
            // 
            // clhData
            // 
            this.clhData.Text = "Data";
            this.clhData.Width = 295;
            // 
            // groupSetup
            // 
            this.groupSetup.Controls.Add(this.radioTypeC);
            this.groupSetup.Controls.Add(this.radioTypeB);
            this.groupSetup.Controls.Add(this.radioTypeA);
            this.groupSetup.Controls.Add(this.cbbChannel6);
            this.groupSetup.Controls.Add(this.label4);
            this.groupSetup.Controls.Add(this.cbbChannel5);
            this.groupSetup.Controls.Add(this.label5);
            this.groupSetup.Controls.Add(this.cbbChannel4);
            this.groupSetup.Controls.Add(this.label6);
            this.groupSetup.Controls.Add(this.cbbChannel3);
            this.groupSetup.Controls.Add(this.label3);
            this.groupSetup.Controls.Add(this.cbbChannel2);
            this.groupSetup.Controls.Add(this.label1);
            this.groupSetup.Controls.Add(this.buttonScan);
            this.groupSetup.Controls.Add(this.cbbChannel1);
            this.groupSetup.Controls.Add(this.label2);
            this.groupSetup.Controls.Add(this.cbbBaudrates);
            this.groupSetup.Controls.Add(this.laBaudrate);
            this.groupSetup.Location = new System.Drawing.Point(14, 71);
            this.groupSetup.Name = "groupSetup";
            this.groupSetup.Size = new System.Drawing.Size(719, 80);
            this.groupSetup.TabIndex = 143;
            this.groupSetup.TabStop = false;
            this.groupSetup.Text = "通信設定";
            // 
            // radioTypeC
            // 
            this.radioTypeC.AutoSize = true;
            this.radioTypeC.Font = new System.Drawing.Font("メイリオ", 7F);
            this.radioTypeC.Location = new System.Drawing.Point(110, 53);
            this.radioTypeC.Name = "radioTypeC";
            this.radioTypeC.Size = new System.Drawing.Size(55, 19);
            this.radioTypeC.TabIndex = 191;
            this.radioTypeC.Text = "TypeC";
            this.radioTypeC.UseVisualStyleBackColor = true;
            // 
            // radioTypeB
            // 
            this.radioTypeB.AutoSize = true;
            this.radioTypeB.Font = new System.Drawing.Font("メイリオ", 7F);
            this.radioTypeB.Location = new System.Drawing.Point(110, 34);
            this.radioTypeB.Name = "radioTypeB";
            this.radioTypeB.Size = new System.Drawing.Size(55, 19);
            this.radioTypeB.TabIndex = 190;
            this.radioTypeB.Text = "TypeB";
            this.radioTypeB.UseVisualStyleBackColor = true;
            // 
            // radioTypeA
            // 
            this.radioTypeA.AutoSize = true;
            this.radioTypeA.Checked = true;
            this.radioTypeA.Font = new System.Drawing.Font("メイリオ", 7F);
            this.radioTypeA.Location = new System.Drawing.Point(110, 15);
            this.radioTypeA.Name = "radioTypeA";
            this.radioTypeA.Size = new System.Drawing.Size(55, 19);
            this.radioTypeA.TabIndex = 189;
            this.radioTypeA.TabStop = true;
            this.radioTypeA.Text = "TypeA";
            this.radioTypeA.UseVisualStyleBackColor = true;
            // 
            // cbbChannel6
            // 
            this.cbbChannel6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChannel6.Items.AddRange(new object[] {
            "None",
            "DNG-Channel 1",
            "ISA-Channel 1",
            "ISA-Channel 2",
            "ISA-Channel 3",
            "ISA-Channel 4",
            "ISA-Channel 5",
            "ISA-Channel 6",
            "ISA-Channel 7",
            "ISA-Channel 8",
            "PCC-Channel 1",
            "PCC-Channel 2",
            "PCI-Channel 1",
            "PCI-Channel 2",
            "PCI-Channel 3",
            "PCI-Channel 4",
            "PCI-Channel 5",
            "PCI-Channel 6",
            "PCI-Channel 7",
            "PCI-Channel 8",
            "USB-Channel 1",
            "USB-Channel 2",
            "USB-Channel 3",
            "USB-Channel 4",
            "USB-Channel 5",
            "USB-Channel 6",
            "USB-Channel 7",
            "USB-Channel 8"});
            this.cbbChannel6.Location = new System.Drawing.Point(579, 53);
            this.cbbChannel6.Name = "cbbChannel6";
            this.cbbChannel6.Size = new System.Drawing.Size(127, 21);
            this.cbbChannel6.TabIndex = 162;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.label4.Location = new System.Drawing.Point(577, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 161;
            this.label4.Text = "Hardware6";
            // 
            // cbbChannel5
            // 
            this.cbbChannel5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChannel5.Items.AddRange(new object[] {
            "None",
            "DNG-Channel 1",
            "ISA-Channel 1",
            "ISA-Channel 2",
            "ISA-Channel 3",
            "ISA-Channel 4",
            "ISA-Channel 5",
            "ISA-Channel 6",
            "ISA-Channel 7",
            "ISA-Channel 8",
            "PCC-Channel 1",
            "PCC-Channel 2",
            "PCI-Channel 1",
            "PCI-Channel 2",
            "PCI-Channel 3",
            "PCI-Channel 4",
            "PCI-Channel 5",
            "PCI-Channel 6",
            "PCI-Channel 7",
            "PCI-Channel 8",
            "USB-Channel 1",
            "USB-Channel 2",
            "USB-Channel 3",
            "USB-Channel 4",
            "USB-Channel 5",
            "USB-Channel 6",
            "USB-Channel 7",
            "USB-Channel 8"});
            this.cbbChannel5.Location = new System.Drawing.Point(434, 53);
            this.cbbChannel5.Name = "cbbChannel5";
            this.cbbChannel5.Size = new System.Drawing.Size(127, 21);
            this.cbbChannel5.TabIndex = 160;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.label5.Location = new System.Drawing.Point(432, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 159;
            this.label5.Text = "Hardware5";
            // 
            // cbbChannel4
            // 
            this.cbbChannel4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChannel4.Items.AddRange(new object[] {
            "None",
            "DNG-Channel 1",
            "ISA-Channel 1",
            "ISA-Channel 2",
            "ISA-Channel 3",
            "ISA-Channel 4",
            "ISA-Channel 5",
            "ISA-Channel 6",
            "ISA-Channel 7",
            "ISA-Channel 8",
            "PCC-Channel 1",
            "PCC-Channel 2",
            "PCI-Channel 1",
            "PCI-Channel 2",
            "PCI-Channel 3",
            "PCI-Channel 4",
            "PCI-Channel 5",
            "PCI-Channel 6",
            "PCI-Channel 7",
            "PCI-Channel 8",
            "USB-Channel 1",
            "USB-Channel 2",
            "USB-Channel 3",
            "USB-Channel 4",
            "USB-Channel 5",
            "USB-Channel 6",
            "USB-Channel 7",
            "USB-Channel 8"});
            this.cbbChannel4.Location = new System.Drawing.Point(285, 53);
            this.cbbChannel4.Name = "cbbChannel4";
            this.cbbChannel4.Size = new System.Drawing.Size(127, 21);
            this.cbbChannel4.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.label6.Location = new System.Drawing.Point(283, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 158;
            this.label6.Text = "Hardware4";
            // 
            // cbbChannel3
            // 
            this.cbbChannel3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChannel3.Items.AddRange(new object[] {
            "None",
            "DNG-Channel 1",
            "ISA-Channel 1",
            "ISA-Channel 2",
            "ISA-Channel 3",
            "ISA-Channel 4",
            "ISA-Channel 5",
            "ISA-Channel 6",
            "ISA-Channel 7",
            "ISA-Channel 8",
            "PCC-Channel 1",
            "PCC-Channel 2",
            "PCI-Channel 1",
            "PCI-Channel 2",
            "PCI-Channel 3",
            "PCI-Channel 4",
            "PCI-Channel 5",
            "PCI-Channel 6",
            "PCI-Channel 7",
            "PCI-Channel 8",
            "USB-Channel 1",
            "USB-Channel 2",
            "USB-Channel 3",
            "USB-Channel 4",
            "USB-Channel 5",
            "USB-Channel 6",
            "USB-Channel 7",
            "USB-Channel 8"});
            this.cbbChannel3.Location = new System.Drawing.Point(579, 20);
            this.cbbChannel3.Name = "cbbChannel3";
            this.cbbChannel3.Size = new System.Drawing.Size(127, 21);
            this.cbbChannel3.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.label3.Location = new System.Drawing.Point(577, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 155;
            this.label3.Text = "Hardware3";
            // 
            // cbbChannel2
            // 
            this.cbbChannel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChannel2.Items.AddRange(new object[] {
            "None",
            "DNG-Channel 1",
            "ISA-Channel 1",
            "ISA-Channel 2",
            "ISA-Channel 3",
            "ISA-Channel 4",
            "ISA-Channel 5",
            "ISA-Channel 6",
            "ISA-Channel 7",
            "ISA-Channel 8",
            "PCC-Channel 1",
            "PCC-Channel 2",
            "PCI-Channel 1",
            "PCI-Channel 2",
            "PCI-Channel 3",
            "PCI-Channel 4",
            "PCI-Channel 5",
            "PCI-Channel 6",
            "PCI-Channel 7",
            "PCI-Channel 8",
            "USB-Channel 1",
            "USB-Channel 2",
            "USB-Channel 3",
            "USB-Channel 4",
            "USB-Channel 5",
            "USB-Channel 6",
            "USB-Channel 7",
            "USB-Channel 8"});
            this.cbbChannel2.Location = new System.Drawing.Point(434, 20);
            this.cbbChannel2.Name = "cbbChannel2";
            this.cbbChannel2.Size = new System.Drawing.Size(127, 21);
            this.cbbChannel2.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.label1.Location = new System.Drawing.Point(432, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 153;
            this.label1.Text = "Hardware2";
            // 
            // buttonScan
            // 
            this.buttonScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonScan.Location = new System.Drawing.Point(11, 23);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(84, 50);
            this.buttonScan.TabIndex = 150;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // cbbChannel1
            // 
            this.cbbChannel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbChannel1.Items.AddRange(new object[] {
            "None",
            "DNG-Channel 1",
            "ISA-Channel 1",
            "ISA-Channel 2",
            "ISA-Channel 3",
            "ISA-Channel 4",
            "ISA-Channel 5",
            "ISA-Channel 6",
            "ISA-Channel 7",
            "ISA-Channel 8",
            "PCC-Channel 1",
            "PCC-Channel 2",
            "PCI-Channel 1",
            "PCI-Channel 2",
            "PCI-Channel 3",
            "PCI-Channel 4",
            "PCI-Channel 5",
            "PCI-Channel 6",
            "PCI-Channel 7",
            "PCI-Channel 8",
            "USB-Channel 1",
            "USB-Channel 2",
            "USB-Channel 3",
            "USB-Channel 4",
            "USB-Channel 5",
            "USB-Channel 6",
            "USB-Channel 7",
            "USB-Channel 8"});
            this.cbbChannel1.Location = new System.Drawing.Point(285, 20);
            this.cbbChannel1.Name = "cbbChannel1";
            this.cbbChannel1.Size = new System.Drawing.Size(127, 21);
            this.cbbChannel1.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.label2.Location = new System.Drawing.Point(283, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 136;
            this.label2.Text = "Hardware1";
            // 
            // cbbBaudrates
            // 
            this.cbbBaudrates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaudrates.Items.AddRange(new object[] {
            "1 MBit/sec",
            "800 kBit/s",
            "500 kBit/sec",
            "250 kBit/sec",
            "125 kBit/sec",
            "100 kBit/sec",
            "83,333 kBit/s",
            "50 kBit/sec",
            "33,333 kBit/s",
            "20 kBit/sec"});
            this.cbbBaudrates.Location = new System.Drawing.Point(177, 21);
            this.cbbBaudrates.Name = "cbbBaudrates";
            this.cbbBaudrates.Size = new System.Drawing.Size(93, 20);
            this.cbbBaudrates.TabIndex = 133;
            this.cbbBaudrates.SelectedIndexChanged += new System.EventHandler(this.cbbBaudrates_SelectedIndexChanged);
            // 
            // laBaudrate
            // 
            this.laBaudrate.Font = new System.Drawing.Font("MS UI Gothic", 7F);
            this.laBaudrate.Location = new System.Drawing.Point(175, 8);
            this.laBaudrate.Name = "laBaudrate";
            this.laBaudrate.Size = new System.Drawing.Size(56, 21);
            this.laBaudrate.TabIndex = 134;
            this.laBaudrate.Text = "Baudrate";
            // 
            // buttonDisConnect
            // 
            this.buttonDisConnect.BackColor = System.Drawing.Color.Silver;
            this.buttonDisConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisConnect.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonDisConnect.ForeColor = System.Drawing.Color.White;
            this.buttonDisConnect.Location = new System.Drawing.Point(477, 11);
            this.buttonDisConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisConnect.Name = "buttonDisConnect";
            this.buttonDisConnect.Size = new System.Drawing.Size(256, 55);
            this.buttonDisConnect.TabIndex = 142;
            this.buttonDisConnect.Text = "切断する";
            this.buttonDisConnect.UseVisualStyleBackColor = false;
            this.buttonDisConnect.Click += new System.EventHandler(this.buttonDisConnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Location = new System.Drawing.Point(12, 10);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(450, 55);
            this.buttonConnect.TabIndex = 141;
            this.buttonConnect.Text = "接続する";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // userControlUnits
            // 
            this.userControlUnits.Location = new System.Drawing.Point(11, 157);
            this.userControlUnits.Margin = new System.Windows.Forms.Padding(0);
            this.userControlUnits.Name = "userControlUnits";
            this.userControlUnits.Size = new System.Drawing.Size(1240, 650);
            this.userControlUnits.TabIndex = 144;
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.Blue;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Bold);
            this.buttonLog.ForeColor = System.Drawing.Color.White;
            this.buttonLog.Location = new System.Drawing.Point(15, 774);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(116, 28);
            this.buttonLog.TabIndex = 145;
            this.buttonLog.Text = "ロギング開始";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 811);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.groupSetup);
            this.Controls.Add(this.buttonDisConnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.userControlUnits);
            this.MaximumSize = new System.Drawing.Size(1280, 850);
            this.MinimumSize = new System.Drawing.Size(1280, 850);
            this.Name = "FormMain";
            this.Text = "VITESCO-H2CS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupSetup.ResumeLayout(false);
            this.groupSetup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lstMessages;
        private System.Windows.Forms.ColumnHeader clhType;
        private System.Windows.Forms.ColumnHeader clhID;
        private System.Windows.Forms.ColumnHeader clhLength;
        private System.Windows.Forms.ColumnHeader clhData;
        private System.Windows.Forms.GroupBox groupSetup;
        private System.Windows.Forms.ComboBox cbbChannel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbBaudrates;
        private System.Windows.Forms.Label laBaudrate;
        private System.Windows.Forms.Button buttonDisConnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChannel2;
        private System.Windows.Forms.ComboBox cbbChannel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbChannel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbChannel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbChannel4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.RadioButton radioTypeC;
        public System.Windows.Forms.RadioButton radioTypeB;
        public System.Windows.Forms.RadioButton radioTypeA;
        private UserControlUnits userControlUnits;
        private System.Windows.Forms.Button buttonLog;
    }
}

