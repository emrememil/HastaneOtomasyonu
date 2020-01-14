using HastaneOtomasyon.ClassModels;
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
    public partial class IslemEkle : Form
    {
        public IslemEkle()
        {
            InitializeComponent();
        }
        Islem islem = new Islem();
        private void btn_vazgeç_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_islemadi.Text != "" && txt_birimfiyat.Text !="")
            {
                IslemKaydet();
                if (DBView.state == true)
                {
                    MessageBox.Show("İşlem Kaydedildi");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("İşlem Kayıt edilirken bir sorun çıktı!");
                }

            }
            else
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurunuz.");
            }
        }

        private void IslemKaydet()
        {
            islem.BirimFiyat = txt_birimfiyat.Text;
            islem.IslemAdi = txt_islemadi.Text;
            islem.Kaydet();
        }

        private void IslemEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
