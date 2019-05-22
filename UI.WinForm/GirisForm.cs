using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.WinForm
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void markalarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //       MarkalarForm m = new MarkalarForm();
            Form m = Application.OpenForms["MarkalarForm"];
            if (m == null)
            {
                m = new MarkalarForm();
            }
            // Singeloton kullnancagzı


            m.MdiParent = this;
            m.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //  MarkaEkleForm m = new MarkaEkleForm();
            //Form m = Application.OpenForms["MarkaEkleForm"];
            //if (m == null)
            //{
            //    m = new MarkaEkleForm();
            //}
            Form m = FormHelper.Create(typeof(MarkaEkleForm));
            m.MdiParent = this;
            m.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //Form m = Application.OpenForms["AyakkabiEkleForm"];
            //if (m == null)
            //{
            //    m = new AyakkabiEkleForm();
            //}

            //method hali
            Form m = FormHelper.Create(typeof(AyakkabiEkleForm));
            m.MdiParent = this;
            m.Show();
        }

        private void ayakkabılarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormHelper.Create(typeof(AyakkabilarForm));
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form f = FormHelper.Create(typeof(StokHareketForm));
            f.MdiParent = this;
            f.Show();
        }

        private void stokHareketiOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = FormHelper.Create(typeof(StokHareketForm));
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Form f = FormHelper.Create(typeof(Envanter));
            f.MdiParent = this;
            f.Show();
        }
    }
}
