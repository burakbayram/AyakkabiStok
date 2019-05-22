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
    public partial class StokHareketForm : Form
    {
        MarkaRepository markaRep = new MarkaRepository();
        AyakkabiRepository ayakkabiRep = new AyakkabiRepository();
        public StokHareketForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbCıkısStok_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StokHareketForm_Load(object sender, EventArgs e)
        {
            cbMarkaStok.ValueMember = "MarkaId";//Sql le gerek yok 
            cbMarkaStok.DisplayMember = "MarkaAdi";//clasta yazılan onemli
            cbMarkaStok.DataSource = markaRep.TumMarkalar();
        }

        private void cbMarkaStok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMarkaStok.SelectedItem != null)
            {
                cbAyakabiStok.DisplayMember = "Model";
                cbAyakabiStok.ValueMember = "Id";
                cbAyakabiStok.DataSource = ayakkabiRep.MarkayaGoreGetir((int)cbMarkaStok.SelectedValue);

            }
        }

        StokManager mng = new StokManager();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            StokHareketViewModel vm = new StokHareketViewModel();
            vm.AyakkabiId = (int)cbAyakabiStok.SelectedValue;
            vm.Adet = (int)nupAdetStok.Value;
            vm.No = (byte)nupNumaraStok.Value;
            vm.Tip = rbGirisStok.Checked ? StokHareketIslemTipi.Giris : StokHareketIslemTipi.Cikis;
            bool olduMu = mng.StokHareketiOlustur(vm);
            if (olduMu)
            {
                MessageBox.Show("kaydedidi");
            }
            else MessageBox.Show("Bir hata olustu");
        }
    }
}
