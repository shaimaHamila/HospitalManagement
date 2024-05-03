using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metiers
{
    public class Medecin
    {
        String cin, prenom, nom, adresse;
        DateTime dateNaissance;
        public Medecin(String cin, String prenom, String nom, DateTime naissance, String adresse)
        {
            this.cin = cin;
            this.prenom = prenom;
            this.nom = nom;
            this.dateNaissance = naissance;
            this.adresse = adresse;
        }

        public String Cin { get { return cin; } }
        public String Prenom { get { return prenom; } }
        public String Nom { get { return nom; } }
        public DateTime DateNaissance { get { return dateNaissance; } }
        public String Adresse { get { return adresse; } }

        public override String ToString()
        {
            return cin + " | " + prenom + " | " + nom;
        }
        public override bool Equals(object obj)
        {
            var medecin = obj as Medecin;
            return medecin != null &&
                   cin == medecin.cin;
        }
    }
}
