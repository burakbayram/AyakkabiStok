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
    public class MarkaRepository
    {
        public List<Marka> TumMarkalar()
        {
            DataTable dt = DataHelper.TabloGetir("Select * from tblMarkalar");
            List<Marka> liste = new List<Marka>();

            foreach (DataRow item in dt.Rows)
            {
                Marka m = new Marka();
                m.MarkaAdi = item["MarkaAdi"].ToString();
                m.MarkaId = (int)item["MarkaId"];
                liste.Add(m);

            }
            return liste;
        }
        public bool MarkaEkle(Marka yeni, out int id)
        {
            string sql = "insert into tblMarkalar (MarkaAdi) values(@markaAdi)";
            SqlParameter p1 = new SqlParameter("markaAdi", yeni.MarkaAdi);
            bool result = DataHelper.KomutCalistir(sql, p1);
            if (result)
            {
                //Scope_Identity()
                //string sql2 = "Select @@Identity ";
                string sql2 = "select Max(MarkaId) from tblMarkalar";
                DataTable dt = DataHelper.TabloGetir(sql2);
                id = (int)dt.Rows[0][0];
            }
            else
                id = -1;
            return result;
        }
        public bool MarkaSil(int id)
        {
            string sql = "Delete from tblMarkalar where MarkaId=@id";
            SqlParameter p1 = new SqlParameter("id", id);
            return DataHelper.KomutCalistir(sql, p1);
        }

        public bool MarkaGuncelle(Marka yeni)
        {

            string sql = "Update tblMarkalar set MarkaAdi=@markaadi where MarkaId=@id";
            SqlParameter p1 = new SqlParameter("id", yeni.MarkaId);
            SqlParameter p2 = new SqlParameter("markaadi", yeni.MarkaAdi);
            return DataHelper.KomutCalistir(sql, p1, p2);
        }

    }
}
