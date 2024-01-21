namespace GeçerNotHesap
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
            this.ögrNo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AraNot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FinalNot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GeçerNot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci No:";
            // 
            // ögrNo
            // 
            this.ögrNo.Location = new System.Drawing.Point(77, 131);
            this.ögrNo.Name = "ögrNo";
            this.ögrNo.Size = new System.Drawing.Size(100, 22);
            this.ögrNo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AraNot
            // 
            this.AraNot.Location = new System.Drawing.Point(256, 131);
            this.AraNot.Name = "AraNot";
            this.AraNot.Size = new System.Drawing.Size(100, 22);
            this.AraNot.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ara Sınav Not:";
            // 
            // FinalNot
            // 
            this.FinalNot.Location = new System.Drawing.Point(468, 131);
            this.FinalNot.Name = "FinalNot";
            this.FinalNot.Size = new System.Drawing.Size(100, 22);
            this.FinalNot.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Final Not:";
            // 
            // GeçerNot
            // 
            this.GeçerNot.Location = new System.Drawing.Point(644, 131);
            this.GeçerNot.Name = "GeçerNot";
            this.GeçerNot.Size = new System.Drawing.Size(100, 22);
            this.GeçerNot.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Geçer Not:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 671);
            this.Controls.Add(this.GeçerNot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FinalNot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AraNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ögrNo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ögrNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AraNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FinalNot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GeçerNot;
        private System.Windows.Forms.Label label4;
    }
}

