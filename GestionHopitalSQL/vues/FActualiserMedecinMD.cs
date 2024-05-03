using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using daoSqlServer14;
using controller;
using metiers;
namespace vues
{
    public partial class FActualiserMedecinMD : Form
    {
        public FActualiserMedecinMD()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MedecinController.Add(new Medecin(txtCin.Text, txtPrenom.Text, txtNom.Text, dtpNaissance.Value, txtAdresse.Text));

            // FActualiserMedecin_Load(sender, e);
        }

        private void FActualiserMedecinMD_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
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

        }

        private void FActualiserMedecinMD_Load_1(object sender, EventArgs e)
        {

           // DataSet bdHop = BDLHopital.ChargerHopital();
            DataTable dtMed = BDLHopital.dsHopital.Tables["TLMedecin"];
            DataTable dtServ = BDLHopital.dsHopital.Tables["TLService"];
            DataTable dtAff = BDLHopital.dsHopital.Tables["TLAffectationService"];
           if (dtMed == null)
                dtMed = BDLHopital.ChargerMedecin();
            if (dtServ == null)
                dtServ = BDLHopital.ChargerService();
            if (dtAff == null)
                dtAff = BDLHopital.ChargerAffectationService();
                

            dgvMedecins.DataSource = dtMed;
            dgvServices.DataSource = dtServ;
            dgvAffectations.DataSource = dtAff;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            BDLHopital.EnregistrerMedecin();
        }

        private void btnChercher_Click(object sender, EventArgs e)
        {
            dgvAffectations.Visible = true;
            dgvServices.Visible = true;
           



        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            if (MedecinControllerMD.Add(new Medecin(txtCin.Text, txtPrenom.Text, txtNom.Text, dtpNaissance.Value,
                txtAdresse.Text)))
            {
                FActualiserMedecinMD_Load_1(sender, e);
                MessageBox.Show("Médecin est ajouté ", "Bravo ");

            }
            else MessageBox.Show("Impossible d'ajouter ce médecin", "Verifier");

            

        }
    }
}
