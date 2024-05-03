using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using metiers;
using System.Data.SqlClient;

namespace daoSqlServer14
{
    public class ServiceDAO
    {
        SqlConnection cnx; //on appele ConnexionHopital.GetInstance(); avant chaque requête dans les méthodes, 
                             //on appele cnx.Close(); à la fin du traitement
        public List<Service> FindAll()
        {
            List<Service> res = new List<Service>();
           MedecinDAO bdMed = new MedecinDAO();//pour trouver le Medecin selon cin du chefSevice
           List<Medecin> medecins = bdMed.FindAll();
            Medecin m = null;

            try
            {
               cnx=ConnexionHopital.GetInstance();

                SqlCommand cmd = new SqlCommand("select * from Service", cnx);
                SqlDataReader reader = cmd.ExecuteReader();
             
                while (reader.Read())
                {
                    //chercher Medecin
                        foreach (Medecin med in medecins)
                             if (med.Cin.Equals(reader.GetString(2)))
                             { m = med; break; }
                      
                    
                    Service s = new Service(reader.GetString(0), reader.GetInt32(1), m);
                    res.Add(s);
                }
              cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Service : Pb de FindAll \n " + ex.Message, "Attention");
            }
            return res;
        }
        public Service Find(String nom)
        {   //pour trouver le Medecin selon cin du chefService
            MedecinDAO bdMed = new MedecinDAO();
             List<Medecin> medecins = bdMed.FindAll();

            Medecin m = null;
            Service s = null;
            try {

                cnx = ConnexionHopital.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from Service where nom=@nom", cnx);
                cmd.Parameters.Add("@nom", nom);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //chercher Medecin selon cin 
                    foreach (Medecin med in medecins)
                        if (med.Cin.Equals(reader.GetString(2)))
                        { m = med; break; }

                    //s = new Service(reader.GetString("nom"), reader.GetInt32(1), m);
                    s = new Service(reader.GetString(0), reader.GetInt32(1), m);
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requete recherche Service \n " + ex.Message, "Attention");
            }
            return s;
        }
        public void Remove(Service s)
        {
            try
            {
                cnx = ConnexionHopital.GetInstance();//ouvrir la connexion
                SqlCommand cmd = new SqlCommand("delete from Service where nom=@nom", cnx);
                cmd.Parameters.Add("@nom", s.Nom);//
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Service supprimer avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Service : Remove \n " + ex.Message, "Attension");
            }

        }
        public void Add(Service s)
        {
            try
            {
                cnx = ConnexionHopital.GetInstance();//ouvrir la connexion
                SqlCommand cmd = new SqlCommand("insert into Service values(@nom, @lit, @cin)", cnx);
                cmd.Parameters.Add("@nom", s.Nom);//
                cmd.Parameters.Add("@lit", s.NbreLits);
                cmd.Parameters.Add("@cin", s.ChefServ.Cin);
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Service est ajouté avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Service : Add \n " + ex.Message, "Attention");
            }

        }
        public void Update(Service s)
        {
            try
            {
                cnx = ConnexionHopital.GetInstance();//ouvrir la connexion
                SqlCommand cmd = new SqlCommand("update service set  nom=@nom, nblits=@nb, chefser=@chef where nom=@nom", cnx);
                
                cmd.Parameters.Add("@nom", s.Nom);//
                cmd.Parameters.Add("@nb", s.NbreLits);//
                cmd.Parameters.Add("@chef", s.ChefServ.Cin);//
                

                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Service est modifié avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Service : Update\n " + ex.Message, "Attention");
            }

        }

    }
}
