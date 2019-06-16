namespace AES
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GenerateKeyBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CopyKeyBtn = new System.Windows.Forms.Button();
            this.aes256btn = new System.Windows.Forms.RadioButton();
            this.aes192btn = new System.Windows.Forms.RadioButton();
            this.aes128btn = new System.Windows.Forms.RadioButton();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ecbDecrypt = new System.Windows.Forms.Button();
            this.ecbEncrypt = new System.Windows.Forms.Button();
            this.ecbCiphertext = new System.Windows.Forms.TextBox();
            this.ecbPlaintext = new System.Windows.Forms.TextBox();
            this.ecbKeyTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateKeyBtn
            // 
            this.GenerateKeyBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GenerateKeyBtn.Location = new System.Drawing.Point(244, 138);
            this.GenerateKeyBtn.Name = "GenerateKeyBtn";
            this.GenerateKeyBtn.Size = new System.Drawing.Size(75, 33);
            this.GenerateKeyBtn.TabIndex = 0;
            this.GenerateKeyBtn.Text = "生成Key";
            this.GenerateKeyBtn.UseVisualStyleBackColor = true;
            this.GenerateKeyBtn.Click += new System.EventHandler(this.GenerateKeyBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CopyKeyBtn);
            this.groupBox1.Controls.Add(this.aes256btn);
            this.groupBox1.Controls.Add(this.aes192btn);
            this.groupBox1.Controls.Add(this.aes128btn);
            this.groupBox1.Controls.Add(this.keyTextBox);
            this.groupBox1.Controls.Add(this.GenerateKeyBtn);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AES-Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(134, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Key：";
            // 
            // CopyKeyBtn
            // 
            this.CopyKeyBtn.Enabled = false;
            this.CopyKeyBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CopyKeyBtn.Location = new System.Drawing.Point(434, 138);
            this.CopyKeyBtn.Name = "CopyKeyBtn";
            this.CopyKeyBtn.Size = new System.Drawing.Size(75, 33);
            this.CopyKeyBtn.TabIndex = 5;
            this.CopyKeyBtn.Text = "复制Key";
            this.CopyKeyBtn.UseVisualStyleBackColor = true;
            this.CopyKeyBtn.Click += new System.EventHandler(this.CopyKeyBtn_Click);
            // 
            // aes256btn
            // 
            this.aes256btn.AutoSize = true;
            this.aes256btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aes256btn.Location = new System.Drawing.Point(524, 39);
            this.aes256btn.Name = "aes256btn";
            this.aes256btn.Size = new System.Drawing.Size(91, 24);
            this.aes256btn.TabIndex = 4;
            this.aes256btn.Text = "AES-256";
            this.aes256btn.UseVisualStyleBackColor = true;
            // 
            // aes192btn
            // 
            this.aes192btn.AutoSize = true;
            this.aes192btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aes192btn.Location = new System.Drawing.Point(346, 39);
            this.aes192btn.Name = "aes192btn";
            this.aes192btn.Size = new System.Drawing.Size(91, 24);
            this.aes192btn.TabIndex = 3;
            this.aes192btn.Text = "AES-192";
            this.aes192btn.UseVisualStyleBackColor = true;
            // 
            // aes128btn
            // 
            this.aes128btn.AutoSize = true;
            this.aes128btn.Checked = true;
            this.aes128btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.aes128btn.Location = new System.Drawing.Point(160, 39);
            this.aes128btn.Name = "aes128btn";
            this.aes128btn.Size = new System.Drawing.Size(91, 24);
            this.aes128btn.TabIndex = 2;
            this.aes128btn.TabStop = true;
            this.aes128btn.Text = "AES-128";
            this.aes128btn.UseVisualStyleBackColor = true;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.keyTextBox.Location = new System.Drawing.Point(191, 86);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ReadOnly = true;
            this.keyTextBox.Size = new System.Drawing.Size(461, 27);
            this.keyTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ecbDecrypt);
            this.groupBox2.Controls.Add(this.ecbEncrypt);
            this.groupBox2.Controls.Add(this.ecbCiphertext);
            this.groupBox2.Controls.Add(this.ecbPlaintext);
            this.groupBox2.Controls.Add(this.ecbKeyTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(12, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 225);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AES-ECB";
            // 
            // ecbDecrypt
            // 
            this.ecbDecrypt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ecbDecrypt.Location = new System.Drawing.Point(434, 174);
            this.ecbDecrypt.Name = "ecbDecrypt";
            this.ecbDecrypt.Size = new System.Drawing.Size(75, 33);
            this.ecbDecrypt.TabIndex = 14;
            this.ecbDecrypt.Text = "解密";
            this.ecbDecrypt.UseVisualStyleBackColor = true;
            this.ecbDecrypt.Click += new System.EventHandler(this.EcbDecrypt_Click);
            // 
            // ecbEncrypt
            // 
            this.ecbEncrypt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ecbEncrypt.Location = new System.Drawing.Point(244, 174);
            this.ecbEncrypt.Name = "ecbEncrypt";
            this.ecbEncrypt.Size = new System.Drawing.Size(75, 33);
            this.ecbEncrypt.TabIndex = 13;
            this.ecbEncrypt.Text = "加密";
            this.ecbEncrypt.UseVisualStyleBackColor = true;
            this.ecbEncrypt.Click += new System.EventHandler(this.EcbEncrypt_Click);
            // 
            // ecbCiphertext
            // 
            this.ecbCiphertext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ecbCiphertext.Location = new System.Drawing.Point(191, 128);
            this.ecbCiphertext.Name = "ecbCiphertext";
            this.ecbCiphertext.Size = new System.Drawing.Size(461, 27);
            this.ecbCiphertext.TabIndex = 12;
            // 
            // ecbPlaintext
            // 
            this.ecbPlaintext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ecbPlaintext.Location = new System.Drawing.Point(191, 83);
            this.ecbPlaintext.Name = "ecbPlaintext";
            this.ecbPlaintext.Size = new System.Drawing.Size(461, 27);
            this.ecbPlaintext.TabIndex = 11;
            // 
            // ecbKeyTextBox
            // 
            this.ecbKeyTextBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ecbKeyTextBox.Location = new System.Drawing.Point(191, 36);
            this.ecbKeyTextBox.Name = "ecbKeyTextBox";
            this.ecbKeyTextBox.Size = new System.Drawing.Size(461, 27);
            this.ecbKeyTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(80, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ciphertext ：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(98, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Plaintext：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(134, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Key：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GenerateKeyBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton aes256btn;
        private System.Windows.Forms.RadioButton aes192btn;
        private System.Windows.Forms.RadioButton aes128btn;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button CopyKeyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ecbCiphertext;
        private System.Windows.Forms.TextBox ecbPlaintext;
        private System.Windows.Forms.TextBox ecbKeyTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ecbDecrypt;
        private System.Windows.Forms.Button ecbEncrypt;
    }
}

