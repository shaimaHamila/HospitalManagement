using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using metiers;

namespace dao
{
    public class AffectationServiceDAO
    {
        MySqlConnection cnx; //on appele ConnexionHopital.GetInstance(); avant chaque requête dans les méthodes, 
                             //on appele cnx.Close(); à la fin du traitement

        public List<AffectationService> FindAll()
        {
            List<AffectationService> res = new List<AffectationService>();
            //pour trouver le Medecin selon cin
            MedecinDAO bdMed = new MedecinDAO();
            List<Medecin> medecins = bdMed.FindAll();
            Medecin mm = null;
            //pour trouver le service selon son nom
            ServiceDAO bdServ = new ServiceDAO();
            List<Service> services = bdServ.FindAll();
            Service ss = null;

            try
            {
                cnx = ConnexionHopital.GetInstance();

                MySqlCommand cmd = new MySqlCommand("select * from affectation_service", cnx);
                
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //chercher Medecin
                    foreach (Medecin med in medecins)
                        if (med.Cin.Equals(reader.GetString(0)))
                        { mm = med; break; }
                    //Chercher Service
                    foreach (Service ser in services)
                        if (ser.Nom.Equals(reader.GetString(1)))
                        { ss = ser; break; }
                    AffectationService m = new AffectationService(mm, ss, reader.GetDateTime(2), reader.GetDateTime(3));
                    res.Add(m);
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Affectation : Pb d'ouverture de la connexion \n " + ex.Message, "Attention");
            }
            return res;
        }

        public void Remove(AffectationService aff)
        {
            try
            {
                cnx = ConnexionHopital.GetInstance();
                MySqlCommand cmd = new MySqlCommand("delete from affectation_service where cinMed=@cin and debut=@debut", cnx);
                cmd.Parameters.Add("@cin", aff.Medecin.Cin);//
                cmd.Parameters.Add("@debut", aff.Debut);//
                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Affectation supprimer avec succée \n ", "Attention");
                cnx.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de la suppression\n " + ex.Message, "Attention");
            }

        }
        public void Add(AffectationService affectation)
        {
            try
            {
                cnx = ConnexionHopital.GetInstance();
                MySqlCommand cmd = new MySqlCommand("insert into affectation_service values(@cin, @service, @debut, @fin)", cnx);
                cmd.Parameters.Add("@cin", affectation.Medecin.Cin);//
                cmd.Parameters.Add("@service", affectation.Service.Nom);
                cmd.Parameters.Add("@debut", affectation.Debut);
                cmd.Parameters.Add("@fin", affectation.Fin);

                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Medecin affecter avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de la requete de l'ajout\n " + ex.Message, "Attention");
            }

        }
        public List<AffectationService> FindToService(String service)
        {

            List<AffectationService> res = new List<AffectationService>();
            //pour trouver le Medecin selon cin
            MedecinDAO bdMed = new MedecinDAO();
            List<Medecin> medecins = bdMed.FindAll();
            Medecin mm = null;
            //pour trouver le service selon son nom
            ServiceDAO bdServ = new ServiceDAO();
            List<Service> services = bdServ.FindAll();
            Service ss = null;

            try
            {
                cnx = ConnexionHopital.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from affectation_service where nomServ=@nomServ", cnx);
                cmd.Parameters.Add("@nomServ", service);//
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //chercher Medecin
                    foreach (Medecin med in medecins)
                        if (med.Cin.Equals(reader.GetString(0)))
                        { mm = med; break; }

                    //chercher Service
                    foreach (Service ser in services)
                        if (ser.Nom.Equals(reader.GetString(1)))
                        { ss = ser; break; }

                    AffectationService m = new AffectationService(mm, ss, reader.GetDateTime(2), reader.GetDateTime(3));
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
        public List<AffectationService> FindToMedecin(String cin)
        {   //pour trouver le Medecin selon cin
            MedecinDAO bdMed = new MedecinDAO();
            List<Medecin> medecins = bdMed.FindAll();
            Medecin mm = null;
            //pour trouver le service selon son nom
            ServiceDAO bdServ = new ServiceDAO();
            List<Service> services = bdServ.FindAll();
            Service ss = null;

            List<AffectationService> res = new List<AffectationService>();
            try
            {
                cnx = ConnexionHopital.GetInstance();
                MySqlCommand cmd = new MySqlCommand("select * from affectation_service where cinMed=@cin", cnx);
                cmd.Parameters.Add("@cin", cin);//
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //chercher Medecin
                    foreach (Medecin med in medecins)
                        if (med.Cin.Equals(reader.GetString(0)))
                        { mm = med; break; }

                    //chercher Service
                    foreach (Service ser in services)
                        if (ser.Nom.Equals(reader.GetString(1)))
                        { ss = ser; break; }

                    AffectationService m = new AffectationService(mm, ss, reader.GetDateTime(2), reader.GetDateTime(3));
                    res.Add(m);
                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Affectation Chercher par Medecin \n " + ex.Message, "Attention");
            }
            return res;
        }

        public void Update(AffectationService m)
        {
            try
            {
                cnx = ConnexionHopital.GetInstance();
                MySqlCommand cmd = new MySqlCommand("update affectation_service set  cinMed=@cin, nomServ=@prenom, debut=#debut, fin=@fin where cinMed=@cin and debut=@debut", cnx);
                cmd.Parameters.Add("@cin", m.Medecin.Cin);//
                cmd.Parameters.Add("@nomServ", m.Service.Nom);//
                cmd.Parameters.Add("@debut", m.Debut);//
                cmd.Parameters.Add("@fin", m.Fin);//


                int n = cmd.ExecuteNonQuery();
                if (n != 0)
                    MessageBox.Show("Affectation est modifié avec succée \n ", "Attention");
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Affectation : Pb dans la requete de la mise à jour\n " + ex.Message, "Attention");
            }

        }}}
