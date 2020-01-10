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
    public partial class Arama : Form
    {
        public Arama()
        {
            InitializeComponent();
        }
        DataTable dt;
        public static DataRow dr;
        public static int ind;
        private void rdbArsa_CheckedChanged(object sender, EventArgs e)
        {
            CinsSecim();
        }
        private void rdbDaire_CheckedChanged(object sender, EventArgs e)
        {
            CinsSecim();
        }
        private void rdbKonut_CheckedChanged(object sender, EventArgs e)
        {
            CinsSecim();
        }
        private void rdbApartman_CheckedChanged(object sender, EventArgs e)
        {
            CinsSecim();
        }
        private void CinsSecim()
        {
            int KayitSayi=0;
            if(rdbArsa.Checked==true)
            {
                dt= Form1.TableArsa;
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;
                cmbMkare.Items.Clear();
                KayitSayi = dt.Rows.Count;
                
                for(int i=0;i<KayitSayi;i++)
                {
                    string m2 = dataGridView1.Rows[i].Cells["Metrekare"].Value.ToString();
                    if (cmbMkare.Items.IndexOf(m2)==-1)
                    {
                        cmbMkare.Items.Add(m2);
                    }
                }
            }
            else if (rdbDaire.Checked == true)
            {
                dt = Form1.TableDaire;
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;
                cmbMkare.Items.Clear();
                KayitSayi = dt.Rows.Count;
                for (int i = 0; i < KayitSayi; i++)
                {
                    string m2 = dataGridView1.Rows[i].Cells["Metrekare"].Value.ToString();
                    if (cmbMkare.Items.IndexOf(m2) == -1)
                    {
                        cmbMkare.Items.Add(m2);
                    }
                }
            }
            else if (rdbKonut.Checked == true)
            {
                dt = Form1.TableKonut;
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;
                cmbMkare.Items.Clear();
                KayitSayi = dt.Rows.Count;
                for (int i = 0; i < KayitSayi; i++)
                {
                    string m2 = dataGridView1.Rows[i].Cells["Metrekare"].Value.ToString();
                    if (cmbMkare.Items.IndexOf(m2) == -1)
                    {
                        cmbMkare.Items.Add(m2);
                    }
                }
            }
            else if (rdbApartman.Checked == true)
            {
                dt = Form1.TableApt;
                
                dataGridView1.DataSource = dt;
                dataGridView1.Visible = true;
                cmbMkare.Items.Clear();
                KayitSayi = dt.Rows.Count;
                for (int i = 0; i < KayitSayi; i++)
                {
                    string m2 = dataGridView1.Rows[i].Cells["Metrekare"].Value.ToString();
                    if (cmbMkare.Items.IndexOf(m2) == -1)
                    {
                        cmbMkare.Items.Add(m2);
                    }
                }
            }
            else
            {
                dataGridView1.Visible = false;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            if(KayitSayi<1)
            {
                btnSil.Enabled = false;
                btnKayitGuncelle.Enabled = false;
                lbl_Rind.Text = "";
            }
            else
            {
                btnSil.Enabled = true;
                btnKayitGuncelle.Enabled = true;
            }
        }

        
        private void DurumSecim()
        {
            if(rdbSatilik.Checked==true)
            {
                dataGridView1.DataSource = dtViewFilter("Satılık");
            }
            if (rdbKiralik.Checked == true)
            {
                dataGridView1.DataSource = dtViewFilter("Kiralık");
            }
        }
        private DataView dtViewFilter(string durum)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter= "Durum = '"+durum+"'";
            return dv;
        }
        private DataView dtViewFilter2(string m2)
        {
            DataView dv = new DataView(dt);
            dv.RowFilter = "Metrekare = '" + m2 + "'";
            return dv;
        }
        private void Arama_Load(object sender, EventArgs e)
        {
            lbl_Rind.Text = (1 + ind).ToString();
        }

        private void rdbSatilik_CheckedChanged(object sender, EventArgs e)
        {
            DurumSecim();
        }

        private void rdbKiralik_CheckedChanged(object sender, EventArgs e)
        {
            DurumSecim();
        }

        private void btnAramaAnaMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMkare_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dtViewFilter2(cmbMkare.Text);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            KayitSil();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ind = dataGridView1.CurrentCell.RowIndex;
            lbl_Rind.Text = (1+ind).ToString();
        }
        void Guncelle()
        {
            ind = dataGridView1.CurrentCell.RowIndex;
            lbl_Rind.Text = (1 + ind).ToString();
            dr = dt.Rows[ind];
            if (rdbArsa.Checked == true)
            {
                Arsa frmArsa = new Arsa();
                
                frmArsa.ShowDialog();
            }
            else if (rdbDaire.Checked == true)
            {
                Daire frmDaire = new Daire();
                frmDaire.ShowDialog();
            }
            else if (rdbKonut.Checked == true)
            {
                Konut frmKonut = new Konut();
                frmKonut.ShowDialog();
            }
            else if (rdbApartman.Checked == true)
            {
                Apartman frmApt = new Apartman();
                frmApt.ShowDialog();
            }
            dt.Rows[ind].Delete();
        }
        void KayitSil()
        {
            dt.Rows[ind].Delete();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ind = dataGridView1.CurrentCell.RowIndex;
            lbl_Rind.Text = (1 + ind).ToString();
        }

        private void btnKayitGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
            dr = null;
        }

        private void Arama_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("İşlem Yapılacak Satırı\nSatır Başından Seçin. ");
        }
    }
}
