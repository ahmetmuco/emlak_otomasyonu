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
    public partial class Arsa : Form
    {
        public Arsa()
        {
            InitializeComponent();
        }

        DataTable TblArsa = Form1.TableArsa;

        private void SatirEkle()
        {
            TblArsa.Rows.Add(txtArsaMetre.Text, txtArsaFiyat.Text, cmbArsaSatKira.Text, txtArsaAdSoyad.Text, txtArsaTelefon.Text);
        }

        private void Arsa_Load(object sender, EventArgs e)
        {
            DataRow dr = Arama.dr;
            if (dr != null)
            {
                txtArsaMetre.Text = dr[0].ToString();
                txtArsaFiyat.Text = dr[1].ToString();
                cmbArsaSatKira.Text = dr[2].ToString();
                txtArsaAdSoyad.Text = dr[3].ToString();
                txtArsaTelefon.Text = dr[4].ToString();
            }
        }

        private void btnArsaKaydet_Click(object sender, EventArgs e)
        {
            SatirEkle();
            cmbArsaSatKira.Text = "";
            txtArsaTelefon.Text = "";
            txtArsaMetre.Text = "";
            txtArsaAdSoyad.Text = "";
            txtArsaFiyat.Text = "";
            MessageBox.Show("Kaydedildi.");
        }
        
        private void btnArsaAnaMenu_Click(object sender, EventArgs e)
        {
            cmbArsaSatKira.Text = "";
            txtArsaTelefon.Text = "";
            txtArsaMetre.Text = "";
            txtArsaAdSoyad.Text = "";
            txtArsaFiyat.Text = "";
            this.Close();
        }
    }
}
