using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.WinForm
{
    public class MarkaLabel : Label
    {

        public int MarkaId { get; set; }
        private bool _seciliMi;

        public MarkaLabel()
        {
     
            Width = 250;
            Height = 50;
            Margin = new Padding(10);
            BackColor = Color.CadetBlue;
            Font = new Font(FontFamily.GenericSansSerif, 22f);
        }
        public bool SeciliMi
        {
            get { return _seciliMi; }
            set
            {
                if (value)
                    this.BackColor = Color.Yellow;
                else
                {
                    this.BackColor = SystemColors.Control;
                }
                _seciliMi = value;
            }
        }
        protected override void OnClick(EventArgs e)
        {
            this.SeciliMi = !SeciliMi;
            base.OnClick(e);

        }

    }
}
