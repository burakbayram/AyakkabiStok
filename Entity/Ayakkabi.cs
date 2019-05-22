using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public enum Cins
    {
        Diger, Süet, Deri
    }
    public enum Cinsiyet
    {
        Unisex,
        Kadin,
        Erkek
    }
    public class Ayakkabi
    {
        public int Id { get; set; }
        
        public Marka Marka { get; set; }//Marka string yerine marka aldık veri tutatsızlıgı olmasın fdiye
        public string Model { get; set; }
        public Cins Cins { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        //foreighkey olablir
        public int MarkaId { get; set; }
        public string ListBoxGosterim
        {
            get
            {
                return Marka.MarkaAdi + " " + Model;
            }
        }
    }
}
