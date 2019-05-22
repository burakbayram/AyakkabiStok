using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StokManager
    {
        //veri tasırken parmetre degilde class olusturup yollamak dha mantıklı
        //Bunuda WivweModel diyoruz
        public bool StokHareketiOlustur(StokHareketViewModel s)
        {
            SqlParameter p1 = new SqlParameter("aid", s.AyakkabiId);
            SqlParameter p2 = new SqlParameter("adet", s.Adet);
            SqlParameter p3 = new SqlParameter("no", s.No);
            SqlParameter p4 = new SqlParameter("tip", s.Tip);



            string sql = "exec StokHareketOlustur @aid,@no,@adet,@tip";
            return DataHelper.KomutCalistir(sql, p1, p2, p3, p4);


        }
        public List<Stok> EnvanterRapor()
        {
            //@ gormezden geiyor alt gecince
            List<Stok> liste = new List<Stok>();
            string sql = @"Select s.*,a.Model,m.MarkaAdi from tblStok s inner join
tblAyakkabi a on s.AyakkabiId=a.Id inner join tblMarkalar m on a.MarkaId=m.MarkaId Order by AyakkabiId,No";

            DataTable dt = DataHelper.TabloGetir(sql);
            foreach(DataRow item in dt.Rows)
            {
                Stok s = new Stok();
                s.Adet = (int)item["Adet"];
                s.AyakkabiId = (int)item["AyakkabiId"];
                s.No = (byte)item["No"];
                s.Id = (int)item["Id"];
                s.Model = item["Model"].ToString();
                s.MarkaAdi = item["MarkaAdi"].ToString();
                liste.Add(s);
            }
            return liste;
        }
    }
}
