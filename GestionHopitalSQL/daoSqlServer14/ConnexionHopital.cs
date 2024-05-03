using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using MySql.Data.MySqlClient;
namespace daoSqlServer14
{
    public class ConnexionHopital
    {

        //static String chaineCnx = "SERVER=127.0.0.1; DATABASE=bdhopital; uid=root; password=;";
        static String chaineCnx = "Data Source=DESKTOP-6CKF5EA;Initial Catalog=BDHopital;Integrated Security=True;";
        static SqlConnection cnx = new SqlConnection(chaineCnx);
        public static SqlConnection GetInstance()
        {
            try
            {
                if (cnx.State != System.Data.ConnectionState.Open)
                    cnx.Open();
            }
            catch (Exception ex) { MessageBox.Show("Hopital : Pb de connexion\n " + ex.Message); }

            return cnx;
        }

        public void Close()
        {
            cnx.Close();

        }
    }
}
