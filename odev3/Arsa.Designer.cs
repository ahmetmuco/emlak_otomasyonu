namespace odev3
{
    partial class Arsa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArsaMetre = new System.Windows.Forms.TextBox();
            this.txtArsaFiyat = new System.Windows.Forms.TextBox();
            this.cmbArsaSatKira = new System.Windows.Forms.ComboBox();
            this.txtArsaTelefon = new System.Windows.Forms.TextBox();
            this.txtArsaAdSoyad = new System.Windows.Forms.TextBox();
            this.btnArsaKaydet = new System.Windows.Forms.Button();
            this.btnArsaAnaMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arsanın";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(354, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emlakçının";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(33, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Metrekaresi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(84, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiyat:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(23, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Satılık/Kiralık:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(329, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(311, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ad Soyad:";
            // 
            // txtArsaMetre
            // 
            this.txtArsaMetre.Location = new System.Drawing.Point(142, 85);
            this.txtArsaMetre.Name = "txtArsaMetre";
            this.txtArsaMetre.Size = new System.Drawing.Size(100, 20);
            this.txtArsaMetre.TabIndex = 0;
            // 
            // txtArsaFiyat
            // 
            this.txtArsaFiyat.Location = new System.Drawing.Point(142, 173);
            this.txtArsaFiyat.Name = "txtArsaFiyat";
            this.txtArsaFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtArsaFiyat.TabIndex = 2;
            // 
            // cmbArsaSatKira
            // 
            this.cmbArsaSatKira.FormattingEnabled = true;
            this.cmbArsaSatKira.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık"});
            this.cmbArsaSatKira.Location = new System.Drawing.Point(142, 131);
            this.cmbArsaSatKira.Name = "cmbArsaSatKira";
            this.cmbArsaSatKira.Size = new System.Drawing.Size(100, 21);
            this.cmbArsaSatKira.TabIndex = 1;
            // 
            // txtArsaTelefon
            // 
            this.txtArsaTelefon.Location = new System.Drawing.Point(399, 131);
            this.txtArsaTelefon.Name = "txtArsaTelefon";
            this.txtArsaTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtArsaTelefon.TabIndex = 4;
            // 
            // txtArsaAdSoyad
            // 
            this.txtArsaAdSoyad.Location = new System.Drawing.Point(399, 85);
            this.txtArsaAdSoyad.Name = "txtArsaAdSoyad";
            this.txtArsaAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.txtArsaAdSoyad.TabIndex = 3;
            // 
            // btnArsaKaydet
            // 
            this.btnArsaKaydet.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArsaKaydet.Location = new System.Drawing.Point(206, 220);
            this.btnArsaKaydet.Name = "btnArsaKaydet";
            this.btnArsaKaydet.Size = new System.Drawing.Size(167, 48);
            this.btnArsaKaydet.TabIndex = 5;
            this.btnArsaKaydet.Text = "Kaydet";
            this.btnArsaKaydet.UseVisualStyleBackColor = true;
            this.btnArsaKaydet.Click += new System.EventHandler(this.btnArsaKaydet_Click);
            // 
            // btnArsaAnaMenu
            // 
            this.btnArsaAnaMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArsaAnaMenu.Location = new System.Drawing.Point(206, 274);
            this.btnArsaAnaMenu.Name = "btnArsaAnaMenu";
            this.btnArsaAnaMenu.Size = new System.Drawing.Size(167, 47);
            this.btnArsaAnaMenu.TabIndex = 6;
            this.btnArsaAnaMenu.Text = "Ana Menü";
            this.btnArsaAnaMenu.UseVisualStyleBackColor = true;
            this.btnArsaAnaMenu.Click += new System.EventHandler(this.btnArsaAnaMenu_Click);
            // 
            // Arsa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(532, 331);
            this.Controls.Add(this.btnArsaAnaMenu);
            this.Controls.Add(this.btnArsaKaydet);
            this.Controls.Add(this.txtArsaAdSoyad);
            this.Controls.Add(this.txtArsaTelefon);
            this.Controls.Add(this.cmbArsaSatKira);
            this.Controls.Add(this.txtArsaFiyat);
            this.Controls.Add(this.txtArsaMetre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Arsa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arsa";
            this.Load += new System.EventHandler(this.Arsa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtArsaMetre;
        private System.Windows.Forms.TextBox txtArsaFiyat;
        private System.Windows.Forms.ComboBox cmbArsaSatKira;
        private System.Windows.Forms.TextBox txtArsaTelefon;
        private System.Windows.Forms.TextBox txtArsaAdSoyad;
        private System.Windows.Forms.Button btnArsaKaydet;
        private System.Windows.Forms.Button btnArsaAnaMenu;
    }
}