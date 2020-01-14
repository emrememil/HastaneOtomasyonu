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
    public partial class PoliklinikTanitma : Form
    {
        public PoliklinikTanitma()
        {
            InitializeComponent();
        }
        Common cm = new Common();
        DBView view = new DBView();
        Poliklinik poliklinik = new Poliklinik();
        private void PoliklinikTanitma_Load(object sender, EventArgs e)
        {
            DataTable table = poliklinik.TumPoliklinikler();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cb_poliklik_adi.Items.Add(table.Rows[i]["poliklinikadi"].ToString());
            }
        }

        private void cbox_gecerli_gecersiz_CheckedChanged(object sender, EventArgs e)
        {
            cb_poliklik_adi.Items.Clear();
            DataTable table = poliklinik.GecerliGecersizPoliklinikler(cbox_gecerli_gecersiz.Checked);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                cb_poliklik_adi.Items.Add(table.Rows[i]["poliklinikadi"].ToString());
            }
        }

        private void btn_yeni_pol_Click(object sender, EventArgs e)
        {
            PoliklinikTanitmaAyrinti.polAdi = "";
            ((Form1)this.MdiParent).FormAc(new PoliklinikTanitmaAyrinti());
            this.Close();
        }

        private void cb_poliklik_adi_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void cb_poliklik_adi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                PoliklinikTanitmaAyrinti.polAdi = cb_poliklik_adi.SelectedItem.ToString();
                ((Form1)this.MdiParent).FormAc(new PoliklinikTanitmaAyrinti());
                this.Close();
            }
        }
    }
}
