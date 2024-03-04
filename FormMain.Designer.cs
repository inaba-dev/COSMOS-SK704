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
            this.checkExtender = new System.Windows.Forms.CheckBox();
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
            this.buttonLog = new System.Windows.Forms.Button();
            this.userControlUnits = new APP.UserControlUnits();
            this.buttonClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.lstMessages.Location = new System.Drawing.Point(1111, 109);
            this.lstMessages.MultiSelect = false;
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(369, 130);
            this.lstMessages.TabIndex = 137;
            this.lstMessages.UseCompatibleStateImageBehavior = false;
            this.lstMessages.View = System.Windows.Forms.View.Details;
            // 
            // clhType
            // 
            this.clhType.Text = "Type";
            this.clhType.Width = 45;
            // 
            // clhID
            // 
            this.clhID.Text = "ID";
            this.clhID.Width = 80;
            // 
            // clhLength
            // 
            this.clhLength.Text = "Len";
            this.clhLength.Width = 40;
            // 
            // clhData
            // 
            this.clhData.Text = "Data";
            this.clhData.Width = 200;
            // 
            // groupSetup
            // 
            this.groupSetup.Controls.Add(this.checkExtender);
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
            this.groupSetup.Location = new System.Drawing.Point(274, 8);
            this.groupSetup.Name = "groupSetup";
            this.groupSetup.Size = new System.Drawing.Size(1296, 92);
            this.groupSetup.TabIndex = 143;
            this.groupSetup.TabStop = false;
            this.groupSetup.Text = "通信設定";
            // 
            // checkExtender
            // 
            this.checkExtender.AutoSize = true;
            this.checkExtender.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.checkExtender.Location = new System.Drawing.Point(250, 48);
            this.checkExtender.Name = "checkExtender";
            this.checkExtender.Size = new System.Drawing.Size(72, 16);
            this.checkExtender.TabIndex = 261;
            this.checkExtender.Text = "CAN拡張";
            this.checkExtender.UseVisualStyleBackColor = true;
            this.checkExtender.Visible = false;
            // 
            // cbbChannel6
            // 
            this.cbbChannel6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel6.Font = new System.Drawing.Font("Consolas", 9F);
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
            this.cbbChannel6.Location = new System.Drawing.Point(1128, 45);
            this.cbbChannel6.Name = "cbbChannel6";
            this.cbbChannel6.Size = new System.Drawing.Size(145, 22);
            this.cbbChannel6.TabIndex = 162;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label4.Location = new System.Drawing.Point(1126, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 161;
            this.label4.Text = "Hardware6";
            // 
            // cbbChannel5
            // 
            this.cbbChannel5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel5.Font = new System.Drawing.Font("Consolas", 9F);
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
            this.cbbChannel5.Location = new System.Drawing.Point(970, 45);
            this.cbbChannel5.Name = "cbbChannel5";
            this.cbbChannel5.Size = new System.Drawing.Size(145, 22);
            this.cbbChannel5.TabIndex = 160;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label5.Location = new System.Drawing.Point(968, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 21);
            this.label5.TabIndex = 159;
            this.label5.Text = "Hardware5";
            // 
            // cbbChannel4
            // 
            this.cbbChannel4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel4.Font = new System.Drawing.Font("Consolas", 9F);
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
            this.cbbChannel4.Location = new System.Drawing.Point(812, 45);
            this.cbbChannel4.Name = "cbbChannel4";
            this.cbbChannel4.Size = new System.Drawing.Size(145, 22);
            this.cbbChannel4.TabIndex = 157;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label6.Location = new System.Drawing.Point(810, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 158;
            this.label6.Text = "Hardware4";
            // 
            // cbbChannel3
            // 
            this.cbbChannel3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel3.Font = new System.Drawing.Font("Consolas", 9F);
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
            this.cbbChannel3.Location = new System.Drawing.Point(654, 45);
            this.cbbChannel3.Name = "cbbChannel3";
            this.cbbChannel3.Size = new System.Drawing.Size(145, 22);
            this.cbbChannel3.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label3.Location = new System.Drawing.Point(652, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 155;
            this.label3.Text = "Hardware3";
            // 
            // cbbChannel2
            // 
            this.cbbChannel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel2.Font = new System.Drawing.Font("Consolas", 9F);
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
            this.cbbChannel2.Location = new System.Drawing.Point(496, 45);
            this.cbbChannel2.Name = "cbbChannel2";
            this.cbbChannel2.Size = new System.Drawing.Size(145, 22);
            this.cbbChannel2.TabIndex = 154;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label1.Location = new System.Drawing.Point(494, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 153;
            this.label1.Text = "Hardware2";
            // 
            // buttonScan
            // 
            this.buttonScan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonScan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonScan.Location = new System.Drawing.Point(18, 22);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(101, 54);
            this.buttonScan.TabIndex = 150;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // cbbChannel1
            // 
            this.cbbChannel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbChannel1.Font = new System.Drawing.Font("Consolas", 9F);
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
            this.cbbChannel1.Location = new System.Drawing.Point(338, 45);
            this.cbbChannel1.Name = "cbbChannel1";
            this.cbbChannel1.Size = new System.Drawing.Size(145, 22);
            this.cbbChannel1.TabIndex = 135;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.label2.Location = new System.Drawing.Point(336, 24);
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
            this.cbbBaudrates.Location = new System.Drawing.Point(138, 45);
            this.cbbBaudrates.Name = "cbbBaudrates";
            this.cbbBaudrates.Size = new System.Drawing.Size(93, 20);
            this.cbbBaudrates.TabIndex = 133;
            this.cbbBaudrates.SelectedIndexChanged += new System.EventHandler(this.cbbBaudrates_SelectedIndexChanged);
            // 
            // laBaudrate
            // 
            this.laBaudrate.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.laBaudrate.Location = new System.Drawing.Point(137, 29);
            this.laBaudrate.Name = "laBaudrate";
            this.laBaudrate.Size = new System.Drawing.Size(56, 19);
            this.laBaudrate.TabIndex = 134;
            this.laBaudrate.Text = "Baudrate";
            // 
            // buttonDisConnect
            // 
            this.buttonDisConnect.BackColor = System.Drawing.Color.Silver;
            this.buttonDisConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisConnect.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Bold);
            this.buttonDisConnect.ForeColor = System.Drawing.Color.White;
            this.buttonDisConnect.Location = new System.Drawing.Point(151, 14);
            this.buttonDisConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisConnect.Name = "buttonDisConnect";
            this.buttonDisConnect.Size = new System.Drawing.Size(114, 63);
            this.buttonDisConnect.TabIndex = 142;
            this.buttonDisConnect.Text = "切断";
            this.buttonDisConnect.UseVisualStyleBackColor = false;
            this.buttonDisConnect.Click += new System.EventHandler(this.buttonDisConnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Bold);
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.Location = new System.Drawing.Point(12, 13);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(134, 64);
            this.buttonConnect.TabIndex = 141;
            this.buttonConnect.Text = "接続";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.Blue;
            this.buttonLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLog.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Bold);
            this.buttonLog.ForeColor = System.Drawing.Color.White;
            this.buttonLog.Location = new System.Drawing.Point(11, 822);
            this.buttonLog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(116, 30);
            this.buttonLog.TabIndex = 145;
            this.buttonLog.Text = "ロギング開始";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // userControlUnits
            // 
            this.userControlUnits.Location = new System.Drawing.Point(1, 87);
            this.userControlUnits.Margin = new System.Windows.Forms.Padding(0);
            this.userControlUnits.Name = "userControlUnits";
            this.userControlUnits.Size = new System.Drawing.Size(1580, 770);
            this.userControlUnits.TabIndex = 144;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(1493, 109);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(77, 130);
            this.buttonClear.TabIndex = 146;
            this.buttonClear.Text = "クリア";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 127);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 22);
            this.label7.TabIndex = 164;
            this.label7.Text = "1ch";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Gray;
            this.label8.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(753, 475);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 22);
            this.label8.TabIndex = 169;
            this.label8.Text = "6ch";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Gray;
            this.label9.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(388, 475);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 22);
            this.label9.TabIndex = 168;
            this.label9.Text = "5ch";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Gray;
            this.label10.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 475);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 22);
            this.label10.TabIndex = 167;
            this.label10.Text = "4ch";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(753, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 22);
            this.label11.TabIndex = 166;
            this.label11.Text = "3ch";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Gray;
            this.label12.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(387, 128);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 22);
            this.label12.TabIndex = 165;
            this.label12.Text = "2ch";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.groupSetup);
            this.Controls.Add(this.buttonDisConnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.userControlUnits);
            this.Name = "FormMain";
            this.Text = "SK704";
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
        private UserControlUnits userControlUnits;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.CheckBox checkExtender;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

