using BLL;
using Entity;
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
    public partial class MarkaEkleForm : Form
    {
        public MarkaEkleForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Marka m = new Marka() {
                MarkaAdi = txtmarkaAd.Text
            };
            MarkaRepository rep = new MarkaRepository();
            int mid = 0;
            bool result= rep.MarkaEkle(m,out mid);
            if (result == true)
            {
                MarkaLabel lbl = new MarkaLabel();
                lbl.Text = txtmarkaAd.Text;
                lbl.MarkaId = mid;

                MarkalarForm f = (MarkalarForm)Application.OpenForms["MarkalarForm"];
                if (f != null)
                {
                    f.MarkaLabelEkle(lbl);
                }
                txtmarkaAd.Clear();
                MessageBox.Show("Eklendi");
            }
            else
            {
                MessageBox.Show("hata olustu");
            }
        }
    }
}
