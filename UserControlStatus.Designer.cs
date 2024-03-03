namespace APP
{
    partial class UserControlStatus
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.checkValid = new System.Windows.Forms.CheckBox();
            this.hardware = new System.Windows.Forms.ComboBox();
            this.textBoxステータス情報 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox温度 = new System.Windows.Forms.TextBox();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.textBox濃度 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.textBoxGas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIDB = new System.Windows.Forms.TextBox();
            this.txtIDA = new System.Windows.Forms.TextBox();
            this.buttonID = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCRC = new System.Windows.Forms.TextBox();
            this.labelCRC = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textReg8 = new System.Windows.Forms.TextBox();
            this.textReg7 = new System.Windows.Forms.TextBox();
            this.textReg6 = new System.Windows.Forms.TextBox();
            this.textReg5 = new System.Windows.Forms.TextBox();
            this.textReg4 = new System.Windows.Forms.TextBox();
            this.textReg3 = new System.Windows.Forms.TextBox();
            this.textReg2 = new System.Windows.Forms.TextBox();
            this.textReg1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox有効性 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxセンサAD値 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(52, 3);
            this.txtID.MaxLength = 3;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(47, 19);
            this.txtID.TabIndex = 176;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label14.Location = new System.Drawing.Point(2, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 19);
            this.label14.TabIndex = 175;
            this.label14.Text = "CAN-ID";
            // 
            // checkValid
            // 
            this.checkValid.AutoSize = true;
            this.checkValid.Font = new System.Drawing.Font("メイリオ", 8F);
            this.checkValid.Location = new System.Drawing.Point(61, 37);
            this.checkValid.Name = "checkValid";
            this.checkValid.Size = new System.Drawing.Size(71, 21);
            this.checkValid.TabIndex = 182;
            this.checkValid.Text = "ログ取得";
            this.checkValid.UseVisualStyleBackColor = true;
            // 
            // hardware
            // 
            this.hardware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hardware.Font = new System.Drawing.Font("Consolas", 9F);
            this.hardware.Items.AddRange(new object[] {
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
            this.hardware.Location = new System.Drawing.Point(61, 10);
            this.hardware.Name = "hardware";
            this.hardware.Size = new System.Drawing.Size(145, 22);
            this.hardware.TabIndex = 183;
            // 
            // textBoxステータス情報
            // 
            this.textBoxステータス情報.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBoxステータス情報.Location = new System.Drawing.Point(92, 145);
            this.textBoxステータス情報.Name = "textBoxステータス情報";
            this.textBoxステータス情報.ReadOnly = true;
            this.textBoxステータス情報.Size = new System.Drawing.Size(160, 21);
            this.textBoxステータス情報.TabIndex = 231;
            this.textBoxステータス情報.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label3.Location = new System.Drawing.Point(4, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 229;
            this.label3.Text = "エラーフラグ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox温度
            // 
            this.textBox温度.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBox温度.Location = new System.Drawing.Point(92, 172);
            this.textBox温度.Name = "textBox温度";
            this.textBox温度.ReadOnly = true;
            this.textBox温度.Size = new System.Drawing.Size(70, 21);
            this.textBox温度.TabIndex = 228;
            this.textBox温度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBoxCounter.Location = new System.Drawing.Point(93, 65);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.ReadOnly = true;
            this.textBoxCounter.Size = new System.Drawing.Size(70, 21);
            this.textBoxCounter.TabIndex = 224;
            this.textBoxCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox濃度
            // 
            this.textBox濃度.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBox濃度.Location = new System.Drawing.Point(92, 118);
            this.textBox濃度.Name = "textBox濃度";
            this.textBox濃度.ReadOnly = true;
            this.textBox濃度.Size = new System.Drawing.Size(70, 21);
            this.textBox濃度.TabIndex = 226;
            this.textBox濃度.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label13.Location = new System.Drawing.Point(4, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 20);
            this.label13.TabIndex = 223;
            this.label13.Text = "カウンタ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label1.Location = new System.Drawing.Point(3, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 227;
            this.label1.Text = "温度";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label17.Location = new System.Drawing.Point(3, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 20);
            this.label17.TabIndex = 225;
            this.label17.Text = "濃度";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxGas
            // 
            this.textBoxGas.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBoxGas.Location = new System.Drawing.Point(93, 91);
            this.textBoxGas.Name = "textBoxGas";
            this.textBoxGas.ReadOnly = true;
            this.textBoxGas.Size = new System.Drawing.Size(70, 21);
            this.textBoxGas.TabIndex = 264;
            this.textBoxGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label2.Location = new System.Drawing.Point(4, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 263;
            this.label2.Text = "GAS conc.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtIDB);
            this.panel2.Controls.Add(this.txtIDA);
            this.panel2.Controls.Add(this.buttonID);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(3, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 50);
            this.panel2.TabIndex = 271;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label16.Location = new System.Drawing.Point(7, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 17);
            this.label16.TabIndex = 276;
            this.label16.Text = "CAN-ID変更";
            // 
            // txtIDB
            // 
            this.txtIDB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDB.Location = new System.Drawing.Point(131, 22);
            this.txtIDB.MaxLength = 3;
            this.txtIDB.Name = "txtIDB";
            this.txtIDB.Size = new System.Drawing.Size(40, 19);
            this.txtIDB.TabIndex = 273;
            this.txtIDB.Text = "20A";
            this.txtIDB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIDA
            // 
            this.txtIDA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDA.Location = new System.Drawing.Point(83, 22);
            this.txtIDA.MaxLength = 3;
            this.txtIDA.Name = "txtIDA";
            this.txtIDA.Size = new System.Drawing.Size(40, 19);
            this.txtIDA.TabIndex = 272;
            this.txtIDA.Text = "202";
            this.txtIDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonID
            // 
            this.buttonID.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonID.Location = new System.Drawing.Point(278, 9);
            this.buttonID.Margin = new System.Windows.Forms.Padding(0);
            this.buttonID.Name = "buttonID";
            this.buttonID.Size = new System.Drawing.Size(58, 31);
            this.buttonID.TabIndex = 271;
            this.buttonID.Text = "ID変更";
            this.buttonID.UseVisualStyleBackColor = true;
            this.buttonID.Click += new System.EventHandler(this.buttonID_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label11.Location = new System.Drawing.Point(85, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 274;
            this.label11.Text = "TypeA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label12.Location = new System.Drawing.Point(133, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 275;
            this.label12.Text = "TypeB";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(214, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 26);
            this.panel3.TabIndex = 272;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label5.Location = new System.Drawing.Point(104, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 19);
            this.label5.TabIndex = 177;
            this.label5.Text = "hex";
            // 
            // textBoxCRC
            // 
            this.textBoxCRC.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBoxCRC.Location = new System.Drawing.Point(92, 224);
            this.textBoxCRC.Name = "textBoxCRC";
            this.textBoxCRC.ReadOnly = true;
            this.textBoxCRC.Size = new System.Drawing.Size(70, 21);
            this.textBoxCRC.TabIndex = 274;
            this.textBoxCRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCRC
            // 
            this.labelCRC.Font = new System.Drawing.Font("メイリオ", 8F);
            this.labelCRC.Location = new System.Drawing.Point(4, 225);
            this.labelCRC.Name = "labelCRC";
            this.labelCRC.Size = new System.Drawing.Size(85, 20);
            this.labelCRC.TabIndex = 273;
            this.labelCRC.Text = "チェックサム";
            this.labelCRC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label6.Location = new System.Drawing.Point(25, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 275;
            this.label6.Text = "Data";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textReg8);
            this.panel1.Controls.Add(this.textReg7);
            this.panel1.Controls.Add(this.textReg6);
            this.panel1.Controls.Add(this.textReg5);
            this.panel1.Controls.Add(this.textReg4);
            this.panel1.Controls.Add(this.textReg3);
            this.panel1.Controls.Add(this.textReg2);
            this.panel1.Controls.Add(this.textReg1);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(263, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(87, 235);
            this.panel1.TabIndex = 276;
            // 
            // textReg8
            // 
            this.textReg8.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textReg8.Location = new System.Drawing.Point(30, 205);
            this.textReg8.Name = "textReg8";
            this.textReg8.ReadOnly = true;
            this.textReg8.Size = new System.Drawing.Size(46, 19);
            this.textReg8.TabIndex = 290;
            this.textReg8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textReg7
            // 
            this.textReg7.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textReg7.Location = new System.Drawing.Point(30, 179);
            this.textReg7.Name = "textReg7";
            this.textReg7.ReadOnly = true;
            this.textReg7.Size = new System.Drawing.Size(46, 19);
            this.textReg7.TabIndex = 289;
            this.textReg7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textReg6
            // 
            this.textReg6.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textReg6.Location = new System.Drawing.Point(30, 154);
            this.textReg6.Name = "textReg6";
            this.textReg6.ReadOnly = true;
            this.textReg6.Size = new System.Drawing.Size(46, 19);
            this.textReg6.TabIndex = 288;
            this.textReg6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textReg5
            // 
            this.textReg5.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textReg5.Location = new System.Drawing.Point(30, 128);
            this.textReg5.Name = "textReg5";
            this.textReg5.ReadOnly = true;
            this.textReg5.Size = new System.Drawing.Size(46, 19);
            this.textReg5.TabIndex = 287;
            this.textReg5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textReg4
            // 
            this.textReg4.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textReg4.Location = new System.Drawing.Point(30, 103);
            this.textReg4.Name = "textReg4";
            this.textReg4.ReadOnly = true;
            this.textReg4.Size = new System.Drawing.Size(46, 19);
            this.textReg4.TabIndex = 286;
            this.textReg4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textReg3
            // 
            this.textReg3.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textReg3.Location = new System.Drawing.Point(30, 78);
            this.textReg3.Name = "textReg3";
            this.textReg3.ReadOnly = true;
            this.textReg3.Size = new System.Drawing.Size(46, 19);
            this.textReg3.TabIndex = 285;
            this.textReg3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textReg2
            // 
            this.textReg2.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textReg2.Location = new System.Drawing.Point(30, 53);
            this.textReg2.Name = "textReg2";
            this.textReg2.ReadOnly = true;
            this.textReg2.Size = new System.Drawing.Size(46, 19);
            this.textReg2.TabIndex = 284;
            this.textReg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textReg1
            // 
            this.textReg1.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textReg1.Location = new System.Drawing.Point(30, 28);
            this.textReg1.Name = "textReg1";
            this.textReg1.ReadOnly = true;
            this.textReg1.Size = new System.Drawing.Size(46, 19);
            this.textReg1.TabIndex = 277;
            this.textReg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label20.Location = new System.Drawing.Point(5, 204);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 20);
            this.label20.TabIndex = 283;
            this.label20.Text = "8";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label19.Location = new System.Drawing.Point(5, 178);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(25, 20);
            this.label19.TabIndex = 282;
            this.label19.Text = "7";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label18.Location = new System.Drawing.Point(5, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 20);
            this.label18.TabIndex = 281;
            this.label18.Text = "6";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label15.Location = new System.Drawing.Point(5, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 20);
            this.label15.TabIndex = 280;
            this.label15.Text = "5";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label10.Location = new System.Drawing.Point(5, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 20);
            this.label10.TabIndex = 279;
            this.label10.Text = "4";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label9.Location = new System.Drawing.Point(5, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 278;
            this.label9.Text = "3";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label8.Location = new System.Drawing.Point(5, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 277;
            this.label8.Text = "2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label7.Location = new System.Drawing.Point(5, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 276;
            this.label7.Text = "1";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox有効性
            // 
            this.textBox有効性.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBox有効性.Location = new System.Drawing.Point(92, 250);
            this.textBox有効性.Name = "textBox有効性";
            this.textBox有効性.ReadOnly = true;
            this.textBox有効性.Size = new System.Drawing.Size(70, 21);
            this.textBox有効性.TabIndex = 278;
            this.textBox有効性.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label21.Location = new System.Drawing.Point(4, 251);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 20);
            this.label21.TabIndex = 277;
            this.label21.Text = "検知有効性判定";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxセンサAD値
            // 
            this.textBoxセンサAD値.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBoxセンサAD値.Location = new System.Drawing.Point(92, 198);
            this.textBoxセンサAD値.Name = "textBoxセンサAD値";
            this.textBoxセンサAD値.ReadOnly = true;
            this.textBoxセンサAD値.Size = new System.Drawing.Size(70, 21);
            this.textBoxセンサAD値.TabIndex = 280;
            this.textBoxセンサAD値.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label22.Location = new System.Drawing.Point(3, 199);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 20);
            this.label22.TabIndex = 279;
            this.label22.Text = "センサAD値";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label4.Location = new System.Drawing.Point(164, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 281;
            this.label4.Text = "(16進表記)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxセンサAD値);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox有効性);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxCRC);
            this.Controls.Add(this.labelCRC);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxGas);
            this.Controls.Add(this.textBoxステータス情報);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox温度);
            this.Controls.Add(this.textBoxCounter);
            this.Controls.Add(this.textBox濃度);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.hardware);
            this.Controls.Add(this.checkValid);
            this.Controls.Add(this.label2);
            this.Name = "UserControlStatus";
            this.Size = new System.Drawing.Size(358, 340);
            this.Load += new System.EventHandler(this.UserControlStatus_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.CheckBox checkValid;
        private System.Windows.Forms.ComboBox hardware;
        private System.Windows.Forms.TextBox textBoxステータス情報;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox温度;
        private System.Windows.Forms.TextBox textBoxCounter;
        private System.Windows.Forms.TextBox textBox濃度;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.Windows.Forms.TextBox textBoxGas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtIDB;
        public System.Windows.Forms.TextBox txtIDA;
        private System.Windows.Forms.Button buttonID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCRC;
        private System.Windows.Forms.Label labelCRC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textReg8;
        private System.Windows.Forms.TextBox textReg7;
        private System.Windows.Forms.TextBox textReg6;
        private System.Windows.Forms.TextBox textReg5;
        private System.Windows.Forms.TextBox textReg4;
        private System.Windows.Forms.TextBox textReg3;
        private System.Windows.Forms.TextBox textReg2;
        private System.Windows.Forms.TextBox textReg1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox有効性;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxセンサAD値;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label4;
    }
}
