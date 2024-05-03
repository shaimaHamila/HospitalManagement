using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace dao
{
    public class ConnexionHopital
    {

        static String chaineCnx = "SERVER=127.0.0.1; DATABASE=BDHopital; uid=sa; password=pass;";
        static MySqlConnection cnx = new MySqlConnection(chaineCnx);
        public static MySqlConnection GetInstance()
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
