using HastaneOtomasyon.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon.Forms
{
    public partial class DosyaBul : Form
    {
        public DosyaBul()
        {
            InitializeComponent();
        }
        Search search;
         
        private void cb_arama_kriteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_arama_kriteri.SelectedItem.ToString())
            {
                case "Hasta Adı ve Soyadı":
                    txt_search.Visible = false;
                    dgv_arama.DataSource = null;
                    break;
                default:
                    txt_search.Visible = true;
                    dgv_arama.DataSource = null;
                    break;
            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            AramaYap();
        }

        private void AramaYap()
        {
            DataTable gelen;
            search = new Search();
            switch (cb_arama_kriteri.SelectedItem.ToString())
            {
                case "Hasta Adı ve Soyadı":
                    if (txt_ad.Text != "" || txt_soyadı.Text != "")
                    {
                        if (txt_ad.Text == "")
                        {
                            dgv_arama.DataSource = null;
                            gelen = search.SoyIsimArama(txt_soyadı.Text.ToString());
                            dgv_arama.DataSource = gelen;
                        }
                        else if (txt_soyadı.Text == "")
                        {
                            dgv_arama.DataSource = null;
                            gelen = search.isimArama(txt_ad.Text.ToString());
                            dgv_arama.DataSource = gelen;
                        }
                        else
                        {
                            dgv_arama.DataSource = null;
                            gelen = search.isimArama(txt_ad.Text.ToString(), txt_soyadı.Text.ToString());
                            dgv_arama.DataSource = gelen;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir isim ya da soyisim giriniz");
                    }
                    break;
                case "Kimlik No":
                    if (txt_search.Text != "")
                    {
                        dgv_arama.DataSource = null;
                        gelen = search.KimlikNoArama(txt_search.Text.ToString());
                        dgv_arama.DataSource = gelen;

                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir numara giriniz!");
                    }
                    break;
                case "Kurum Sicil No":
                    if (txt_search.Text != "")
                    {
                        dgv_arama.DataSource = null;
                        gelen = search.KurumSicilNoArama(txt_search.Text.ToString());
                        dgv_arama.DataSource = gelen;

                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir numara giriniz!");
                    }
                    break;
                case "Dosya No":
                    if (txt_search.Text != "")
                    {
                        dgv_arama.DataSource = null;
                        gelen = search.DosyaNoArama(txt_search.Text.ToString());
                        dgv_arama.DataSource = gelen;

                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir numara giriniz!");
                    }
                    break;
                default:

                    break;
            }
        }

        private void DosyaBul_Load(object sender, EventArgs e)
        {
           
        }
    }
}
