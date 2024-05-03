using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using metiers;
namespace daoSqlServer14
{
    public class BDLHopital
    {
        public static DataSet dsHopital = new DataSet();

        public static DataTable ChargerService()                  
        {
            DataTable dt=null;
            SqlConnection cnx = ConnexionHopital.GetInstance();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from service", cnx);

                da.Fill(dsHopital, "TLService");

                dt = dsHopital.Tables["TLService"];
                cnx.Close();
               
            }
            catch (Exception ex)
            { MessageBox.Show("Pb  charger Service " + ex.Message); }
            return dt;
        }
        public static DataTable ChargerMedecin()
        {
            DataTable dt;
            SqlConnection cnx = ConnexionHopital.GetInstance();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from medecin", cnx);

                da.Fill(dsHopital, "TLMedecin");

                dt = dsHopital.Tables["TLMedecin"];
                cnx.Close();

                return dt;
            }
            catch (Exception ex)
            { MessageBox.Show("Pb  charger Medecin " + ex.Message); }
            return null;
        }
        public static DataTable ChargerAffectationService()
        {
            DataTable dt;
            SqlConnection cnx = ConnexionHopital.GetInstance();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from affectation_service", cnx);

                da.Fill(dsHopital, "TLAffectationService");

                dt = dsHopital.Tables["TLAffectationService"];
                cnx.Close();
                return dt;
            }
            catch (Exception ex)
            { MessageBox.Show("Pb  charger Affectation Service " + ex.Message); }
            return null;
        }
        

        public static void AddService(Service s)
        {
            DataTable dtSer = dsHopital.Tables["TLService"];

            DataRow ligne = dtSer.NewRow();
            ligne[0] = s.Nom;
            ligne[1] = s.NbreLits;
            ligne[2] = s.ChefServ.Cin;
            dtSer.Rows.Add(ligne);



        }
        public static void AddMedecin(Medecin m)
        {
            DataTable dtMed = dsHopital.Tables["TLMedecin"];

            DataRow ligne = dtMed.NewRow();
            ligne[0] = m.Cin;
            ligne[1] = m.Prenom;
            ligne[2] = m.Nom;
            ligne[3] = m.DateNaissance;
            ligne[4] = m.Adresse;
            dtMed.Rows.Add(ligne);
         }

        public static bool UpdateService(Service s)
        {
            DataTable dtSer = dsHopital.Tables["TLService"];

            foreach (DataRow r in dtSer.Rows)
            {
                if (r[0].ToString().Equals(s.Nom))
                {
                    r[1] = s.NbreLits;
                    r[2] = s.ChefServ.Cin;
                    
                    return true;
                }
            }
            return false;
            //Autre Méthode pour parcourir les Lignes DataRow d'une DataTable            
            /* IEnumerable<DataRow> query = dtSer.AsEnumerable();
            foreach (DataRow r in query)
            {
                if (r[0].Equals(s.Nom))
                {
                    r[1] = s.NbreLits;
                    r[2] = s.ChefServ.Cin;
                }
            */

        }

        //*****  Méthode pour charger --plusieurs tables-- en utilisant la même DataAdapter/
        //** Mais de préférence il ne faut pas charger toute la BD dans la RAM/
      public static DataSet ChargerHopital()
      {
          SqlConnection cnx = ConnexionHopital.GetInstance();
          SqlDataAdapter da = new SqlDataAdapter("select * from medecin", cnx);
          try
          { da.Fill(dsHopital, "TLMedecin");

            //Charger une autre table

            da.SelectCommand.CommandText = "select * from service";
            da.Fill(dsHopital, "TLService");


            //2eme methode pour charger une autre table 

            // bdHopital.Tables.Add("TVAffectationService");
            da.SelectCommand.CommandText = "select * from affectation_service";
            da.Fill(dsHopital, "TLAffectationService");
            cnx.Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Pb de charger trois table pour la GRH  " + ex.Message); }
            
            return dsHopital;
        }

        public static int EnregistrerService()
        {
            SqlConnection cnx = ConnexionHopital.GetInstance();
            int nbLig = 0;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Service", cnx);
                SqlCommandBuilder dcb = new SqlCommandBuilder(da);
                nbLig = da.Update(dsHopital, "TLService");
                cnx.Close();

            }
            catch (Exception ex)
            { MessageBox.Show("Pb sauvegarde  Service " + ex.Message); }
            return nbLig;
        }
        public static int EnregistrerMedecin()
        {
            SqlConnection cnx = ConnexionHopital.GetInstance();
            int nbLig = 0;
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from medecin", cnx);
                SqlCommandBuilder dcb = new SqlCommandBuilder(da);
                nbLig = da.Update(dsHopital, "TLMedecin");
                cnx.Close();

            }
            catch (Exception ex)
            { MessageBox.Show("Pb sauvegarde  Medecin " + ex.Message); }
            return nbLig;
        }

    }
}
