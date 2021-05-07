using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        List<string> listKota = new List<string>();
        JsonArray listKotaId = new JsonArray();
        public Form1()
        {
            InitializeComponent();
            listKota = Ongkir.GetKotaList();
            listKotaId = Ongkir.GetKotaIdList();
            foreach(string kota in listKota)
            {
                tbAsal.AutoCompleteCustomSource.Add(kota);
                tbAsal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbAsal.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tbTujuan.AutoCompleteCustomSource.Add(kota);
                tbTujuan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbTujuan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void TampilkanDaftar(List<string> daftarLayanan )
        {
            gbLayanan.Text = "Detail Layanan\n";
            foreach(string layanan in daftarLayanan)
            {
                gbLayanan.Text += "\n-" + layanan;
            }
        }
        private int GetIdKota(string kota)
        {
            int idKota = -1;
            foreach(JsonObject city in listKotaId)
            {
                if(((string)city["city_name"] == kota))
                {
                    idKota = int.Parse((string)city["city_id"]);
                    break;
                }
            }
            return idKota;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbAsal.Text != "" || tbTujuan.Text != "" || tbBerat.Text != "")
            {
                string kurir = "";
                if (rbJne.Checked)
                    kurir = "jne";
                else if (rbPos.Checked)
                    kurir = "pos";
                else if (rbTiki.Checked)
                    kurir = "tiki";
                List<string> daftarLayanan = Ongkir.GetLayananList
                    (GetIdKota(tbAsal.Text), GetIdKota(tbTujuan.Text), int.Parse(tbBerat.Text), kurir);
                TampilkanDaftar(daftarLayanan);
            }
        }

        
    }
}
