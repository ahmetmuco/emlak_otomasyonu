namespace odev3
{
    partial class Arama
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
            this.rdbArsa = new System.Windows.Forms.RadioButton();
            this.Cinsi = new System.Windows.Forms.GroupBox();
            this.rdbApartman = new System.Windows.Forms.RadioButton();
            this.rdbKonut = new System.Windows.Forms.RadioButton();
            this.rdbDaire = new System.Windows.Forms.RadioButton();
            this.Durumu = new System.Windows.Forms.GroupBox();
            this.rdbKiralik = new System.Windows.Forms.RadioButton();
            this.rdbSatilik = new System.Windows.Forms.RadioButton();
            this.cmbMkare = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAramaAnaMenu = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKayitGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Rind = new System.Windows.Forms.Label();
            this.Cinsi.SuspendLayout();
            this.Durumu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbArsa
            // 
            this.rdbArsa.AutoSize = true;
            this.rdbArsa.Location = new System.Drawing.Point(16, 19);
            this.rdbArsa.Name = "rdbArsa";
            this.rdbArsa.Size = new System.Drawing.Size(46, 17);
            this.rdbArsa.TabIndex = 0;
            this.rdbArsa.TabStop = true;
            this.rdbArsa.Text = "Arsa";
            this.rdbArsa.UseVisualStyleBackColor = true;
            this.rdbArsa.CheckedChanged += new System.EventHandler(this.rdbArsa_CheckedChanged);
            // 
            // Cinsi
            // 
            this.Cinsi.Controls.Add(this.rdbApartman);
            this.Cinsi.Controls.Add(this.rdbKonut);
            this.Cinsi.Controls.Add(this.rdbDaire);
            this.Cinsi.Controls.Add(this.rdbArsa);
            this.Cinsi.Location = new System.Drawing.Point(12, 12);
            this.Cinsi.Name = "Cinsi";
            this.Cinsi.Size = new System.Drawing.Size(92, 113);
            this.Cinsi.TabIndex = 1;
            this.Cinsi.TabStop = false;
            this.Cinsi.Text = "Cinsi";
            // 
            // rdbApartman
            // 
            this.rdbApartman.AutoSize = true;
            this.rdbApartman.Location = new System.Drawing.Point(16, 88);
            this.rdbApartman.Name = "rdbApartman";
            this.rdbApartman.Size = new System.Drawing.Size(70, 17);
            this.rdbApartman.TabIndex = 3;
            this.rdbApartman.TabStop = true;
            this.rdbApartman.Text = "Apartman";
            this.rdbApartman.UseVisualStyleBackColor = true;
            this.rdbApartman.CheckedChanged += new System.EventHandler(this.rdbApartman_CheckedChanged);
            // 
            // rdbKonut
            // 
            this.rdbKonut.AutoSize = true;
            this.rdbKonut.Location = new System.Drawing.Point(16, 65);
            this.rdbKonut.Name = "rdbKonut";
            this.rdbKonut.Size = new System.Drawing.Size(53, 17);
            this.rdbKonut.TabIndex = 2;
            this.rdbKonut.TabStop = true;
            this.rdbKonut.Text = "Konut";
            this.rdbKonut.UseVisualStyleBackColor = true;
            this.rdbKonut.CheckedChanged += new System.EventHandler(this.rdbKonut_CheckedChanged);
            // 
            // rdbDaire
            // 
            this.rdbDaire.AutoSize = true;
            this.rdbDaire.Location = new System.Drawing.Point(16, 42);
            this.rdbDaire.Name = "rdbDaire";
            this.rdbDaire.Size = new System.Drawing.Size(50, 17);
            this.rdbDaire.TabIndex = 1;
            this.rdbDaire.TabStop = true;
            this.rdbDaire.Text = "Daire";
            this.rdbDaire.UseVisualStyleBackColor = true;
            this.rdbDaire.CheckedChanged += new System.EventHandler(this.rdbDaire_CheckedChanged);
            // 
            // Durumu
            // 
            this.Durumu.Controls.Add(this.rdbKiralik);
            this.Durumu.Controls.Add(this.rdbSatilik);
            this.Durumu.Location = new System.Drawing.Point(110, 12);
            this.Durumu.Name = "Durumu";
            this.Durumu.Size = new System.Drawing.Size(92, 69);
            this.Durumu.TabIndex = 4;
            this.Durumu.TabStop = false;
            this.Durumu.Text = "Durumu";
            // 
            // rdbKiralik
            // 
            this.rdbKiralik.AutoSize = true;
            this.rdbKiralik.Location = new System.Drawing.Point(16, 42);
            this.rdbKiralik.Name = "rdbKiralik";
            this.rdbKiralik.Size = new System.Drawing.Size(53, 17);
            this.rdbKiralik.TabIndex = 1;
            this.rdbKiralik.TabStop = true;
            this.rdbKiralik.Text = "Kiralık";
            this.rdbKiralik.UseVisualStyleBackColor = true;
            this.rdbKiralik.CheckedChanged += new System.EventHandler(this.rdbKiralik_CheckedChanged);
            // 
            // rdbSatilik
            // 
            this.rdbSatilik.AutoSize = true;
            this.rdbSatilik.Location = new System.Drawing.Point(16, 19);
            this.rdbSatilik.Name = "rdbSatilik";
            this.rdbSatilik.Size = new System.Drawing.Size(53, 17);
            this.rdbSatilik.TabIndex = 0;
            this.rdbSatilik.TabStop = true;
            this.rdbSatilik.Text = "Satılık";
            this.rdbSatilik.UseVisualStyleBackColor = true;
            this.rdbSatilik.CheckedChanged += new System.EventHandler(this.rdbSatilik_CheckedChanged);
            // 
            // cmbMkare
            // 
            this.cmbMkare.FormattingEnabled = true;
            this.cmbMkare.Location = new System.Drawing.Point(208, 31);
            this.cmbMkare.Name = "cmbMkare";
            this.cmbMkare.Size = new System.Drawing.Size(121, 21);
            this.cmbMkare.TabIndex = 2;
            this.cmbMkare.SelectedIndexChanged += new System.EventHandler(this.cmbMkare_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Metrekare";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(798, 333);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btnAramaAnaMenu
            // 
            this.btnAramaAnaMenu.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAramaAnaMenu.Location = new System.Drawing.Point(695, 12);
            this.btnAramaAnaMenu.Name = "btnAramaAnaMenu";
            this.btnAramaAnaMenu.Size = new System.Drawing.Size(115, 105);
            this.btnAramaAnaMenu.TabIndex = 6;
            this.btnAramaAnaMenu.Text = "Ana Menü";
            this.btnAramaAnaMenu.UseVisualStyleBackColor = true;
            this.btnAramaAnaMenu.Click += new System.EventHandler(this.btnAramaAnaMenu_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(574, 12);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(115, 105);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Kayıt Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKayitGuncelle
            // 
            this.btnKayitGuncelle.Font = new System.Drawing.Font("Microsoft Tai Le", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitGuncelle.Location = new System.Drawing.Point(453, 12);
            this.btnKayitGuncelle.Name = "btnKayitGuncelle";
            this.btnKayitGuncelle.Size = new System.Drawing.Size(115, 105);
            this.btnKayitGuncelle.TabIndex = 8;
            this.btnKayitGuncelle.Text = "Kayıt Güncelle";
            this.btnKayitGuncelle.UseVisualStyleBackColor = true;
            this.btnKayitGuncelle.Click += new System.EventHandler(this.btnKayitGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(276, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seçili Satır :";
            // 
            // lbl_Rind
            // 
            this.lbl_Rind.AutoSize = true;
            this.lbl_Rind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Rind.Location = new System.Drawing.Point(373, 111);
            this.lbl_Rind.Name = "lbl_Rind";
            this.lbl_Rind.Size = new System.Drawing.Size(0, 17);
            this.lbl_Rind.TabIndex = 10;
            // 
            // Arama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(814, 476);
            this.Controls.Add(this.lbl_Rind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKayitGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnAramaAnaMenu);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMkare);
            this.Controls.Add(this.Durumu);
            this.Controls.Add(this.Cinsi);
            this.Name = "Arama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arama";
            this.Load += new System.EventHandler(this.Arama_Load);
            this.Shown += new System.EventHandler(this.Arama_Shown);
            this.Cinsi.ResumeLayout(false);
            this.Cinsi.PerformLayout();
            this.Durumu.ResumeLayout(false);
            this.Durumu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbArsa;
        private System.Windows.Forms.GroupBox Cinsi;
        private System.Windows.Forms.RadioButton rdbApartman;
        private System.Windows.Forms.RadioButton rdbKonut;
        private System.Windows.Forms.RadioButton rdbDaire;
        private System.Windows.Forms.GroupBox Durumu;
        private System.Windows.Forms.RadioButton rdbKiralik;
        private System.Windows.Forms.RadioButton rdbSatilik;
        private System.Windows.Forms.ComboBox cmbMkare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAramaAnaMenu;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKayitGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Rind;
    }
}