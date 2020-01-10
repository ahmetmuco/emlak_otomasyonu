using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev3
{
    public partial class Daire : Form
    {
        public Daire()
        {
            InitializeComponent();
        }
        DataTable TblDaire = Form1.TableDaire;

        private void DaireSatirEkle()
        {
            TblDaire.Rows.Add(txtDaireMetre.Text, cmbDaireOda.Text,txtDaireBalkon.Text, cmbDaireBanyo.Text, txtDaireFiyat.Text, cmbDaireSatKira.Text,txtDaireAdSoyad.Text,txtDaireTelefon.Text);
        }

        private void Daire_Load(object sender, EventArgs e)
        {
            DataRow dr = Arama.dr;
            if (dr != null)
            {
                txtDaireMetre.Text = dr[0].ToString();
                cmbDaireOda.Text = dr[1].ToString();
                txtDaireBalkon.Text = dr[2].ToString();
                cmbDaireBanyo.Text = dr[3].ToString();
                txtDaireFiyat.Text = dr[4].ToString();
                cmbDaireSatKira.Text = dr[5].ToString();
                txtDaireAdSoyad.Text = dr[6].ToString();
                txtDaireTelefon.Text = dr[7].ToString();
            }
        }

        private void btnDaireKaydet_Click(object sender, EventArgs e)
        {
            DaireSatirEkle();
            txtDaireMetre.Text = "";
            cmbDaireOda.Text = "";
            txtDaireBalkon.Text = "";
            cmbDaireBanyo.Text = "";
            txtDaireFiyat.Text = "";
            cmbDaireSatKira.Text = "";
            txtDaireAdSoyad.Text = "";
            txtDaireTelefon.Text = "";
            MessageBox.Show("Kaydedildi.");
        }

        private void btnDaireAnaMenu_Click(object sender, EventArgs e)
        {
            txtDaireMetre.Text = "";
            cmbDaireOda.Text = "";
            txtDaireBalkon.Text = "";
            cmbDaireBanyo.Text = "";
            txtDaireFiyat.Text = "";
            cmbDaireSatKira.Text = "";
            txtDaireAdSoyad.Text = "";
            txtDaireTelefon.Text = "";
            this.Close();
        } 
    }
}
