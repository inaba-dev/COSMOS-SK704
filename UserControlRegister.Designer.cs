namespace APP
{
    partial class UserControlRegister
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
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.directoryEntry2 = new System.DirectoryServices.DirectoryEntry();
            this.textBox製造番号W = new APP.TextBoxNumberEx();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.buttonFlashInit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric20000ppm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric0ppm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericオフセット)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSet製造番号
            // 
            this.buttonSet製造番号.Font = new System.Drawing.Font("メイリオ", 9F);
            this.buttonSet製造番号.Location = new System.Drawing.Point(243, 266);
            this.buttonSet製造番号.Name = "buttonSet製造番号";
            this.buttonSet製造番号.Size = new System.Drawing.Size(45, 24);
            this.buttonSet製造番号.TabIndex = 255;
            this.buttonSet製造番号.Text = "書込";
            this.buttonSet製造番号.UseVisualStyleBackColor = true;
            this.buttonSet製造番号.Click += new System.EventHandler(this.buttonSet製造番号_Click);
            // 
            // buttonGet製造番号
            // 
            this.buttonGet製造番号.Font = new System.Drawing.Font("メイリオ", 9F);
            this.buttonGet製造番号.Location = new System.Drawing.Point(296, 266);
            this.buttonGet製造番号.Name = "buttonGet製造番号";
            this.buttonGet製造番号.Size = new System.Drawing.Size(45, 24);
            this.buttonGet製造番号.TabIndex = 254;
            this.buttonGet製造番号.Text = "読出";
            this.buttonGet製造番号.UseVisualStyleBackColor = true;
            this.buttonGet製造番号.Click += new System.EventHandler(this.buttonGet製造番号_Click);
            // 
            // textBox製造番号
            // 
            this.textBox製造番号.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBox製造番号.Location = new System.Drawing.Point(178, 267);
            this.textBox製造番号.Name = "textBox製造番号";
            this.textBox製造番号.ReadOnly = true;
            this.textBox製造番号.Size = new System.Drawing.Size(55, 21);
            this.textBox製造番号.TabIndex = 253;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label8.Location = new System.Drawing.Point(12, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 24);
            this.label8.TabIndex = 251;
            this.label8.Text = "製造番号";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numeric20000ppm
            // 
            this.numeric20000ppm.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.numeric20000ppm.Location = new System.Drawing.Point(109, 237);
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
            this.numeric20000ppm.Size = new System.Drawing.Size(60, 21);
            this.numeric20000ppm.TabIndex = 250;
            this.numeric20000ppm.Value = new decimal(new int[] {
            1087,
            0,
            0,
            0});
            // 
            // numeric0ppm
            // 
            this.numeric0ppm.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.numeric0ppm.Location = new System.Drawing.Point(109, 207);
            this.numeric0ppm.Maximum = new decimal(new int[] {
            2701,
            0,
            0,
            0});
            this.numeric0ppm.Name = "numeric0ppm";
            this.numeric0ppm.Size = new System.Drawing.Size(60, 21);
            this.numeric0ppm.TabIndex = 249;
            // 
            // numericオフセット
            // 
            this.numericオフセット.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.numericオフセット.Location = new System.Drawing.Point(109, 177);
            this.numericオフセット.Maximum = new decimal(new int[] {
            15999,
            0,
            0,
            0});
            this.numericオフセット.Name = "numericオフセット";
            this.numericオフセット.Size = new System.Drawing.Size(60, 21);
            this.numericオフセット.TabIndex = 248;
            // 
            // buttonSet20000ppm
            // 
            this.buttonSet20000ppm.Font = new System.Drawing.Font("メイリオ", 9F);
            this.buttonSet20000ppm.Location = new System.Drawing.Point(243, 236);
            this.buttonSet20000ppm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSet20000ppm.Name = "buttonSet20000ppm";
            this.buttonSet20000ppm.Size = new System.Drawing.Size(45, 24);
            this.buttonSet20000ppm.TabIndex = 247;
            this.buttonSet20000ppm.Text = "書込";
            this.buttonSet20000ppm.UseVisualStyleBackColor = true;
            this.buttonSet20000ppm.Click += new System.EventHandler(this.buttonSet20000ppm_Click);
            // 
            // buttonSet0ppm
            // 
            this.buttonSet0ppm.Font = new System.Drawing.Font("メイリオ", 9F);
            this.buttonSet0ppm.Location = new System.Drawing.Point(243, 206);
            this.buttonSet0ppm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSet0ppm.Name = "buttonSet0ppm";
            this.buttonSet0ppm.Size = new System.Drawing.Size(45, 24);
            this.buttonSet0ppm.TabIndex = 246;
            this.buttonSet0ppm.Text = "書込";
            this.buttonSet0ppm.UseVisualStyleBackColor = true;
            this.buttonSet0ppm.Click += new System.EventHandler(this.buttonSet0ppm_Click);
            // 
            // buttonSetオフセット
            // 
            this.buttonSetオフセット.Font = new System.Drawing.Font("メイリオ", 9F);
            this.buttonSetオフセット.Location = new System.Drawing.Point(243, 176);
            this.buttonSetオフセット.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSetオフセット.Name = "buttonSetオフセット";
            this.buttonSetオフセット.Size = new System.Drawing.Size(45, 24);
            this.buttonSetオフセット.TabIndex = 245;
            this.buttonSetオフセット.Text = "書込";
            this.buttonSetオフセット.UseVisualStyleBackColor = true;
            this.buttonSetオフセット.Click += new System.EventHandler(this.buttonSetオフセット_Click);
            // 
            // textBox20000ppm
            // 
            this.textBox20000ppm.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBox20000ppm.Location = new System.Drawing.Point(178, 237);
            this.textBox20000ppm.Name = "textBox20000ppm";
            this.textBox20000ppm.ReadOnly = true;
            this.textBox20000ppm.Size = new System.Drawing.Size(55, 21);
            this.textBox20000ppm.TabIndex = 244;
            // 
            // buttonGet20000ppm
            // 
            this.buttonGet20000ppm.Font = new System.Drawing.Font("メイリオ", 9F);
            this.buttonGet20000ppm.Location = new System.Drawing.Point(296, 236);
            this.buttonGet20000ppm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGet20000ppm.Name = "buttonGet20000ppm";
            this.buttonGet20000ppm.Size = new System.Drawing.Size(45, 24);
            this.buttonGet20000ppm.TabIndex = 243;
            this.buttonGet20000ppm.Text = "読出";
            this.buttonGet20000ppm.UseVisualStyleBackColor = true;
            this.buttonGet20000ppm.Click += new System.EventHandler(this.buttonGet20000ppm_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 242;
            this.label7.Text = "20000ppm値";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox0ppm
            // 
            this.textBox0ppm.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBox0ppm.Location = new System.Drawing.Point(178, 207);
            this.textBox0ppm.Name = "textBox0ppm";
            this.textBox0ppm.ReadOnly = true;
            this.textBox0ppm.Size = new System.Drawing.Size(55, 21);
            this.textBox0ppm.TabIndex = 241;
            // 
            // buttonGet0ppm
            // 
            this.buttonGet0ppm.Font = new System.Drawing.Font("メイリオ", 9F);
            this.buttonGet0ppm.Location = new System.Drawing.Point(296, 206);
            this.buttonGet0ppm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGet0ppm.Name = "buttonGet0ppm";
            this.buttonGet0ppm.Size = new System.Drawing.Size(45, 24);
            this.buttonGet0ppm.TabIndex = 240;
            this.buttonGet0ppm.Text = "読出";
            this.buttonGet0ppm.UseVisualStyleBackColor = true;
            this.buttonGet0ppm.Click += new System.EventHandler(this.buttonGet0ppm_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 24);
            this.label6.TabIndex = 239;
            this.label6.Text = "0ppm値";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxオフセット
            // 
            this.textBoxオフセット.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBoxオフセット.Location = new System.Drawing.Point(178, 177);
            this.textBoxオフセット.Name = "textBoxオフセット";
            this.textBoxオフセット.ReadOnly = true;
            this.textBoxオフセット.Size = new System.Drawing.Size(55, 21);
            this.textBoxオフセット.TabIndex = 238;
            // 
            // buttonGetオフセット
            // 
            this.buttonGetオフセット.Font = new System.Drawing.Font("メイリオ", 9F);
            this.buttonGetオフセット.Location = new System.Drawing.Point(296, 176);
            this.buttonGetオフセット.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGetオフセット.Name = "buttonGetオフセット";
            this.buttonGetオフセット.Size = new System.Drawing.Size(45, 24);
            this.buttonGetオフセット.TabIndex = 237;
            this.buttonGetオフセット.Text = "読出";
            this.buttonGetオフセット.UseVisualStyleBackColor = true;
            this.buttonGetオフセット.Click += new System.EventHandler(this.buttonGetオフセット_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 236;
            this.label5.Text = "オフセット調整";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxバージョン
            // 
            this.textBoxバージョン.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBoxバージョン.Location = new System.Drawing.Point(178, 147);
            this.textBoxバージョン.Name = "textBoxバージョン";
            this.textBoxバージョン.ReadOnly = true;
            this.textBoxバージョン.Size = new System.Drawing.Size(55, 21);
            this.textBoxバージョン.TabIndex = 235;
            // 
            // buttonGetバージョン
            // 
            this.buttonGetバージョン.Font = new System.Drawing.Font("メイリオ", 9F);
            this.buttonGetバージョン.Location = new System.Drawing.Point(296, 146);
            this.buttonGetバージョン.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGetバージョン.Name = "buttonGetバージョン";
            this.buttonGetバージョン.Size = new System.Drawing.Size(45, 24);
            this.buttonGetバージョン.TabIndex = 234;
            this.buttonGetバージョン.Text = "読出";
            this.buttonGetバージョン.UseVisualStyleBackColor = true;
            this.buttonGetバージョン.Click += new System.EventHandler(this.buttonGetバージョン_Click);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label.Location = new System.Drawing.Point(12, 150);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 24);
            this.label.TabIndex = 233;
            this.label.Text = "ソフトVer";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox製造番号W
            // 
            this.textBox製造番号W.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.textBox製造番号W.Location = new System.Drawing.Point(109, 267);
            this.textBox製造番号W.MaxLength = 6;
            this.textBox製造番号W.Name = "textBox製造番号W";
            this.textBox製造番号W.Size = new System.Drawing.Size(60, 21);
            this.textBox製造番号W.TabIndex = 252;
            // 
            // buttonA3
            // 
            this.buttonA3.BackColor = System.Drawing.Color.Red;
            this.buttonA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold);
            this.buttonA3.ForeColor = System.Drawing.Color.White;
            this.buttonA3.Location = new System.Drawing.Point(122, 64);
            this.buttonA3.Margin = new System.Windows.Forms.Padding(0);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(115, 36);
            this.buttonA3.TabIndex = 275;
            this.buttonA3.Text = "20000ppm調整";
            this.buttonA3.UseVisualStyleBackColor = false;
            this.buttonA3.Click += new System.EventHandler(this.buttonA3_Click);
            // 
            // buttonA1
            // 
            this.buttonA1.BackColor = System.Drawing.Color.Red;
            this.buttonA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonA1.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold);
            this.buttonA1.ForeColor = System.Drawing.Color.White;
            this.buttonA1.Location = new System.Drawing.Point(21, 64);
            this.buttonA1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(91, 36);
            this.buttonA1.TabIndex = 274;
            this.buttonA1.Text = "0ppm調整";
            this.buttonA1.UseVisualStyleBackColor = false;
            this.buttonA1.Click += new System.EventHandler(this.buttonA1_Click);
            // 
            // buttonFlashInit
            // 
            this.buttonFlashInit.BackColor = System.Drawing.Color.Red;
            this.buttonFlashInit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFlashInit.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold);
            this.buttonFlashInit.ForeColor = System.Drawing.Color.White;
            this.buttonFlashInit.Location = new System.Drawing.Point(248, 64);
            this.buttonFlashInit.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFlashInit.Name = "buttonFlashInit";
            this.buttonFlashInit.Size = new System.Drawing.Size(91, 36);
            this.buttonFlashInit.TabIndex = 273;
            this.buttonFlashInit.Text = "Flash初期化";
            this.buttonFlashInit.UseVisualStyleBackColor = false;
            this.buttonFlashInit.Click += new System.EventHandler(this.buttonFlashInit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label1.Location = new System.Drawing.Point(112, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 276;
            this.label1.Text = "書込み値";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 8F);
            this.label2.Location = new System.Drawing.Point(179, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 277;
            this.label2.Text = "読出し値";
            // 
            // UserControlRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.buttonA1);
            this.Controls.Add(this.buttonFlashInit);
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
            this.Name = "UserControlRegister";
            this.Size = new System.Drawing.Size(358, 340);
            ((System.ComponentModel.ISupportInitialize)(this.numeric20000ppm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric0ppm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericオフセット)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.DirectoryServices.DirectoryEntry directoryEntry2;
        private System.Windows.Forms.Button buttonA3;
        private System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.Button buttonFlashInit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
