﻿namespace DiplCaptcha
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnRastgeleCaptchaÜretme = new System.Windows.Forms.Button();
            this.btnSayısalLotoyaGeçiş = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            // 
            // btnRastgeleCaptchaÜretme
            // 
            this.btnRastgeleCaptchaÜretme.Location = new System.Drawing.Point(37, 119);
            this.btnRastgeleCaptchaÜretme.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnRastgeleCaptchaÜretme.Name = "btnRastgeleCaptchaÜretme";
            this.btnRastgeleCaptchaÜretme.Size = new System.Drawing.Size(175, 78);
            this.btnRastgeleCaptchaÜretme.TabIndex = 1;
            this.btnRastgeleCaptchaÜretme.Text = "captcha üret";
            this.btnRastgeleCaptchaÜretme.UseVisualStyleBackColor = true;
            this.btnRastgeleCaptchaÜretme.Click += new System.EventHandler(this.btnRastgeleCaptchaÜretme_Click);
            // 
            // btnSayısalLotoyaGeçiş
            // 
            this.btnSayısalLotoyaGeçiş.Location = new System.Drawing.Point(297, 103);
            this.btnSayısalLotoyaGeçiş.Margin = new System.Windows.Forms.Padding(5);
            this.btnSayısalLotoyaGeçiş.Name = "btnSayısalLotoyaGeçiş";
            this.btnSayısalLotoyaGeçiş.Size = new System.Drawing.Size(111, 110);
            this.btnSayısalLotoyaGeçiş.TabIndex = 2;
            this.btnSayısalLotoyaGeçiş.Text = "Sayısal lotoya geç";
            this.btnSayısalLotoyaGeçiş.UseVisualStyleBackColor = true;
            this.btnSayısalLotoyaGeçiş.Click += new System.EventHandler(this.btnSayısalLotoyaGeçiş_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 45);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 265);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSayısalLotoyaGeçiş);
            this.Controls.Add(this.btnRastgeleCaptchaÜretme);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRastgeleCaptchaÜretme;
        private System.Windows.Forms.Button btnSayısalLotoyaGeçiş;
        private System.Windows.Forms.TextBox textBox1;
    }
}

