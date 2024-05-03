using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using metiers;
using controller;
namespace vues
{
    public partial class GestionMedecin : Form
    {
        public GestionMedecin()
        {
            InitializeComponent();
        }

       

        private void btnRechCin_Click(object sender, EventArgs e)
        {

            Medecin m = MedecinController.Find(txtCin.Text);
            if (m != null)
            {
                dgvMedecins.Rows.Clear();
                
                dgvMedecins.Rows.Add(m.Cin, m.Prenom, m.Nom, m.DateNaissance, m.Adresse);

                
                txtAdresse.Text = m.Adresse;
                txtNom.Text = m.Nom;
                txtPrenom.Text = m.Prenom;
                dtpNaissance.Value = m.DateNaissance;


            }

           



        }

        private void GestionMedecin_Load(object sender, EventArgs e)
        {

            List<Medecin> medecins = MedecinController.GetMedecins();
            foreach (Medecin mm in medecins)
            {
                dgvMedecins.Rows.Add(mm.Cin, mm.Prenom, mm.Nom, mm.DateNaissance, mm.Adresse);

            }

        }

        private void btnRecheNom_Click(object sender, EventArgs e)
        {

            List<Medecin> medecins = MedecinController.FindToNom(txtNom.Text);

            dgvMedecins.Rows.Clear();
            foreach (Medecin mm in medecins)
            {
                dgvMedecins.Rows.Add(mm.Cin, mm.Prenom, mm.Nom, mm.DateNaissance, mm.Adresse);

            }

        }


        private void btnRechAdresse_Click(object sender, EventArgs e)
        {

            List<Medecin> medecins = MedecinController.FindToAdresse(txtAdresse.Text);
            dgvMedecins.Rows.Clear();
            foreach (Medecin mm in medecins)
            {
                dgvMedecins.Rows.Add(mm.Cin, mm.Prenom, mm.Nom, mm.DateNaissance, mm.Adresse);

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
