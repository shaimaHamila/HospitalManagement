using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using metiers;
using daoSqlServer14;
namespace controller
{
    public class AffectationServiceController
    {
        static List<AffectationService> affeServices;

        public static List<AffectationService> GetAffectationServices()
        {
            AffectationServiceDAO bd = new AffectationServiceDAO();
            affeServices = bd.FindAll();
            return affeServices;
        }
        public static AffectationService Find(String cinChef, String nomSer, DateTime debut)
        {

            GetAffectationServices();
            foreach (AffectationService s in affeServices)
                if (s.Medecin.Equals(cinChef) && s.Service.Equals(nomSer) && s.Debut.Equals(debut))
                    return s;

            return null;


        }
        
        public static bool Add(AffectationService s)
        {
            GetAffectationServices();
            bool periode = false;
            if (affeServices.Contains(s))
            {
                MessageBox.Show("Medecin déjà affécté ", "Attention");
                return false;
            }
            else
            {//Vérifier si le medecin déjà affécter dans un service
                foreach (AffectationService af in affeServices)
                {
                    if (af.Medecin.Equals(s.Medecin) && af.Fin.CompareTo(s.Debut) > 0)
                    {
                        periode = true;
                        MessageBox.Show("Medecin déjà affécté dans un autre service ", "Attention");
                        return false;
                    }
                }
                if (periode == false)
                {
                    AffectationServiceDAO bd = new AffectationServiceDAO();
                    
                    bd.Add(s);

                    return true;
                }
                return false;
            }


        }
        public static List<AffectationService> FindToMedecin(String cin)
        {
            GetAffectationServices();
            List<AffectationService> res = new List<AffectationService>();


            foreach (AffectationService s in affeServices)
                if (s.Medecin.Cin.Equals(cin))
                    res.Add(s);

            return res;

        }
        public static List<AffectationService> FindToService(String nomSev)
        {
            GetAffectationServices();
            List<AffectationService> res = new List<AffectationService>();


            foreach (AffectationService s in affeServices)
                if (s.Service.Nom.Equals(nomSev))
                    res.Add(s);

            return res;

        }

    }

}

