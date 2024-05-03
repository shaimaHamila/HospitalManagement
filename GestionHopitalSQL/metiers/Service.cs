using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metiers
{
    public class Service
    {
        String nom;
        int nbreLits;
        Medecin chefServ;

        public Service(string nom, int nbreLits, Medecin chefServ)
        {
            this.nom = nom;
            this.nbreLits = nbreLits;
            this.chefServ = chefServ;
        }

        public string Nom { get => nom; }
        public int NbreLits { get => nbreLits; set => nbreLits = value; }
        public Medecin ChefServ { get => chefServ; set => chefServ = value; }
        public override String ToString()
        {
            return nom;
        }

        public override bool Equals(object obj)
        {
            var service = obj as Service;
            return service != null && nom.Equals(service.nom);
        }
    }
}
