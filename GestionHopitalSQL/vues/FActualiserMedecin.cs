using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using controller;
using metiers;
namespace vues
{
    public partial class FActualiserMedecin : Form
    {
        public FActualiserMedecin()
        {
            InitializeComponent();
        }
        

        private void FActualiserMedecin_Load(object sender, EventArgs e)
        {

            dgvMedecins.DataSource = MedecinController.GetMedecins();

        }

        
        

        private void btnChercher_Click_1(object sender, EventArgs e)
        {
            Medecin m = MedecinController.Find(txtCin.Text);
            if (m != null)
            {

               

                
                txtAdresse.Text = m.Adresse;
                txtNom.Text = m.Nom;
                txtPrenom.Text = m.Prenom;
                dtpNaissance.Value = m.DateNaissance;

            }
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            Medecin mm = MedecinController.Find(txtCin.Text);
            Medecin m = new Medecin(txtCin.Text, mm.Prenom, mm.Nom, mm.DateNaissance, mm.Adresse);
            DialogResult choixUser = MessageBox.Show("Voulez vous supprimer ce Medecin\n" + m.ToString(), "Attension", MessageBoxButtons.YesNoCancel);
            if (choixUser == DialogResult.Yes)
            {
                bool verifier = MedecinController.Remove(m);

                if (verifier == false)
                    MessageBox.Show("Impossible de supprimer ce Medecin", "Attension");
            }
            dgvMedecins.DataSource = MedecinController.GetMedecins();

        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            MedecinController.Add(new Medecin(txtCin.Text, txtPrenom.Text, txtNom.Text, dtpNaissance.Value, txtAdresse.Text));

            FActualiserMedecin_Load(sender, e);
        }
    }
}
