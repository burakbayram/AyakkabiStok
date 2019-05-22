using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class StokHareketViewModel
    {

        public int AyakkabiId { get; set; }
        public int Adet { get; set; }
        public byte No { get; set; }
        public StokHareketIslemTipi Tip { get; set; }
    }

    public enum StokHareketIslemTipi
    {
        Cikis, Giris
    }
}
