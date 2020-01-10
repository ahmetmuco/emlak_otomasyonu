namespace odev3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnArsaEkle = new System.Windows.Forms.Button();
            this.btnDaireEkle = new System.Windows.Forms.Button();
            this.btnKonutEkle = new System.Windows.Forms.Button();
            this.btnAptEkle = new System.Windows.Forms.Button();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArsaEkle
            // 
            this.btnArsaEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArsaEkle.Location = new System.Drawing.Point(12, 10);
            this.btnArsaEkle.Name = "btnArsaEkle";
            this.btnArsaEkle.Size = new System.Drawing.Size(128, 55);
            this.btnArsaEkle.TabIndex = 0;
            this.btnArsaEkle.Text = "Arsa Ekle";
            this.btnArsaEkle.UseVisualStyleBackColor = true;
            this.btnArsaEkle.Click += new System.EventHandler(this.btnArsaEkle_Click);
            // 
            // btnDaireEkle
            // 
            this.btnDaireEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDaireEkle.Location = new System.Drawing.Point(12, 71);
            this.btnDaireEkle.Name = "btnDaireEkle";
            this.btnDaireEkle.Size = new System.Drawing.Size(128, 55);
            this.btnDaireEkle.TabIndex = 1;
            this.btnDaireEkle.Text = "Daire Ekle";
            this.btnDaireEkle.UseVisualStyleBackColor = true;
            this.btnDaireEkle.Click += new System.EventHandler(this.btnDaireEkle_Click);
            // 
            // btnKonutEkle
            // 
            this.btnKonutEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKonutEkle.Location = new System.Drawing.Point(12, 132);
            this.btnKonutEkle.Name = "btnKonutEkle";
            this.btnKonutEkle.Size = new System.Drawing.Size(128, 55);
            this.btnKonutEkle.TabIndex = 2;
            this.btnKonutEkle.Text = "Konut Ekle";
            this.btnKonutEkle.UseVisualStyleBackColor = true;
            this.btnKonutEkle.Click += new System.EventHandler(this.btnKonutEkle_Click);
            // 
            // btnAptEkle
            // 
            this.btnAptEkle.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAptEkle.Location = new System.Drawing.Point(12, 193);
            this.btnAptEkle.Name = "btnAptEkle";
            this.btnAptEkle.Size = new System.Drawing.Size(128, 55);
            this.btnAptEkle.TabIndex = 3;
            this.btnAptEkle.Text = "Apartman Ekle";
            this.btnAptEkle.UseVisualStyleBackColor = true;
            this.btnAptEkle.Click += new System.EventHandler(this.btnAptEkle_Click);
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.Location = new System.Drawing.Point(234, 99);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(128, 55);
            this.btnListele.TabIndex = 4;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(234, 193);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(128, 55);
            this.btnKapat.TabIndex = 5;
            this.btnKapat.Text = "Çıkış";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 261);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.btnAptEkle);
            this.Controls.Add(this.btnKonutEkle);
            this.Controls.Add(this.btnDaireEkle);
            this.Controls.Add(this.btnArsaEkle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArsaEkle;
        private System.Windows.Forms.Button btnDaireEkle;
        private System.Windows.Forms.Button btnKonutEkle;
        private System.Windows.Forms.Button btnAptEkle;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKapat;
    }
}

