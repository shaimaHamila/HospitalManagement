using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using metiers;
using daoSqlServer14;
namespace controller
{
    public class MedecinController
    {

        static List<Medecin> medecins;

        public static List<Medecin> GetMedecins()
        {
            MedecinDAO bd = new MedecinDAO();
            medecins = bd.FindAll();
            return medecins;
        }

        public static bool Add(Medecin m)
        {
            if (medecins.Contains(m))
                return false;
            else
            {
                MedecinDAO bd = new MedecinDAO();
                bd.Add(m);
                return true;
            }

        }
        public static Medecin Find(String cin)
        {
            MedecinDAO bd = new MedecinDAO();
            return bd.Find(cin);
            /*2 eme methode
             medecins = bd.FindAll();
            foreach (Medecin mm in medecins)
                if (mm.Cin.Equals(cin))
                    return mm;

            return null;
            */
        }
        public static bool Remove(Medecin m)
        {
            if (medecins.Contains(m)==false)
                return false;
            else
            {//Verifier si le medecin est un chef de service ou affecter dans un service 
                //ou affecter dans un service
                if (ServiceController.FindToMedecin(m.Cin) == null&& AffectationServiceController.FindToMedecin(m.Cin).Count==0)
                {
                    MedecinDAO bd = new MedecinDAO();                                                              
                    bd.Remove(m);
                    return true;
                }
                return false;
            }

        }

        public static List<Medecin> FindToAdresse(String adresse)
        {
            List<Medecin> medecinsCher;
            MedecinDAO bd = new MedecinDAO();
            medecinsCher = bd.FindToAdresse(adresse);

            // 2eme mèthode 
            /*medecinsCher=new List<Medecin>();
            medecins=bd.FindAll();
            foreach(Medecin m in medecins )
            {if (m.Adresse.Equals(adresse))
                   medecinsCher.Add(m);
            }*/

            return medecinsCher;
        }
        public static List<Medecin> FindToNom(String nom)
        {
           List<Medecin> medecinsCher;
            /*  MedecinDAO bd = new MedecinDAO();
             medecinsCher = bd.FindToNom(nom);
            */
            // 2eme mèthode 
            medecinsCher = new List<Medecin>();
            foreach(Medecin m in medecins )
            {if (m.Nom.Equals(nom))
                   medecinsCher.Add(m);
            }
            return medecinsCher;
        }

    }
}
