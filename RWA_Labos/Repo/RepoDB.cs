using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using Microsoft.ApplicationBlocks.Data;
using Serenity.Data;
using SqlHelper = Microsoft.ApplicationBlocks.Data.SqlHelper;

namespace RWA_Labos.Repo
{
    public class RepoDB : IBaseSelector
    {
        //izbvlacimo iz webconfiga
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public RepoDB()
        {
        }

        public void AddUser(string name, string lastname, string phone, string password, string city, string role, string email)
        {
            SqlHelper.ExecuteNonQuery(cs, "AddUser" ,name, lastname, phone, password, city, role, email);
        }

        public void DeleteUser(int id)
        {
            SqlHelper.ExecuteNonQuery(cs, "DeleteUser", id);
        }

        //web config - centralno mjesto za pohranu
        public List<User> GetAllUsers()
        {

            List<User> users = new List<User>();

            //nadji sqlelper u nugget packagima microsoft 
            DataSet dsUsers = SqlHelper.ExecuteDataset(cs, "GetUsers");
            //nezovi proceduru kako smo nazvali metodu
            //KUHARICA SPRANCA CESLJANJE PODATAKA OD STRANE SQL HELPERA TOE TO
            foreach (DataRow row in dsUsers.Tables[0].Rows)//dataset je kolekcija tablica, imat ce onoliko tablica koliko ima select upita
                                                      //u nasem slucaju jedan, u slucaju vise slectova imali bi vise tablica
            {
                int ID = (int)row["IDUser"];
                User user = new User();
                user.IDUser = ID;
                user.Firstname = row["Firstname"].ToString();
                user.Lastname = row["Lastname"].ToString();
                user.Phone = row["Phone"].ToString();
                user.City = row["City"].ToString();
                user.Role = row["Role"].ToString();
                user.Password = row["Password"].ToString();
                user.Email = row["Email"].ToString();

                users.Add(user);
            }
            return users;

        }

        public void UpdateUser(int userId, string name, string lastname, string phone, string password, string city, string role, string email)
        {
            SqlHelper.ExecuteNonQuery(cs, "UpdateUser", userId, name, lastname, phone, password, city, role, email);
        }


        ////ova metoda od nas zahtjeva drzavaid tako smo u bazi sql naveli
        //public IEnumerable<Grad> GetGradovi(int drzavaId)
        //{
        //    DataSet ds = SqlHelper.ExecuteDataset(cs, "GetGradovi", drzavaId);

        //    foreach (DataRow row in ds.Tables[0].Rows)
        //    {
        //        Grad g = new Grad();
        //        g.IDGrad = (int)row["IDGrad"];
        //        g.Naziv = row["Naziv"].ToString();
        //        g.DrzavaID = (int)row["Drzavaid"];

        //        yield return g;//interno napravi ienumerable gradova i kod yield return filla tu kolekciju s obzirom na vrijednosti 
        //        //samo skraceni kod da nemoramo raditi list collections unutar koda
        //    }
        //}
        ////tipa ako vrati vece od 0 proslo je ok, ako ne mozes ispisati update nije proso
        //public int UpdateGrad(int gradId, string naziv)
        //{
        //    //connection string, ime procedure, parametri koje procedura trazi
        //    return SqlHelper.ExecuteNonQuery(cs, "UpdateGrad", gradId, naziv);
        //}
    }
}