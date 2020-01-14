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
    public partial class Sorgula : Form
    {
        DBView view = new DBView();
        Common cm = new Common();
        Bitmap bmp;
        Search search;
        public Sorgula()
        {
            InitializeComponent();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            dt_sevk_tarihi.Value = Convert.ToDateTime(DateTime.Now.ToString());
            dt_bitis_tarihi.Value = Convert.ToDateTime(DateTime.Now.ToString());
            dgv_islemler.DataSource = null;
        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            DataTable gelen;
            search = new Search();
            if (rb_tb_olmus.Checked)
            {
                dgv_islemler.DataSource = null;
                gelen = search.TaburcuOlmusHastalar(dt_sevk_tarihi.Value, dt_bitis_tarihi.Value);
                dgv_islemler.DataSource = gelen;
            }
            else if (rb_tb_olmamis.Checked)
            {
                dgv_islemler.DataSource = null;
                gelen = search.TaburcuOlmamisHastalar(dt_sevk_tarihi.Value, dt_bitis_tarihi.Value);
                dgv_islemler.DataSource = gelen;
            }
            else if(rb_hepsi.Checked)
            {
                dgv_islemler.DataSource = null;
                gelen = search.TumHastalar(dt_sevk_tarihi.Value, dt_bitis_tarihi.Value);
                dgv_islemler.DataSource = gelen;
            }
            else
            {
                MessageBox.Show("Lütfen Bir sorgu biçimi işaretleyiniz!");
            }
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 30, 100);
        }

        private void Sorgula_Load(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
