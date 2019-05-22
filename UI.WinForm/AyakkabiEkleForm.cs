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
    public partial class AyakkabiEkleForm : Form
    {
        MarkaRepository markaRep = new MarkaRepository();
        AyakkabiRepository ayakkabiRep = new AyakkabiRepository();
        public AyakkabiEkleForm()
        {
            InitializeComponent();
        }

        private void AyakkabiEkleForm_Load(object sender, EventArgs e)
        {
            cbMarka.DisplayMember = "MarkaAdi";
            cbMarka.ValueMember = "MarkaId";
            cbMarka.DataSource = markaRep.TumMarkalar();
            Type t = typeof(Cins);
            string[] secenekler = Enum.GetNames(t);
            cbCins.DataSource = secenekler;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Ayakkabi a = new Ayakkabi();
            a.MarkaId = (int)cbMarka.SelectedValue;
            a.Model = txtModel.Text;
            a.Cins =(Cins) cbCins.SelectedIndex;
            a.Cinsiyet = rbKadin.Checked ? Cinsiyet.Kadin: rbErkek.Checked ? Cinsiyet.Erkek:Cinsiyet.Unisex;


           bool result= ayakkabiRep.AyakkabiEkle(a);
            if (result)
            {
                AyakkabilarForm f = (AyakkabilarForm)FormHelper.Create(typeof(AyakkabilarForm));
                f.Yenile();
                MessageBox.Show("Kaydedildi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Hata Olustu");
            }
        }
    }
}
