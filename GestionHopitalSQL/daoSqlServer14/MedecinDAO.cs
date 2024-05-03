using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using metiers;
using System.Data.SqlClient;
//using MySql.Data.MySqlClient;

namespace daoSqlServer14
{
    public class MedecinDAO
    {
        SqlConnection cnx; //on appele ConnexionHopital.GetInstance(); avant chaque requête dans les méthodes, 
                             //on appele cnx.Close(); à la fin du traitement

        public List<Medecin> FindAll()
        {
            List<Medecin> res = new List<Medecin>();

            try
            {
                cnx = ConnexionHopital.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from medecin", cnx);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //Medecin m = new Medecin(reader.GetString("cin"), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4));
                    Medecin m = new Medecin(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4));
                    res.Add(m);
                }
             cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Medecin : Pb de FindAll \n " + ex.Message, "Attention");
            }
            return res;
        }
        public Medecin Find(String cin)
        {

            Medecin m = null;
            try
            {
                cnx = ConnexionHopital.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from medecin where cin=@cin", cnx);
                cmd.Parameters.Add("@cin", cin);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    m = new Medecin(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4));

                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Requete recherche Medecin : Find  \n " + ex.Message, "Attention");
            }
            return m;
        }
        public void Remove(Medecin m)
        {
            try
            {
                cnx = ConnexionHopital.GetInstance();
                SqlCommand cmd = new SqlCommand("delete from medecin where cin=@cin", cnx);
                cmd.Parameters.Add("@cin", m.Cin);//
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Medecin supprimer avec succée \n ", "Attention");
               cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de la suppression\n " + ex.Message, "Attention");
            }

        }
        public void Add(Medecin m)
        {
            try
            {
                cnx = ConnexionHopital.GetInstance();
                SqlCommand cmd = new SqlCommand("insert into medecin values(@cin, @prenom, @nom, @nais, @adr)", cnx);
                cmd.Parameters.Add("@cin", m.Cin);//
                cmd.Parameters.Add("@prenom", m.Prenom);
                cmd.Parameters.Add("@nom", m.Nom);
                cmd.Parameters.Add("@nais", m.DateNaissance);
                cmd.Parameters.Add("@adr", m.Adresse);
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Medecin ajouter avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de l'ajout\n " + ex.Message, "Attention");
            }

        }
        public List<Medecin> FindToAdresse(String adresse)
        {

            List<Medecin> res = new List<Medecin>();
            try
            {
                cnx = ConnexionHopital.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from medecin where adresse=@adre", cnx);
                cmd.Parameters.Add("@adre", adresse);//
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Medecin m = new Medecin(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4));
                    res.Add(m);
                }
               cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb d'ouverture de la connexion \n " + ex.Message, "Attention");
            }
            return res;
        }
        public List<Medecin> FindToNom(String nom)
        {

            List<Medecin> res = new List<Medecin>();
            try
            {
                cnx = ConnexionHopital.GetInstance();
                SqlCommand cmd = new SqlCommand("select * from medecin where nom=@nom", cnx);
                cmd.Parameters.Add("@nom", nom);//
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Medecin m = new Medecin(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4));
                    res.Add(m);
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb d'ouverture de la connexion \n " + ex.Message, "Attention");
            }
            return res;
        }

        public void Update(Medecin m)
        {
            try
            {
                cnx = ConnexionHopital.GetInstance();
                SqlCommand cmd = new SqlCommand("update medecin set  nom=@nom, prenom=@prenom, datenaissance=#nais, adresse=@adr where cin=@cin", cnx);
                cmd.Parameters.Add("@cin", m.Cin);//
                cmd.Parameters.Add("@nom", m.Nom);//
                cmd.Parameters.Add("@prenom", m.Prenom);//
                cmd.Parameters.Add("@nais", m.DateNaissance);//
                cmd.Parameters.Add("@adr", m.Adresse);//

                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Medecin est modifié avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de la mise à jour\n " + ex.Message, "Attention");
            }

        }

    }
}
