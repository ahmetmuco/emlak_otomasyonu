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
    public partial class Konut : Form
    {
        public Konut()
        {
            InitializeComponent();
        }

        DataTable TblKonut = Form1.TableKonut;

        private void KonutSatirEkle()
        {
            TblKonut.Rows.Add(txtKonutMetre.Text, cmbKonutOda.Text, txtKonutBalkon.Text, txtKonutKat.Text, txtKonutFiyat.Text, cmbKonutSatKira.Text, txtKonutAdSoyad.Text, txtKonutTelefon.Text);
        }

        private void Konut_Load(object sender, EventArgs e)
        {
            DataRow dr = Arama.dr;
            if (dr != null)
            {
                txtKonutMetre.Text = dr[0].ToString();
                cmbKonutOda.Text = dr[1].ToString();
                txtKonutBalkon.Text = dr[2].ToString();
                txtKonutKat.Text = dr[3].ToString();
                txtKonutFiyat.Text = dr[4].ToString();
                cmbKonutSatKira.Text = dr[5].ToString();
                txtKonutAdSoyad.Text = dr[6].ToString();
                txtKonutTelefon.Text = dr[7].ToString();
            }
        }

        private void btnKonutKaydet_Click(object sender, EventArgs e)
        {
            KonutSatirEkle();
            txtKonutMetre.Text = "";
            cmbKonutOda.Text = "";
            txtKonutBalkon.Text = "";
            txtKonutKat.Text = "";
            txtKonutFiyat.Text = "";
            cmbKonutSatKira.Text = "";
            txtKonutAdSoyad.Text = "";
            txtKonutTelefon.Text = "";
            MessageBox.Show("Kaydedildi.");
        }

        private void btnKonutAnaMenu_Click(object sender, EventArgs e)
        {
            txtKonutMetre.Text = "";
            cmbKonutOda.Text = "";
            txtKonutBalkon.Text = "";
            txtKonutKat.Text = "";
            txtKonutFiyat.Text = "";
            cmbKonutSatKira.Text = "";
            txtKonutAdSoyad.Text = "";
            txtKonutTelefon.Text = "";
            this.Close();
        }
    }
}
