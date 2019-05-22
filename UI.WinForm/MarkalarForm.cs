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
    public partial class MarkalarForm : Form
    {
        Marka seciliMarka = null;
        MarkaLabel seciliLabel = null;
        public MarkalarForm()
        {
            InitializeComponent();
        }
        public void  MarkaLabelEkle(MarkaLabel lbl)
        {
            lbl.Click += MarkaClick;
            flowLayoutPanel1.Controls.Add(lbl);
        }
        private void MarkalarForm_Load(object sender, EventArgs e)
        {
            MarkaRepository rep = new MarkaRepository();

            List<Marka> hepsi = rep.TumMarkalar();
            foreach (var item in hepsi)
            {
                MarkaLabel lbl = new MarkaLabel();
                lbl.MarkaId = item.MarkaId;
                lbl.Text = item.MarkaAdi;
                lbl.Click += MarkaClick;
                flowLayoutPanel1.Controls.Add(lbl);
            }


        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MarkaRepository rep = new MarkaRepository();
            rep.MarkaSil(seciliMarka.MarkaId);
            flowLayoutPanel1.Controls.Remove(seciliLabel);


        }


        public void MarkaClick(object sender, EventArgs e)
        {
            foreach (MarkaLabel item in flowLayoutPanel1.Controls)
            {
                item.SeciliMi = false;
            }
            MarkaLabel tiklanan = (MarkaLabel)sender;
            seciliLabel = tiklanan;

      //      tiklanan.SeciliMi = true; ///Markalabel da overide ederek farklı davranmasını saglamak
            seciliMarka = new Marka()
            {
                MarkaId = tiklanan.MarkaId,
                MarkaAdi = tiklanan.Text

            };

            txtbxMarkaDuzenleKaydet.Text = seciliLabel.Text;
            //MessageBox.Show("tıklandi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (seciliLabel == null)
            {

                MessageBox.Show("Marka Seciniz");
                return;
            }
            panel1.Visible = true;
            txtbxMarkaDuzenleKaydet.Text = seciliLabel.Text;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MarkaRepository rep = new MarkaRepository();
            seciliMarka.MarkaAdi = txtbxMarkaDuzenleKaydet.Text;
            if (rep.MarkaGuncelle(seciliMarka))
            {
                seciliLabel.Text = txtbxMarkaDuzenleKaydet.Text;
                MessageBox.Show("Güncellendi");
            }
            else
            {
                MessageBox.Show("Bir hata olustu");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
