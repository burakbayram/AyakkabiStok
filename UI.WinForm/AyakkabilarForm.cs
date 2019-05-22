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
    public partial class AyakkabilarForm : Form
    {
        AyakkabiRepository rep = new AyakkabiRepository();
        public AyakkabilarForm()
        {
            InitializeComponent();
        }
        public void Yenile()
        {
            listBox1.DataSource = null;

            listBox1.DisplayMember = "ListBoxGosterim";//"Model";
            listBox1.DataSource = rep.TumAyakkabilar();
        }

        private void AyakkabilarForm_Load(object sender, EventArgs e)
        {
            Yenile();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                groupBox1.Visible = true;
                Ayakkabi a =(Ayakkabi)listBox1.SelectedItem;
                lbl_Cins.Text = a.Cins.ToString();
                lbl_Cinsiyet.Text = a.Cinsiyet.ToString();
                lbl_Model.Text = a.Model;
                lbl_Marka.Text = a.Marka.MarkaAdi;

            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            //AyakkabiRepository rep = new AyakkabiRepository();
            //Ayakkabi a = new Ayakkabi();
            //a = (Ayakkabi)listBox1.SelectedItem;
        //    rep.AyakkabiSil(a.Id);
            int id = ((Ayakkabi)listBox1.SelectedItem).Id;
            if (rep.AyakkabiSil(id))
            {
                Yenile();
                groupBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Hata ");
            }
     
            
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                AyakkabiDuzenleForm f = (AyakkabiDuzenleForm)FormHelper.Create(typeof(AyakkabiDuzenleForm));
                f.ayakkabi = (Ayakkabi)listBox1.SelectedItem;
                f.Show();
            }
            else MessageBox.Show("Ayakakbi seciniz");
        }
    }
}
