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
    public partial class Apartman : Form
    {
        public Apartman()
        {
            InitializeComponent();
        }

        DataTable TblApt = Form1.TableApt;

        private void AptSatirEkle()
        {
            TblApt.Rows.Add(txtAptMetre.Text, cmbAptOda.Text, txtAptBalkon.Text, txtAptKat.Text, txtAptFiyat.Text, cmbAptSatKira.Text, txtAptAdSoyad.Text, txtAptTelefon.Text);
        }

        private void Apartman_Load(object sender, EventArgs e)
        {
            DataRow dr = Arama.dr;
            if (dr != null)
            {
                txtAptMetre.Text = dr[0].ToString();
                cmbAptOda.Text = dr[1].ToString();
                txtAptBalkon.Text = dr[2].ToString();
                txtAptKat.Text = dr[3].ToString();
                txtAptFiyat.Text = dr[4].ToString();
                cmbAptSatKira.Text = dr[5].ToString();
                txtAptAdSoyad.Text = dr[6].ToString();
                txtAptTelefon.Text = dr[7].ToString();
            }
        }

        private void btnAptKaydet_Click(object sender, EventArgs e)
        {
            AptSatirEkle();
            txtAptMetre.Text = "";
            cmbAptOda.Text = "";
            txtAptBalkon.Text = "";
            txtAptKat.Text = "";
            txtAptFiyat.Text = "";
            cmbAptSatKira.Text = "";
            txtAptAdSoyad.Text = "";
            txtAptTelefon.Text = "";
            MessageBox.Show("Kaydedildi.");
        }

        private void btnAptAnaMenu_Click(object sender, EventArgs e)
        {
            txtAptMetre.Text = "";
            cmbAptOda.Text = "";
            txtAptBalkon.Text = "";
            txtAptKat.Text = "";
            txtAptFiyat.Text = "";
            cmbAptSatKira.Text = "";
            txtAptAdSoyad.Text = "";
            txtAptTelefon.Text = "";
            this.Close();
        }
    }
}
