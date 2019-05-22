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
    public class AyakkabiRepository
    {

        public List<Ayakkabi> TumAyakkabilar()
        {

            List<Ayakkabi> liste = new List<Ayakkabi>();
            string sql = @"select a.*,MarkaAdi from tblAyakkabi a inner join
                    tblMarkalar m on m.MarkaId = a.MarkaId";
            DataTable tbl = DataHelper.TabloGetir(sql);
            foreach (DataRow item in tbl.Rows)
            {
                Ayakkabi a = new Ayakkabi();
                a.MarkaId = (int)item["MarkaId"];
                a.Cins = (Cins)(int)item["Cins"];
                a.Cinsiyet = (Cinsiyet)(int)item["Cinsiyet"];
                a.Id = (int)item["Id"];
                a.Model = item["Model"].ToString();
                a.Marka = new Marka();
                a.Marka.MarkaId = (int)item["MarkaId"];
                a.Marka.MarkaAdi = item["MarkaAdi"].ToString();
                liste.Add(a);


            }

            return liste;

        }

        public bool AyakkabiEkle(Ayakkabi yeni)
        {

            string sql = "insert into tblAyakkabi (MarkaId,Model,Cinsiyet,Cins) values(@MarkaId,@Model,@Cinsiyet,@Cins)";
            SqlParameter p1 = new SqlParameter("MarkaId", yeni.MarkaId);
            SqlParameter p2 = new SqlParameter("Model", yeni.Model);
            SqlParameter p3 = new SqlParameter("Cinsiyet", yeni.Cinsiyet);
            SqlParameter p4 = new SqlParameter("Cins", yeni.Cins);
            bool result = DataHelper.KomutCalistir(sql, p1, p2, p3, p4);

            if (result)
            {

            }
            else
            {

            }

            return result;
        }
        public bool AyakkabiSil(int id)
        {
            string sql = "Delete from tblAyakkabi where Id=@id";
            SqlParameter p1 = new SqlParameter("id", id);
            return DataHelper.KomutCalistir(sql, p1);
        }
        public bool AyakkkabiGuncelle(Ayakkabi yeni)
        {
            string sql = "Update tblAyakkabi set MarkaId=@MarkaId,Model=@Model,Cinsiyet=@Cinsiyet,Cins=@Cins " +
                "where Id=@Id";

            SqlParameter p1 = new SqlParameter("MarkaId", yeni.MarkaId);
            SqlParameter p2 = new SqlParameter("Model", yeni.Model);
            SqlParameter p3 = new SqlParameter("Cinsiyet", yeni.Cinsiyet);
            SqlParameter p4 = new SqlParameter("Cins", yeni.Cins);
            SqlParameter p5 = new SqlParameter("Id", yeni.Id);

            return DataHelper.KomutCalistir(sql, p1, p2, p3, p4, p5);

        }
        public List<Ayakkabi> MarkayaGoreGetir(int markaId)
        {
          //  string sql = "Select * from tblAyakkabi where MarkaId=@id";
            string sql = "Select * from tblAyakkabi where MarkaId="+markaId;
        //    SqlParameter p1 = new SqlParameter("id", markaId);
            List<Ayakkabi> liste = new List<Ayakkabi>();
            DataTable tbl = DataHelper.TabloGetir(sql);
            foreach (DataRow item in tbl.Rows)
            {
                Ayakkabi a = new Ayakkabi();
                a.MarkaId = (int)item["MarkaId"];
                a.Cins = (Cins)(int)item["Cins"];
                a.Cinsiyet = (Cinsiyet)(int)item["Cinsiyet"];
                a.Id = (int)item["Id"];
                a.Model = item["Model"].ToString();
                //a.Marka = new Marka();
                //a.Marka.MarkaId = (int)item["MarkaId"];
                //a.Marka.MarkaAdi = item["MarkaAdi"].ToString();
                liste.Add(a);


            }
            return liste;
        }

    }
}
