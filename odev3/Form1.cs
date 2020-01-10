using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/************************************************************************************************
|								SAKARYA ÜNİVERSİTESİ											|
|					 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ									|
|						  BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ										|
|							      2016-2017 BAHAR												|
|							 NESNEYE DAYALI PROGRAMLAMA		    								|	
|																								|
|																								|
|				ÖDEV NUMARASI.....: 3															|
|				ÖĞRENCİ NUMARASI..: b161200042													|	
|				ÖĞRENCİ AD SOYAD..: AHMET MÜCAHİT TARAKÇI										|
|																								|
|																								|
************************************************************************************************/

namespace odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static DataTable TableArsa = new DataTable();
        public static DataTable TableDaire = new DataTable();
        public static DataTable TableKonut = new DataTable();
        public static DataTable TableApt = new DataTable();

        private void ArsaSutunEkle()
        {
            TableArsa.Columns.Add("Metrekare", typeof(string));
            TableArsa.Columns.Add("Fiyat", typeof(string));
            TableArsa.Columns.Add("Durum", typeof(string));
            TableArsa.Columns.Add("Emlakçı Ad Soyad", typeof(string));
            TableArsa.Columns.Add("Emlakçı Telefon", typeof(string));
        }
        private void DaireSutunEkle()
        {
            TableDaire.Columns.Add("Metrekare", typeof(string));
            TableDaire.Columns.Add("Oda Sayısı", typeof(string));
            TableDaire.Columns.Add("BalkonSayısı", typeof(string));
            TableDaire.Columns.Add("Tuvalet/Banyo", typeof(string));
            TableDaire.Columns.Add("Fiyat", typeof(string));
            TableDaire.Columns.Add("Durum", typeof(string));
            TableDaire.Columns.Add("Emlakçı Ad Soyad", typeof(string));
            TableDaire.Columns.Add("Emlakçı Telefon", typeof(string));
        }
        private void KonutSutunEkle()
        {
            TableKonut.Columns.Add("Metrekare", typeof(string));
            TableKonut.Columns.Add("Oda Sayısı", typeof(string));
            TableKonut.Columns.Add("BalkonSayısı", typeof(string));
            TableKonut.Columns.Add("Kat Sayısı", typeof(string));
            TableKonut.Columns.Add("Fiyat", typeof(string));
            TableKonut.Columns.Add("Durum", typeof(string));
            TableKonut.Columns.Add("Emlakçı Ad Soyad", typeof(string));
            TableKonut.Columns.Add("Emlakçı Telefon", typeof(string));
        }
        private void AptSutunEkle()
        {
            TableApt.Columns.Add("Metrekare", typeof(string));
            TableApt.Columns.Add("Oda Sayısı", typeof(string));
            TableApt.Columns.Add("BalkonSayısı", typeof(string));
            TableApt.Columns.Add("Daire Sayısı", typeof(string));
            TableApt.Columns.Add("Fiyat", typeof(string));
            TableApt.Columns.Add("Durum", typeof(string));
            TableApt.Columns.Add("Emlakçı Ad Soyad", typeof(string));
            TableApt.Columns.Add("Emlakçı Telefon", typeof(string));
        }

        private void btnArsaEkle_Click(object sender, EventArgs e)
        {
            Arsa frmArsa = new Arsa();
            this.Visible = false;
            frmArsa.ShowDialog();
            this.Visible = true;
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Arama frmArama = new Arama();
            this.Visible = false;
            frmArama.ShowDialog();
            this.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DaireSutunEkle();
            ArsaSutunEkle();
            KonutSutunEkle();
            AptSutunEkle();
        }

        private void btnDaireEkle_Click(object sender, EventArgs e)
        {
            Daire frmDaire = new Daire();
            this.Visible = false;
            frmDaire.ShowDialog();
            this.Visible = true;
        }

        private void btnKonutEkle_Click(object sender, EventArgs e)
        {
            Konut frmKonut = new Konut();
            this.Visible = false;
            frmKonut.ShowDialog();
            this.Visible = true;
        }

        private void btnAptEkle_Click(object sender, EventArgs e)
        {
            Apartman frmApt = new Apartman();
            this.Visible = false;
            frmApt.ShowDialog();
            this.Visible = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
