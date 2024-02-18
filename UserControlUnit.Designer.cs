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
            this.textBox温度 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.textBoxセンサ値 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox温度RAW = new System.Windows.Forms.TextBox();
            this.textBoxセンサRAW = new System.Windows.Forms.TextBox();
            this.checkValid = new System.Windows.Forms.CheckBox();
            this.hardware = new System.Windows.Forms.ComboBox();
            this.radioLeakage = new System.Windows.Forms.RadioButton();
            this.radioExhaust = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxバージョン情報 = new System.Windows.Forms.TextBox();
            this.textBoxエラー情報 = new System.Windows.Forms.TextBox();
            this.textBox湿度RAW = new System.Windows.Forms.TextBox();
            this.textBox湿度 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox温度
            // 
            this.textBox温度.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBox温度.Location = new System.Drawing.Point(83, 137);
            this.textBox温度.Name = "textBox温度";
            this.textBox温度.ReadOnly = true;
            this.textBox温度.Size = new System.Drawing.Size(55, 19);
            this.textBox温度.TabIndex = 174;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label1.Location = new System.Drawing.Point(5, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 173;
            this.label1.Text = "温度(℃/RAW)";
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxCounter.Location = new System.Drawing.Point(83, 86);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.ReadOnly = true;
            this.textBoxCounter.Size = new System.Drawing.Size(55, 19);
            this.textBoxCounter.TabIndex = 170;
            // 
            // textBoxセンサ値
            // 
            this.textBoxセンサ値.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxセンサ値.Location = new System.Drawing.Point(83, 112);
            this.textBoxセンサ値.Name = "textBoxセンサ値";
            this.textBoxセンサ値.ReadOnly = true;
            this.textBoxセンサ値.Size = new System.Drawing.Size(55, 19);
            this.textBoxセンサ値.TabIndex = 172;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label13.Location = new System.Drawing.Point(14, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 15);
            this.label13.TabIndex = 169;
            this.label13.Text = "カウンタ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label17.Location = new System.Drawing.Point(2, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 15);
            this.label17.TabIndex = 171;
            this.label17.Text = "センサ(%/RAW)";
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(83, 62);
            this.txtID.MaxLength = 3;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(55, 19);
            this.txtID.TabIndex = 176;
            this.txtID.Text = "0";
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label14.Location = new System.Drawing.Point(16, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 19);
            this.label14.TabIndex = 175;
            this.label14.Text = "CAN-ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label2.Location = new System.Drawing.Point(137, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 177;
            this.label2.Text = " (Hex)";
            // 
            // textBox温度RAW
            // 
            this.textBox温度RAW.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBox温度RAW.Location = new System.Drawing.Point(142, 137);
            this.textBox温度RAW.Name = "textBox温度RAW";
            this.textBox温度RAW.ReadOnly = true;
            this.textBox温度RAW.Size = new System.Drawing.Size(55, 19);
            this.textBox温度RAW.TabIndex = 179;
            // 
            // textBoxセンサRAW
            // 
            this.textBoxセンサRAW.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxセンサRAW.Location = new System.Drawing.Point(142, 112);
            this.textBoxセンサRAW.Name = "textBoxセンサRAW";
            this.textBoxセンサRAW.ReadOnly = true;
            this.textBoxセンサRAW.Size = new System.Drawing.Size(55, 19);
            this.textBoxセンサRAW.TabIndex = 181;
            // 
            // checkValid
            // 
            this.checkValid.AutoSize = true;
            this.checkValid.Font = new System.Drawing.Font("メイリオ", 7F);
            this.checkValid.Location = new System.Drawing.Point(137, 12);
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
            this.hardware.Location = new System.Drawing.Point(8, 9);
            this.hardware.Name = "hardware";
            this.hardware.Size = new System.Drawing.Size(120, 21);
            this.hardware.TabIndex = 183;
            // 
            // radioLeakage
            // 
            this.radioLeakage.AutoSize = true;
            this.radioLeakage.Checked = true;
            this.radioLeakage.Font = new System.Drawing.Font("メイリオ", 7F);
            this.radioLeakage.Location = new System.Drawing.Point(30, 37);
            this.radioLeakage.Name = "radioLeakage";
            this.radioLeakage.Size = new System.Drawing.Size(67, 19);
            this.radioLeakage.TabIndex = 185;
            this.radioLeakage.TabStop = true;
            this.radioLeakage.Text = "Leakage";
            this.radioLeakage.UseVisualStyleBackColor = true;
            // 
            // radioExhaust
            // 
            this.radioExhaust.AutoSize = true;
            this.radioExhaust.Font = new System.Drawing.Font("メイリオ", 7F);
            this.radioExhaust.Location = new System.Drawing.Point(105, 37);
            this.radioExhaust.Name = "radioExhaust";
            this.radioExhaust.Size = new System.Drawing.Size(64, 19);
            this.radioExhaust.TabIndex = 184;
            this.radioExhaust.TabStop = true;
            this.radioExhaust.Text = "Exhaust";
            this.radioExhaust.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label3.Location = new System.Drawing.Point(3, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 186;
            this.label3.Text = "バージョン情報";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label4.Location = new System.Drawing.Point(8, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 187;
            this.label4.Text = "エラー情報";
            // 
            // textBoxバージョン情報
            // 
            this.textBoxバージョン情報.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxバージョン情報.Location = new System.Drawing.Point(83, 188);
            this.textBoxバージョン情報.Name = "textBoxバージョン情報";
            this.textBoxバージョン情報.ReadOnly = true;
            this.textBoxバージョン情報.Size = new System.Drawing.Size(114, 19);
            this.textBoxバージョン情報.TabIndex = 188;
            // 
            // textBoxエラー情報
            // 
            this.textBoxエラー情報.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBoxエラー情報.Location = new System.Drawing.Point(83, 213);
            this.textBoxエラー情報.Name = "textBoxエラー情報";
            this.textBoxエラー情報.ReadOnly = true;
            this.textBoxエラー情報.Size = new System.Drawing.Size(114, 19);
            this.textBoxエラー情報.TabIndex = 189;
            // 
            // textBox湿度RAW
            // 
            this.textBox湿度RAW.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBox湿度RAW.Location = new System.Drawing.Point(142, 161);
            this.textBox湿度RAW.Name = "textBox湿度RAW";
            this.textBox湿度RAW.ReadOnly = true;
            this.textBox湿度RAW.Size = new System.Drawing.Size(55, 19);
            this.textBox湿度RAW.TabIndex = 192;
            // 
            // textBox湿度
            // 
            this.textBox湿度.Font = new System.Drawing.Font("MS UI Gothic", 9F);
            this.textBox湿度.Location = new System.Drawing.Point(83, 161);
            this.textBox湿度.Name = "textBox湿度";
            this.textBox湿度.ReadOnly = true;
            this.textBox湿度.Size = new System.Drawing.Size(55, 19);
            this.textBox湿度.TabIndex = 191;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label5.Location = new System.Drawing.Point(7, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 190;
            this.label5.Text = "RH(%/RAW)";
            // 
            // UserControlStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox湿度RAW);
            this.Controls.Add(this.textBox湿度);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxエラー情報);
            this.Controls.Add(this.textBoxバージョン情報);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioLeakage);
            this.Controls.Add(this.radioExhaust);
            this.Controls.Add(this.hardware);
            this.Controls.Add(this.checkValid);
            this.Controls.Add(this.textBoxセンサRAW);
            this.Controls.Add(this.textBox温度RAW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox温度);
            this.Controls.Add(this.textBoxCounter);
            this.Controls.Add(this.textBoxセンサ値);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label2);
            this.Name = "UserControlStatus";
            this.Size = new System.Drawing.Size(200, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox温度;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCounter;
        private System.Windows.Forms.TextBox textBoxセンサ値;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox textBox温度RAW;
        private System.Windows.Forms.TextBox textBoxセンサRAW;
        public System.Windows.Forms.CheckBox checkValid;
        private System.Windows.Forms.ComboBox hardware;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxバージョン情報;
        private System.Windows.Forms.TextBox textBoxエラー情報;
        private System.Windows.Forms.TextBox textBox湿度RAW;
        private System.Windows.Forms.TextBox textBox湿度;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.RadioButton radioLeakage;
        public System.Windows.Forms.RadioButton radioExhaust;
    }
}
