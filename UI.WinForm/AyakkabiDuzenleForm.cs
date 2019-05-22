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
    public partial class AyakkabiDuzenleForm : Form
    {
        MarkaRepository markaRep = new MarkaRepository();
        AyakkabiRepository ayakkabiRep = new AyakkabiRepository();
        public Ayakkabi ayakkabi;
        public AyakkabiDuzenleForm()
        {
            InitializeComponent();
        }

        private void AyakkabiDuzenleForm_Load(object sender, EventArgs e)
        {
            cbMarka.DisplayMember = "MarkaAdi";
            cbMarka.ValueMember = "MarkaId";
            cbMarka.DataSource = markaRep.TumMarkalar();
            Type t = typeof(Cins);
            string[] secenekler = Enum.GetNames(t);
            cbCins.DataSource = secenekler;

            cbMarka.SelectedValue = ayakkabi.MarkaId;
            cbCins.SelectedIndex = (int)ayakkabi.Cins;
            txtModel.Text = ayakkabi.Model;

            rbKadin.Checked = ayakkabi.Cinsiyet == Cinsiyet.Kadin ? true : false;
            rbErkek.Checked = ayakkabi.Cinsiyet == Cinsiyet.Erkek;
            rbUnisex.Checked = ayakkabi.Cinsiyet == Cinsiyet.Unisex;
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
           Ayakkabi sonHali = new Ayakkabi();
           // AyakkabiRepository rep = new AyakkabiRepository();
            sonHali.Model = txtModel.Text;
            sonHali.Cins = (Cins)cbCins.SelectedIndex;
            sonHali.Cinsiyet = rbErkek.Checked ? Cinsiyet.Erkek : rbKadin.Checked ? Cinsiyet.Kadin : Cinsiyet.Unisex;
            sonHali.MarkaId = (int)cbMarka.SelectedValue;
   
            sonHali.Id = ayakkabi.Id;
            bool olduMu = ayakkabiRep.AyakkkabiGuncelle(sonHali);
            if (olduMu)
            {
                AyakkabilarForm f = (AyakkabilarForm)FormHelper.Create(typeof(AyakkabilarForm));
                f.Yenile();
                MessageBox.Show("Güncellendi");
            }
            else
            {
                MessageBox.Show("Bir hata olustu");
            }
        }
    }
}
