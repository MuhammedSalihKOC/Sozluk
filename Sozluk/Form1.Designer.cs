namespace Sozluk
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
            this.Cevrilen = new System.Windows.Forms.TextBox();
            this.Cevrilmis = new System.Windows.Forms.Label();
            this.Cevir = new System.Windows.Forms.Button();
            this.TRtoENG = new System.Windows.Forms.RadioButton();
            this.ENGtoTR = new System.Windows.Forms.RadioButton();
            this.ekleTR = new System.Windows.Forms.TextBox();
            this.ekleENG = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cevrilen
            // 
            this.Cevrilen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cevrilen.Location = new System.Drawing.Point(169, 104);
            this.Cevrilen.Multiline = true;
            this.Cevrilen.Name = "Cevrilen";
            this.Cevrilen.Size = new System.Drawing.Size(168, 31);
            this.Cevrilen.TabIndex = 0;
            // 
            // Cevrilmis
            // 
            this.Cevrilmis.AutoSize = true;
            this.Cevrilmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Cevrilmis.Location = new System.Drawing.Point(526, 107);
            this.Cevrilmis.Name = "Cevrilmis";
            this.Cevrilmis.Size = new System.Drawing.Size(0, 26);
            this.Cevrilmis.TabIndex = 1;
            // 
            // Cevir
            // 
            this.Cevir.Location = new System.Drawing.Point(396, 167);
            this.Cevir.Name = "Cevir";
            this.Cevir.Size = new System.Drawing.Size(75, 23);
            this.Cevir.TabIndex = 2;
            this.Cevir.Text = "Çevir";
            this.Cevir.UseVisualStyleBackColor = true;
            this.Cevir.Click += new System.EventHandler(this.Cevir_Click);
            // 
            // TRtoENG
            // 
            this.TRtoENG.AutoSize = true;
            this.TRtoENG.Checked = true;
            this.TRtoENG.Location = new System.Drawing.Point(388, 27);
            this.TRtoENG.Name = "TRtoENG";
            this.TRtoENG.Size = new System.Drawing.Size(129, 17);
            this.TRtoENG.TabIndex = 3;
            this.TRtoENG.TabStop = true;
            this.TRtoENG.Text = "Türkçeden İngilizceye";
            this.TRtoENG.UseVisualStyleBackColor = true;
            this.TRtoENG.CheckedChanged += new System.EventHandler(this.TRtoENG_CheckedChanged);
            // 
            // ENGtoTR
            // 
            this.ENGtoTR.AutoSize = true;
            this.ENGtoTR.Location = new System.Drawing.Point(388, 50);
            this.ENGtoTR.Name = "ENGtoTR";
            this.ENGtoTR.Size = new System.Drawing.Size(129, 17);
            this.ENGtoTR.TabIndex = 4;
            this.ENGtoTR.Text = "İngilizceden Türkçeye";
            this.ENGtoTR.UseVisualStyleBackColor = true;
            this.ENGtoTR.CheckedChanged += new System.EventHandler(this.ENGtoTR_CheckedChanged);
            // 
            // ekleTR
            // 
            this.ekleTR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleTR.Location = new System.Drawing.Point(90, 288);
            this.ekleTR.Multiline = true;
            this.ekleTR.Name = "ekleTR";
            this.ekleTR.Size = new System.Drawing.Size(168, 31);
            this.ekleTR.TabIndex = 5;
            // 
            // ekleENG
            // 
            this.ekleENG.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleENG.Location = new System.Drawing.Point(405, 288);
            this.ekleENG.Multiline = true;
            this.ekleENG.Name = "ekleENG";
            this.ekleENG.Size = new System.Drawing.Size(168, 31);
            this.ekleENG.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(599, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Türkçe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(293, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "İngilizce:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(344, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sözlüğe Ekle";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Sözler";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ekleENG);
            this.Controls.Add(this.ekleTR);
            this.Controls.Add(this.ENGtoTR);
            this.Controls.Add(this.TRtoENG);
            this.Controls.Add(this.Cevir);
            this.Controls.Add(this.Cevrilmis);
            this.Controls.Add(this.Cevrilen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Cevrilen;
        private System.Windows.Forms.Label Cevrilmis;
        private System.Windows.Forms.Button Cevir;
        private System.Windows.Forms.RadioButton TRtoENG;
        private System.Windows.Forms.RadioButton ENGtoTR;
        private System.Windows.Forms.TextBox ekleTR;
        private System.Windows.Forms.TextBox ekleENG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

