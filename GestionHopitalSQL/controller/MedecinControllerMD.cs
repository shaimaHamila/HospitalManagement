using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using daoSqlServer14;

using metiers;
using System.Data;

namespace controller
{
    public class MedecinControllerMD
    {
        static List<Medecin> medecins;

        public static List<Medecin> GetMedecins()
        {
            medecins = new List<Medecin>();
              DataTable dtMed = BDLHopital.dsHopital.Tables["TLMedecin"];
            if (dtMed == null)//c'est un contrôle pour vérifier si TLMedecin n'est chargée dans la BDV
            { dtMed = BDLHopital.ChargerMedecin(); }
            
            foreach (DataRow ligne in dtMed.Rows)
            {
                Medecin med = new Medecin(ligne[0].ToString(), ligne[1].ToString(), ligne[2].ToString(), Convert.ToDateTime(ligne[3].ToString()), ligne[4].ToString());
                medecins.Add(med);                                    
            }
            return medecins;
        }

        public static bool Add(Medecin m)
        {
            if (medecins == null)
                medecins = GetMedecins();

            //Vérifier est-ce-que nom de Medecin existe déjà 


            if (medecins.Contains(m) == false)
            {
                BDLHopital.AddMedecin(m);
                medecins.Add(m);
                return true;
            }
            return false;
            

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
            if (medecins.Contains(m) == false)
                return false;
            else
            {//Verifier si le medecin est un chef de service ou affecter dans un service 
                //ou affecter dans un service
                if (ServiceController.FindToMedecin(m.Cin) == null && AffectationServiceController.FindToMedecin(m.Cin).Count == 0)
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
            MedecinDAO bd = new MedecinDAO();
            medecinsCher = bd.FindToNom(nom);

            // 2eme mèthode 
            /*medecinsCher=new List<Medecin>();
            foreach(Medecin m in medecins )
            {if (m.Nom.Equals(nom))
                   medecinsCher.Add(m);
            }*/
            return medecinsCher;
        }

    }
}
