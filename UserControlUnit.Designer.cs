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
            this.label2 = new System.Windows.Forms.Label();
            this.checkValid = new System.Windows.Forms.CheckBox();
            this.hardware = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtID.Location = new System.Drawing.Point(51, 32);
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
            this.label14.Location = new System.Drawing.Point(5, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 19);
            this.label14.TabIndex = 175;
            this.label14.Text = "CAN-ID";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("メイリオ", 7F);
            this.label2.Location = new System.Drawing.Point(105, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 177;
            this.label2.Text = " (Hex)";
            // 
            // checkValid
            // 
            this.checkValid.AutoSize = true;
            this.checkValid.Font = new System.Drawing.Font("メイリオ", 7F);
            this.checkValid.Location = new System.Drawing.Point(186, 7);
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
            this.hardware.Location = new System.Drawing.Point(51, 5);
            this.hardware.Name = "hardware";
            this.hardware.Size = new System.Drawing.Size(120, 21);
            this.hardware.TabIndex = 183;
            // 
            // UserControlUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hardware);
            this.Controls.Add(this.checkValid);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Name = "UserControlUnit";
            this.Size = new System.Drawing.Size(280, 265);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.CheckBox checkValid;
        private System.Windows.Forms.ComboBox hardware;
    }
}
