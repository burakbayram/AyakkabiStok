using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Stok
    {
        public int Id { get; set; }

        public int AyakkabiId { get; set; }
        public string MarkaAdi { get; set; }
        public string Model { get; set; }

        public int Adet { get; set; }
        public byte No { get; set; }
    }
}
