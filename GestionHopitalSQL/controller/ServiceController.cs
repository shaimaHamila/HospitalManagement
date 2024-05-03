using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using metiers;
using daoSqlServer14;
namespace controller
{
    public class ServiceController
    {
        static List<Service> servives;

        public static List<Service> GetServices()
        {
            ServiceDAO bd = new ServiceDAO();
            servives = bd.FindAll();
            return servives;
        }
        public static Service Find(String nom)
        {
            ServiceDAO bd = new ServiceDAO();
            return bd.Find(nom);
            

        }
        public static Service FindToMedecin(String cin)
        {
            ServiceDAO bd = new ServiceDAO();
            servives = bd.FindAll();

            foreach (Service s in servives)
                if (s.ChefServ.Equals(cin))
                    return s;

            return null;


        }
        public static bool Add(Service s)
        {
            ServiceDAO bd = new ServiceDAO();
            servives = bd.FindAll();
            if (servives.Contains(s))
            {
                MessageBox.Show("Service existe déjà" , "Attention");
                return false;
            }
            else
            {//Vérifier si le medecin déjà dans un autre service
                bool chef = false;
                foreach (Service ser in servives)
                {
                    if (ser.ChefServ.Equals(s.ChefServ))
                    {
                        chef = true;
                        MessageBox.Show("Medecin déjà affecté à un autre service" + ser.Nom, "Attention");
                        break;
                    }
                }
                if (chef == false)
                {
                    bd.Add(s);
                    return true;
                }

                return false;
            }


        }
        public static bool Update(Service s)
        {
            ServiceDAO bd = new ServiceDAO();
            servives = bd.FindAll();
            if (servives.Contains(s)==false)
                return false;
            else
            {
                bd.Update(s);
                return true;

            }


        }
    }
}
