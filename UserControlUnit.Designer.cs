namespace APP
{
    partial class UserControlUnit
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
            this.textBoxエラーフラグ = new System.Windows.Forms.TextBox();
            this.textBoxステータスフラグ = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxReg読出し = new System.Windows.Forms.TextBox();
            this.numericCommand = new System.Windows.Forms.NumericUpDown();
            this.buttonRegRead = new System.Windows.Forms.Button();
            this.buttonSet製造番号 = new System.Windows.Forms.Button();
            this.buttonGet製造番号 = new System.Windows.Forms.Button();
            this.textBox製造番号 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numeric20000ppm = new System.Windows.Forms.NumericUpDown();
            this.numeric0ppm = new System.Windows.Forms.NumericUpDown();
            this.numericオフセット = new System.Windows.Forms.NumericUpDown();
            this.buttonSet20000ppm = new System.Windows.Forms.Button();
            this.buttonSet0ppm = new System.Windows.Forms.Button();
            this.buttonSetオフセット = new System.Windows.Forms.Button();
            this.textBox20000ppm = new System.Windows.Forms.TextBox();
            this.buttonGet20000ppm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox0ppm = new System.Windows.Forms.TextBox();
            this.buttonGet0ppm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxオフセット = new System.Windows.Forms.TextBox();
            this.buttonGetオフセット = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxバージョン = new System.Windows.Forms.TextBox();
            this.buttonGetバージョン = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.textBoxエラー情報 = new System.Windows.Forms.TextBox();
            this.textBoxステータス情報 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox温度 = new System.Windows.Forms.TextBox();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.textBox濃度 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonFlashInit = new System.Windows.Forms.Button();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.textBox製造番号W = new APP.TextBoxNumberEx();
            this.buttonRegWrite = new System.Windows.Forms.Button();
            this.textBoxReg書込み = new System.Windows.Forms.NumericUpDown();
            this.textBoxGas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGasRaw = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCRC = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtIDB = new System.Windows.Forms.TextBox();
            this.txtIDA = new System.Windows.Forms.TextBox();
            this.buttonID = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCommand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric20000ppm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric0ppm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericオフセット)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxReg書込み)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(53, 5);
            this.txtID.MaxLength = 3;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(40, 19);
            this.txtID.TabIndex = 176;
            this.txtID.Text = "0";
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label14.Location = new System.Drawing.Point(1, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 19);
            this.label14.TabIndex = 175;
            this.label14.Text = "CANID(h)";
            // 
            // checkValid
            // 
            this.checkValid.AutoSize = true;
            this.checkValid.Font = new System.Drawing.Font("メイリオ", 7F);
            this.checkValid.Location = new System.Drawing.Point(188, 8);
            this.checkValid.Name = "checkValid";
            this.checkValid.Size = new System.Drawing.Size(66, 19);
            this.checkValid.TabIndex = 182;
            this.checkValid.Text = "ログ取得";
            this.checkValid.UseVisualStyleBackColor = true;
            // 
            // hardware
            // 
            this.hardware.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hardware.Font = new System.Drawing.Font("Consolas", 8F);
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
            this.hardware.Location = new System.Drawing.Point(57, 6);
            this.hardware.Name = "hardware";
            this.hardware.Size = new System.Drawing.Size(120, 21);
            this.hardware.TabIndex = 183;
            // 
            // textBoxエラーフラグ
            // 
            this.textBoxエラーフラグ.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxエラーフラグ.Location = new System.Drawing.Point(72, 143);
            this.textBoxエラーフラグ.Name = "textBoxエラーフラグ";
            this.textBoxエラーフラグ.ReadOnly = true;
            this.textBoxエラーフラグ.Size = new System.Drawing.Size(36, 19);
            this.textBoxエラーフラグ.TabIndex = 258;
            // 
            // textBoxステータスフラグ
            // 
            this.textBoxステータスフラグ.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxステータスフラグ.Location = new System.Drawing.Point(72, 120);
            this.textBoxステータスフラグ.Name = "textBoxステータスフラグ";
            this.textBoxステータスフラグ.ReadOnly = true;
            this.textBoxステータスフラグ.Size = new System.Drawing.Size(36, 19);
            this.textBoxステータスフラグ.TabIndex = 257;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxReg書込み);
            this.panel1.Controls.Add(this.buttonRegWrite);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBoxReg読出し);
            this.panel1.Controls.Add(this.numericCommand);
            this.panel1.Controls.Add(this.buttonRegRead);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Location = new System.Drawing.Point(6, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 45);
            this.panel1.TabIndex = 256;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label9.Location = new System.Drawing.Point(4, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 15);
            this.label9.TabIndex = 214;
            this.label9.Text = "No.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label16.Location = new System.Drawing.Point(4, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 15);
            this.label16.TabIndex = 211;
            this.label16.Text = "レジスタ Write/Read";
            // 
            // textBoxReg読出し
            // 
            this.textBoxReg読出し.Location = new System.Drawing.Point(138, 20);
            this.textBoxReg読出し.Name = "textBoxReg読出し";
            this.textBoxReg読出し.ReadOnly = true;
            this.textBoxReg読出し.Size = new System.Drawing.Size(45, 19);
            this.textBoxReg読出し.TabIndex = 209;
            // 
            // numericCommand
            // 
            this.numericCommand.Location = new System.Drawing.Point(28, 19);
            this.numericCommand.Maximum = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.numericCommand.Name = "numericCommand";
            this.numericCommand.Size = new System.Drawing.Size(45, 19);
            this.numericCommand.TabIndex = 210;
            // 
            // buttonRegRead
            // 
            this.buttonRegRead.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonRegRead.Location = new System.Drawing.Point(227, 19);
            this.buttonRegRead.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRegRead.Name = "buttonRegRead";
            this.buttonRegRead.Size = new System.Drawing.Size(38, 21);
            this.buttonRegRead.TabIndex = 213;
            this.buttonRegRead.Text = "get";
            this.buttonRegRead.UseVisualStyleBackColor = true;
            this.buttonRegRead.Click += new System.EventHandler(this.buttonRegRead_Click);
            // 
            // buttonSet製造番号
            // 
            this.buttonSet製造番号.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonSet製造番号.Location = new System.Drawing.Point(197, 251);
            this.buttonSet製造番号.Name = "buttonSet製造番号";
            this.buttonSet製造番号.Size = new System.Drawing.Size(38, 21);
            this.buttonSet製造番号.TabIndex = 255;
            this.buttonSet製造番号.Text = "set";
            this.buttonSet製造番号.UseVisualStyleBackColor = true;
            this.buttonSet製造番号.Click += new System.EventHandler(this.buttonSet製造番号_Click);
            // 
            // buttonGet製造番号
            // 
            this.buttonGet製造番号.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonGet製造番号.Location = new System.Drawing.Point(236, 251);
            this.buttonGet製造番号.Name = "buttonGet製造番号";
            this.buttonGet製造番号.Size = new System.Drawing.Size(38, 21);
            this.buttonGet製造番号.TabIndex = 254;
            this.buttonGet製造番号.Text = "get";
            this.buttonGet製造番号.UseVisualStyleBackColor = true;
            this.buttonGet製造番号.Click += new System.EventHandler(this.buttonGet製造番号_Click);
            // 
            // textBox製造番号
            // 
            this.textBox製造番号.Location = new System.Drawing.Point(147, 252);
            this.textBox製造番号.Name = "textBox製造番号";
            this.textBox製造番号.ReadOnly = true;
            this.textBox製造番号.Size = new System.Drawing.Size(45, 19);
            this.textBox製造番号.TabIndex = 253;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label8.Location = new System.Drawing.Point(7, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 15);
            this.label8.TabIndex = 251;
            this.label8.Text = "製造番号";
            // 
            // numeric20000ppm
            // 
            this.numeric20000ppm.Location = new System.Drawing.Point(91, 230);
            this.numeric20000ppm.Maximum = new decimal(new int[] {
            1742,
            0,
            0,
            0});
            this.numeric20000ppm.Minimum = new decimal(new int[] {
            1087,
            0,
            0,
            0});
            this.numeric20000ppm.Name = "numeric20000ppm";
            this.numeric20000ppm.Size = new System.Drawing.Size(50, 19);
            this.numeric20000ppm.TabIndex = 250;
            this.numeric20000ppm.Value = new decimal(new int[] {
            1087,
            0,
            0,
            0});
            // 
            // numeric0ppm
            // 
            this.numeric0ppm.Location = new System.Drawing.Point(91, 209);
            this.numeric0ppm.Maximum = new decimal(new int[] {
            2701,
            0,
            0,
            0});
            this.numeric0ppm.Name = "numeric0ppm";
            this.numeric0ppm.Size = new System.Drawing.Size(50, 19);
            this.numeric0ppm.TabIndex = 249;
            // 
            // numericオフセット
            // 
            this.numericオフセット.Location = new System.Drawing.Point(91, 188);
            this.numericオフセット.Maximum = new decimal(new int[] {
            15999,
            0,
            0,
            0});
            this.numericオフセット.Name = "numericオフセット";
            this.numericオフセット.Size = new System.Drawing.Size(50, 19);
            this.numericオフセット.TabIndex = 248;
            // 
            // buttonSet20000ppm
            // 
            this.buttonSet20000ppm.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonSet20000ppm.Location = new System.Drawing.Point(197, 229);
            this.buttonSet20000ppm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSet20000ppm.Name = "buttonSet20000ppm";
            this.buttonSet20000ppm.Size = new System.Drawing.Size(38, 21);
            this.buttonSet20000ppm.TabIndex = 247;
            this.buttonSet20000ppm.Text = "set";
            this.buttonSet20000ppm.UseVisualStyleBackColor = true;
            this.buttonSet20000ppm.Click += new System.EventHandler(this.buttonSet20000ppm_Click);
            // 
            // buttonSet0ppm
            // 
            this.buttonSet0ppm.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonSet0ppm.Location = new System.Drawing.Point(197, 208);
            this.buttonSet0ppm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSet0ppm.Name = "buttonSet0ppm";
            this.buttonSet0ppm.Size = new System.Drawing.Size(38, 21);
            this.buttonSet0ppm.TabIndex = 246;
            this.buttonSet0ppm.Text = "set";
            this.buttonSet0ppm.UseVisualStyleBackColor = true;
            this.buttonSet0ppm.Click += new System.EventHandler(this.buttonSet0ppm_Click);
            // 
            // buttonSetオフセット
            // 
            this.buttonSetオフセット.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonSetオフセット.Location = new System.Drawing.Point(197, 187);
            this.buttonSetオフセット.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSetオフセット.Name = "buttonSetオフセット";
            this.buttonSetオフセット.Size = new System.Drawing.Size(38, 21);
            this.buttonSetオフセット.TabIndex = 245;
            this.buttonSetオフセット.Text = "set";
            this.buttonSetオフセット.UseVisualStyleBackColor = true;
            this.buttonSetオフセット.Click += new System.EventHandler(this.buttonSetオフセット_Click);
            // 
            // textBox20000ppm
            // 
            this.textBox20000ppm.Location = new System.Drawing.Point(147, 230);
            this.textBox20000ppm.Name = "textBox20000ppm";
            this.textBox20000ppm.ReadOnly = true;
            this.textBox20000ppm.Size = new System.Drawing.Size(45, 19);
            this.textBox20000ppm.TabIndex = 244;
            // 
            // buttonGet20000ppm
            // 
            this.buttonGet20000ppm.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonGet20000ppm.Location = new System.Drawing.Point(236, 229);
            this.buttonGet20000ppm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGet20000ppm.Name = "buttonGet20000ppm";
            this.buttonGet20000ppm.Size = new System.Drawing.Size(38, 21);
            this.buttonGet20000ppm.TabIndex = 243;
            this.buttonGet20000ppm.Text = "get";
            this.buttonGet20000ppm.UseVisualStyleBackColor = true;
            this.buttonGet20000ppm.Click += new System.EventHandler(this.buttonGet20000ppm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label7.Location = new System.Drawing.Point(7, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 242;
            this.label7.Text = "20000ppm値";
            // 
            // textBox0ppm
            // 
            this.textBox0ppm.Location = new System.Drawing.Point(147, 209);
            this.textBox0ppm.Name = "textBox0ppm";
            this.textBox0ppm.ReadOnly = true;
            this.textBox0ppm.Size = new System.Drawing.Size(45, 19);
            this.textBox0ppm.TabIndex = 241;
            // 
            // buttonGet0ppm
            // 
            this.buttonGet0ppm.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonGet0ppm.Location = new System.Drawing.Point(236, 208);
            this.buttonGet0ppm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGet0ppm.Name = "buttonGet0ppm";
            this.buttonGet0ppm.Size = new System.Drawing.Size(38, 21);
            this.buttonGet0ppm.TabIndex = 240;
            this.buttonGet0ppm.Text = "get";
            this.buttonGet0ppm.UseVisualStyleBackColor = true;
            this.buttonGet0ppm.Click += new System.EventHandler(this.buttonGet0ppm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label6.Location = new System.Drawing.Point(7, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 239;
            this.label6.Text = "0ppm値";
            // 
            // textBoxオフセット
            // 
            this.textBoxオフセット.Location = new System.Drawing.Point(147, 188);
            this.textBoxオフセット.Name = "textBoxオフセット";
            this.textBoxオフセット.ReadOnly = true;
            this.textBoxオフセット.Size = new System.Drawing.Size(45, 19);
            this.textBoxオフセット.TabIndex = 238;
            // 
            // buttonGetオフセット
            // 
            this.buttonGetオフセット.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonGetオフセット.Location = new System.Drawing.Point(236, 187);
            this.buttonGetオフセット.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGetオフセット.Name = "buttonGetオフセット";
            this.buttonGetオフセット.Size = new System.Drawing.Size(38, 21);
            this.buttonGetオフセット.TabIndex = 237;
            this.buttonGetオフセット.Text = "get";
            this.buttonGetオフセット.UseVisualStyleBackColor = true;
            this.buttonGetオフセット.Click += new System.EventHandler(this.buttonGetオフセット_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label5.Location = new System.Drawing.Point(7, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 15);
            this.label5.TabIndex = 236;
            this.label5.Text = "オフセット調整";
            // 
            // textBoxバージョン
            // 
            this.textBoxバージョン.Location = new System.Drawing.Point(147, 167);
            this.textBoxバージョン.Name = "textBoxバージョン";
            this.textBoxバージョン.ReadOnly = true;
            this.textBoxバージョン.Size = new System.Drawing.Size(45, 19);
            this.textBoxバージョン.TabIndex = 235;
            // 
            // buttonGetバージョン
            // 
            this.buttonGetバージョン.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonGetバージョン.Location = new System.Drawing.Point(236, 166);
            this.buttonGetバージョン.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGetバージョン.Name = "buttonGetバージョン";
            this.buttonGetバージョン.Size = new System.Drawing.Size(38, 21);
            this.buttonGetバージョン.TabIndex = 234;
            this.buttonGetバージョン.Text = "get";
            this.buttonGetバージョン.UseVisualStyleBackColor = true;
            this.buttonGetバージョン.Click += new System.EventHandler(this.buttonGetバージョン_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label.Location = new System.Drawing.Point(7, 170);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 15);
            this.label.TabIndex = 233;
            this.label.Text = "ソフトVer";
            // 
            // textBoxエラー情報
            // 
            this.textBoxエラー情報.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxエラー情報.Location = new System.Drawing.Point(114, 143);
            this.textBoxエラー情報.Name = "textBoxエラー情報";
            this.textBoxエラー情報.ReadOnly = true;
            this.textBoxエラー情報.Size = new System.Drawing.Size(160, 19);
            this.textBoxエラー情報.TabIndex = 232;
            // 
            // textBoxステータス情報
            // 
            this.textBoxステータス情報.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxステータス情報.Location = new System.Drawing.Point(114, 120);
            this.textBoxステータス情報.Name = "textBoxステータス情報";
            this.textBoxステータス情報.ReadOnly = true;
            this.textBoxステータス情報.Size = new System.Drawing.Size(160, 19);
            this.textBoxステータス情報.TabIndex = 231;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label4.Location = new System.Drawing.Point(8, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 230;
            this.label4.Text = "エラー情報";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 229;
            this.label3.Text = "ステータス";
            // 
            // textBox温度
            // 
            this.textBox温度.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBox温度.Location = new System.Drawing.Point(223, 72);
            this.textBox温度.Name = "textBox温度";
            this.textBox温度.ReadOnly = true;
            this.textBox温度.Size = new System.Drawing.Size(50, 19);
            this.textBox温度.TabIndex = 228;
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxCounter.Location = new System.Drawing.Point(58, 73);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.ReadOnly = true;
            this.textBoxCounter.Size = new System.Drawing.Size(50, 19);
            this.textBoxCounter.TabIndex = 224;
            // 
            // textBox濃度
            // 
            this.textBox濃度.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBox濃度.Location = new System.Drawing.Point(142, 72);
            this.textBox濃度.Name = "textBox濃度";
            this.textBox濃度.ReadOnly = true;
            this.textBox濃度.Size = new System.Drawing.Size(50, 19);
            this.textBox濃度.TabIndex = 226;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label13.Location = new System.Drawing.Point(8, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 223;
            this.label13.Text = "カウンタ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label1.Location = new System.Drawing.Point(197, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 227;
            this.label1.Text = "温度";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label17.Location = new System.Drawing.Point(116, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 15);
            this.label17.TabIndex = 225;
            this.label17.Text = "濃度";
            // 
            // buttonFlashInit
            // 
            this.buttonFlashInit.BackColor = System.Drawing.Color.Red;
            this.buttonFlashInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlashInit.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Bold);
            this.buttonFlashInit.ForeColor = System.Drawing.Color.White;
            this.buttonFlashInit.Location = new System.Drawing.Point(198, 276);
            this.buttonFlashInit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFlashInit.Name = "buttonFlashInit";
            this.buttonFlashInit.Size = new System.Drawing.Size(76, 22);
            this.buttonFlashInit.TabIndex = 259;
            this.buttonFlashInit.Text = "Flash初期化";
            this.buttonFlashInit.UseVisualStyleBackColor = false;
            this.buttonFlashInit.Click += new System.EventHandler(this.buttonFlashInit_Click);
            // 
            // buttonA1
            // 
            this.buttonA1.BackColor = System.Drawing.Color.Red;
            this.buttonA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA1.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Bold);
            this.buttonA1.ForeColor = System.Drawing.Color.White;
            this.buttonA1.Location = new System.Drawing.Point(9, 276);
            this.buttonA1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(76, 22);
            this.buttonA1.TabIndex = 261;
            this.buttonA1.Text = "0ppm調整";
            this.buttonA1.UseVisualStyleBackColor = false;
            this.buttonA1.Click += new System.EventHandler(this.buttonA1_Click);
            // 
            // buttonA3
            // 
            this.buttonA3.BackColor = System.Drawing.Color.Red;
            this.buttonA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA3.Font = new System.Drawing.Font("メイリオ", 7F, System.Drawing.FontStyle.Bold);
            this.buttonA3.ForeColor = System.Drawing.Color.White;
            this.buttonA3.Location = new System.Drawing.Point(92, 276);
            this.buttonA3.Margin = new System.Windows.Forms.Padding(0);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(100, 22);
            this.buttonA3.TabIndex = 262;
            this.buttonA3.Text = "20000ppm調整";
            this.buttonA3.UseVisualStyleBackColor = false;
            this.buttonA3.Click += new System.EventHandler(this.buttonA3_Click);
            // 
            // textBox製造番号W
            // 
            this.textBox製造番号W.Location = new System.Drawing.Point(91, 252);
            this.textBox製造番号W.MaxLength = 6;
            this.textBox製造番号W.Name = "textBox製造番号W";
            this.textBox製造番号W.Size = new System.Drawing.Size(50, 19);
            this.textBox製造番号W.TabIndex = 252;
            // 
            // buttonRegWrite
            // 
            this.buttonRegWrite.Font = new System.Drawing.Font("メイリオ", 7F);
            this.buttonRegWrite.Location = new System.Drawing.Point(188, 19);
            this.buttonRegWrite.Name = "buttonRegWrite";
            this.buttonRegWrite.Size = new System.Drawing.Size(38, 21);
            this.buttonRegWrite.TabIndex = 256;
            this.buttonRegWrite.Text = "set";
            this.buttonRegWrite.UseVisualStyleBackColor = true;
            this.buttonRegWrite.Click += new System.EventHandler(this.buttonRegWrite_Click);
            // 
            // textBoxReg書込み
            // 
            this.textBoxReg書込み.Location = new System.Drawing.Point(82, 19);
            this.textBoxReg書込み.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.textBoxReg書込み.Name = "textBoxReg書込み";
            this.textBoxReg書込み.Size = new System.Drawing.Size(50, 19);
            this.textBoxReg書込み.TabIndex = 257;
            // 
            // textBoxGas
            // 
            this.textBoxGas.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxGas.Location = new System.Drawing.Point(72, 96);
            this.textBoxGas.Name = "textBoxGas";
            this.textBoxGas.ReadOnly = true;
            this.textBoxGas.Size = new System.Drawing.Size(55, 19);
            this.textBoxGas.TabIndex = 264;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 263;
            this.label2.Text = "GAS conc.";
            // 
            // textBoxGasRaw
            // 
            this.textBoxGasRaw.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxGasRaw.Location = new System.Drawing.Point(129, 96);
            this.textBoxGasRaw.Name = "textBoxGasRaw";
            this.textBoxGasRaw.ReadOnly = true;
            this.textBoxGasRaw.Size = new System.Drawing.Size(55, 19);
            this.textBoxGasRaw.TabIndex = 265;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label10.Location = new System.Drawing.Point(191, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 266;
            this.label10.Text = "CRC";
            // 
            // textBoxCRC
            // 
            this.textBoxCRC.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxCRC.Location = new System.Drawing.Point(223, 96);
            this.textBoxCRC.Name = "textBoxCRC";
            this.textBoxCRC.ReadOnly = true;
            this.textBoxCRC.Size = new System.Drawing.Size(50, 19);
            this.textBoxCRC.TabIndex = 267;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtIDB);
            this.panel2.Controls.Add(this.txtIDA);
            this.panel2.Controls.Add(this.buttonID);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(108, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 30);
            this.panel2.TabIndex = 271;
            // 
            // txtIDB
            // 
            this.txtIDB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDB.Location = new System.Drawing.Point(66, 5);
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
            this.txtIDA.Location = new System.Drawing.Point(13, 5);
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
            this.buttonID.Location = new System.Drawing.Point(110, 4);
            this.buttonID.Margin = new System.Windows.Forms.Padding(0);
            this.buttonID.Name = "buttonID";
            this.buttonID.Size = new System.Drawing.Size(50, 21);
            this.buttonID.TabIndex = 271;
            this.buttonID.Text = "ID変更";
            this.buttonID.UseVisualStyleBackColor = true;
            this.buttonID.Click += new System.EventHandler(this.buttonID_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtID);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(4, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 30);
            this.panel3.TabIndex = 272;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label11.Location = new System.Drawing.Point(1, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 274;
            this.label11.Text = "A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label12.Location = new System.Drawing.Point(54, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 15);
            this.label12.TabIndex = 275;
            this.label12.Text = "B";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("メイリオ", 6F);
            this.label15.Location = new System.Drawing.Point(7, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 12);
            this.label15.TabIndex = 273;
            this.label15.Text = "変換値/RAW";
            // 
            // UserControlUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBoxCRC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxGasRaw);
            this.Controls.Add(this.textBoxGas);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.buttonA1);
            this.Controls.Add(this.buttonFlashInit);
            this.Controls.Add(this.textBoxエラーフラグ);
            this.Controls.Add(this.textBoxステータスフラグ);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonSet製造番号);
            this.Controls.Add(this.buttonGet製造番号);
            this.Controls.Add(this.textBox製造番号);
            this.Controls.Add(this.textBox製造番号W);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numeric20000ppm);
            this.Controls.Add(this.numeric0ppm);
            this.Controls.Add(this.numericオフセット);
            this.Controls.Add(this.buttonSet20000ppm);
            this.Controls.Add(this.buttonSet0ppm);
            this.Controls.Add(this.buttonSetオフセット);
            this.Controls.Add(this.textBox20000ppm);
            this.Controls.Add(this.buttonGet20000ppm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox0ppm);
            this.Controls.Add(this.buttonGet0ppm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxオフセット);
            this.Controls.Add(this.buttonGetオフセット);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxバージョン);
            this.Controls.Add(this.buttonGetバージョン);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxエラー情報);
            this.Controls.Add(this.textBoxステータス情報);
            this.Controls.Add(this.label4);
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
            this.Name = "UserControlUnit";
            this.Size = new System.Drawing.Size(280, 355);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCommand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric20000ppm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric0ppm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericオフセット)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxReg書込み)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.CheckBox checkValid;
        private System.Windows.Forms.ComboBox hardware;
        private System.Windows.Forms.TextBox textBoxエラーフラグ;
        private System.Windows.Forms.TextBox textBoxステータスフラグ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxReg読出し;
        private System.Windows.Forms.NumericUpDown numericCommand;
        private System.Windows.Forms.Button buttonRegRead;
        private System.Windows.Forms.Button buttonSet製造番号;
        private System.Windows.Forms.Button buttonGet製造番号;
        private System.Windows.Forms.TextBox textBox製造番号;
        private TextBoxNumberEx textBox製造番号W;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numeric20000ppm;
        private System.Windows.Forms.NumericUpDown numeric0ppm;
        private System.Windows.Forms.NumericUpDown numericオフセット;
        private System.Windows.Forms.Button buttonSet20000ppm;
        private System.Windows.Forms.Button buttonSet0ppm;
        private System.Windows.Forms.Button buttonSetオフセット;
        private System.Windows.Forms.TextBox textBox20000ppm;
        private System.Windows.Forms.Button buttonGet20000ppm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox0ppm;
        private System.Windows.Forms.Button buttonGet0ppm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxオフセット;
        private System.Windows.Forms.Button buttonGetオフセット;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxバージョン;
        private System.Windows.Forms.Button buttonGetバージョン;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxエラー情報;
        private System.Windows.Forms.TextBox textBoxステータス情報;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox温度;
        private System.Windows.Forms.TextBox textBoxCounter;
        private System.Windows.Forms.TextBox textBox濃度;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonFlashInit;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.Button buttonA3;
        private System.Windows.Forms.NumericUpDown textBoxReg書込み;
        private System.Windows.Forms.Button buttonRegWrite;
        private System.Windows.Forms.TextBox textBoxGas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGasRaw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCRC;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtIDB;
        public System.Windows.Forms.TextBox txtIDA;
        private System.Windows.Forms.Button buttonID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
    }
}
