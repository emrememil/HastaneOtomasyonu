using HastaneOtomasyon.ClassModels;
using HastaneOtomasyon.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class HastaIslemleri : Form
    {
        public HastaIslemleri()
        {
            InitializeComponent();
        }

        DBView view = new DBView();
        Common cm = new Common();
        Sevk sevk = new Sevk();
        Cikis cikis = new Cikis();
        Hasta hasta = new Hasta();
        int dosyaNo=0;
        public DataGridView dgv;
        Bitmap bmp;
        private void btn_hasta_bilgileri_Click(object sender, EventArgs e)
        {
            if (txt_dosyano.Text!="")
            {
                dosyaNo = Convert.ToInt32(txt_dosyano.Text);
                HastaBilgileri.dosyaNo = dosyaNo;
                ((Form1)this.MdiParent).FormAc(new HastaBilgileri());
            }
            else
            {
                HastaBilgileri.dosyaNo = 0;
                ((Form1)this.MdiParent).FormAc(new HastaBilgileri());

            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            dgv_islemler.DataSource = null;
            if (txt_dosyano.Text == "")
            {
                ((Form1)this.MdiParent).FormAc(new DosyaBul());
            }
            else
            {
                cb_onceki_islemler.Items.Clear();
                cb_onceki_islemler.Text = "";
                HastaBul();
                siraNumarasiVer();
            }
        }

        private void siraNumarasiVer()
        {
            Random random = new Random();
            txt_sira.Text = random.Next(1, 45).ToString();
        }

        private void HastaBul()
        {
            DataTable dt = hasta.HastaBul(txt_dosyano.Text.ToString());
            if (dt.Rows.Count>0)
            {
                txt_dosyano.Text = dt.Rows[0]["dosyano"].ToString();
                txt_hasta_adi.Text = dt.Rows[0]["ad"].ToString();
                txt_hasta_soyadi.Text = dt.Rows[0]["soyad"].ToString();
                txt_kurum_adi.Text = dt.Rows[0]["kurumadi"].ToString();
                OncekiIslemleriYukle();
            }
            else
            {
                MessageBox.Show("Girilen Dosya Numarasına Göre Hasta Bulunamamıştır!");
                InputlariTemizle();
            }

        }

        private void OncekiIslemleriYukle()
        {
            cb_onceki_islemler.Items.Clear();
            DataTable table = hasta.OncekiIslemleriYukle(txt_dosyano.Text.ToString()); ;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cb_onceki_islemler.Items.Add(table.Rows[i]["sevktarihi"].ToString());
                cb_onceki_islemler.SelectedItem = (table.Rows[i]["sevktarihi"].ToString());
            }

        }

        private void HastaIslemleri_Load(object sender, EventArgs e)
        {
            InputlariTemizle();
            PoliklinikleriYukle();
            DoktorlariYukle();
            IslemleriYukle();
        }

        private void IslemleriYukle()
        {
            DataTable table = hasta.IslemleriGetir();
            if (table.Rows.Count != 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    cb_yapilan_islem.Items.Add(table.Rows[i]["islemadi"].ToString());
                }
            }
            else
            {
                MessageBox.Show("İşlemler veritabanından çekilemedi");
            }
        }

        private void DoktorlariYukle()
        {
            DataTable table = hasta.DoktorlariGetir();
            if (table.Rows.Count != 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    cb_drkodu.Items.Add(table.Rows[i]["kodu"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Doktor Bulunamadı!");
            }
          
        }

        private void PoliklinikleriYukle()
        {
            DataTable gelen = hasta.PoliklinikleriGetir();
            if (gelen.Rows.Count != 0)
            {
                for (int i = 0; i < gelen.Rows.Count; i++)
                {
                    cb_poliklinikler.Items.Add(gelen.Rows[i]["poliklinikadi"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Poliklinik Bulunamadı!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_dosyano.Text != "")
            {
                if (cb_yapilan_islem.SelectedItem != "Yeni İşlem")
                {
                    if (cb_drkodu.Text.ToString() != "" && cb_poliklinikler.Text.ToString() != "" && cb_yapilan_islem.Text.ToString() !="" && nup_miktar.Value!=0)
                    {
                        SevkiKaydet();
                        if (DBView.state == true)
                        {
                            dgv_islemler.DataSource = null;
                            DataGridOncekiIslemlerYukle();
                            //OncekiIslemleriYukle();
                        }
                        else
                        {
                            MessageBox.Show("İşlemler kaydedilemedi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen İşlemlerle ilgili tüm alanları doldurunuz!!");
                    }  
                }
                else
                {
                    MessageBox.Show("Lütfen İşlemlerle ilgili tüm alanları doldurunuz!");
                }
               
            }
            else
            {
                MessageBox.Show("Lütfen hastanın dosya numarasını giriniz!");
            }
    
        }

        private void SevkiKaydet()
        {
            sevk.DosyaNo = txt_dosyano.Text;
            sevk.SevkTarihi = dt_sevk_tarihi.Value.ToString("d");
            if (cb_poliklinikler.SelectedItem!=null)
            {
                sevk.Poliklinik = cb_poliklinikler.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Poliklinik Seçilmedi!");
            }
            sevk.Saat = DateTime.Now.ToString("t");
            if (cb_yapilan_islem.SelectedItem != null)
            {
                sevk.YapilanIslem = cb_yapilan_islem.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("İşlem Seçilmedi!");
            }
            if (cb_drkodu.SelectedItem != null)
            {
                sevk.DrKod = cb_drkodu.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Doktor Seçilmedi!");
            }
            sevk.Miktar = nup_miktar.Value.ToString();
            sevk.BirimFiyat = txt_birim_fiyat.Text;
            sevk.Sira = txt_sira.Text;
            sevk.ToplamTutar = lbl_toplam_tutar.Text.ToString();
            sevk.Taburcu = "";
            sevk.SevkEkle();
            

        }

        private void DataGridDosyaNoYukle()
        {
            dgv_islemler.DataSource = null;
            dgv_islemler.DataSource = hasta.DataGridDosyaNoYukle(txt_dosyano.Text.ToString());
        }

        private void cb_yapilan_islem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string islemFiyati = "";
            int birimFiyat;
            if (cb_yapilan_islem.SelectedItem != null && cb_yapilan_islem.SelectedItem.ToString() != "Yeni İşlem")
            {
                DataTable table = hasta.IslemAdi(cb_yapilan_islem.SelectedItem.ToString());
                islemFiyati = table.Rows[0]["birimfiyat"].ToString();
                birimFiyat = Convert.ToInt32(islemFiyati);
                txt_birim_fiyat.Text = (birimFiyat * Convert.ToInt32(nup_miktar.Value)).ToString();
            }
            else if (cb_yapilan_islem.SelectedItem.ToString() == "Yeni İşlem")
            {
                    ((Form1)this.MdiParent).FormAc(new IslemEkle());
            }
        }

        private void nup_miktar_ValueChanged(object sender, EventArgs e)
        {
            string islemFiyati = "";
            int birimFiyat;
            if (cb_yapilan_islem.SelectedItem!=null && cb_yapilan_islem.SelectedItem.ToString() != "Yeni İşlem")
            {
                DataTable table = hasta.IslemAdi(cb_yapilan_islem.SelectedItem.ToString());
                islemFiyati = table.Rows[0]["birimfiyat"].ToString();
                birimFiyat = Convert.ToInt32(islemFiyati);
                txt_birim_fiyat.Text= (birimFiyat.ToString());
            }

        }

        private void btn_git_Click(object sender, EventArgs e)
        {
            if (txt_dosyano.Text!="")
            {
                if (cb_onceki_islemler.SelectedItem != null)
                {

                    DataGridOncekiIslemlerYukle();
                    //DataGridDosyaNoYukle();
                    if (!cikis.TaburcuKontrol(txt_dosyano.Text.ToString(), cb_onceki_islemler.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Hasta bu sevkten taburcu edilmiş!");

                    }
                }
                else
                {
                    MessageBox.Show("Hastanın herhangi bir işlemi bulunmamaktadır. Lütfen bir işlem giriniz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir dosya numarası giriniz!");
            }

        }

        private void DataGridOncekiIslemlerYukle()
        {
            if(cb_onceki_islemler.SelectedItem != null)
            {
                dgv_islemler.DataSource = null;
                DataTable table = hasta.DataGridOncekiIslemler(cb_onceki_islemler.SelectedItem.ToString(), txt_dosyano.Text.ToString());
                dgv_islemler.DataSource = table;
            }
            else
            {
                DataGridDosyaNoYukle();
            }
            int toplam = 0;
            for (int i = 0; i < dgv_islemler.Rows.Count; i++)
            {
                toplam += Convert.ToInt32(dgv_islemler.Rows[i].Cells[6].Value);
            }
            lbl_toplam_tutar.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputlariTemizle();
        }

        private void InputlariTemizle()
        {
            dgv_islemler.DataSource = null;
            txt_birim_fiyat.Text = "";
            txt_hasta_adi.Text = "";
            txt_hasta_soyadi.Text = "";
            txt_kurum_adi.Text = "";
            txt_sira.Text = "";
            cb_drkodu.SelectedItem = null;
            cb_onceki_islemler.SelectedItem = null;
            cb_poliklinikler.SelectedItem = null;
            dt_sevk_tarihi.Value = Convert.ToDateTime(DateTime.Now.ToString("d"));
        }

        private void txt_birim_fiyat_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btn_sec_sil_Click(object sender, EventArgs e)
        {
            if (dgv_islemler.SelectedRows.Count>0)
            {
                string saat="";
                string yapilan_islem="";
                for (int i = 0; i < dgv_islemler.Rows.Count-1; i++)
                {
                    saat = dgv_islemler.Rows[i].Cells[2].Value.ToString();
                    yapilan_islem = dgv_islemler.Rows[i].Cells[3].Value.ToString();
                    
                }
                kayitSil(saat, yapilan_islem);
                if (DBView.state == true)
                {
                    MessageBox.Show("İşlem Başarıyla Silindi");
                    dgv_islemler.DataSource = null;
                    DataGridOncekiIslemlerYukle();

                }
                else
                {
                    MessageBox.Show("İşlemi silme başarısız oldu!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz işlemi seçiniz!");
            }
        }

        private void kayitSil(string saat , string islem)
        {
            sevk = new Sevk();
            if (saat!="" && islem!="")
            {
                sevk.IslemSil(saat, islem);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (txt_dosyano.Text!="" && cb_onceki_islemler.SelectedItem!=null)
            {
                if (!cikis.TaburcuKontrol(txt_dosyano.Text.ToString(),cb_onceki_islemler.SelectedItem.ToString()))
                {
                    MessageBox.Show("Hastanın zaten taburcu işlemleri tamamlanmış!");
                }
                else
                {
                    Taburcu.dosyaNo = txt_dosyano.Text;
                    Taburcu.sevkTarihi = Convert.ToDateTime(cb_onceki_islemler.SelectedItem);
                    Taburcu.tutar = lbl_toplam_tutar.Text;
                    ((Form1)this.MdiParent).FormAc(new Taburcu());
                }
            }
            else
            {
                MessageBox.Show("Lütfen taburcu edilecek hastanın dosya numarasını ve işlemini seçiniz!");
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 30, 100);
            e.Graphics.DrawString("Hasta Sevk İşlemleri : " + txt_hasta_adi.Text + " " + txt_hasta_soyadi.Text + "", new Font("Verdana", 22, FontStyle.Bold), Brushes.Black, new Point(120, 30));
            e.Graphics.DrawString("Dr. : " + RaporDoktorGetir().ToString()+ "", new Font("Verdana", 22, FontStyle.Bold), Brushes.Black, new Point(120, dgv_islemler.Height+30));
           
        }

        private string RaporDoktorGetir()
        {
            string tamisim="";
            string isim;
            string soyisim;

            DataTable gelen = hasta.RaporDoktorGetir(dgv_islemler.Rows[0].Cells[4].Value.ToString());
            if (gelen.Rows.Count>0)
            {
                isim= gelen.Rows[0]["ad"].ToString();
                soyisim= gelen.Rows[0]["soyad"].ToString();
                tamisim = isim +" "+ soyisim;
            }
            else
            {
                MessageBox.Show("Rapora doktor ismi çekilemedi!");
            }
            return tamisim;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgv_islemler.DataSource!=null)
            {
                int height = dgv_islemler.Height;
                dgv_islemler.Height = dgv_islemler.RowCount * dgv_islemler.RowTemplate.Height * 2;
                bmp = new Bitmap(dgv_islemler.Width, dgv_islemler.Height);
                dgv_islemler.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgv_islemler.Width, this.dgv_islemler.Height));
                dgv_islemler.Height = height;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen önce hasta işlemlerini yükleyiniz!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgv_islemler.DataSource != null)
            {
                int height = dgv_islemler.Height;
                dgv_islemler.Height = dgv_islemler.RowCount * dgv_islemler.RowTemplate.Height * 2;
                bmp = new Bitmap(dgv_islemler.Width, dgv_islemler.Height);
                dgv_islemler.DrawToBitmap(bmp, new Rectangle(0, 0, this.dgv_islemler.Width, this.dgv_islemler.Height));
                dgv_islemler.Height = height;
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen önce hasta işlemlerini yükleyiniz!");
            }

        }

        private void dgv_islemler_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgv_islemler.DataSource==null)
            {
                lbl_toplam_tutar.Text = "0";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txt_dosyano_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                dgv_islemler.DataSource = null;
                if (txt_dosyano.Text == "")
                {
                    ((Form1)this.MdiParent).FormAc(new DosyaBul());
                }
                else
                {
                    cb_onceki_islemler.Items.Clear();
                    cb_onceki_islemler.Text = "";
                    HastaBul();
                    siraNumarasiVer();
                }
            }
            
        }
    }
}
