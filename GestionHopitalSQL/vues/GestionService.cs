using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using metiers;
using controller;
namespace vues
{
    public partial class GestionService : Form
    {
        public GestionService()
        {
            InitializeComponent();
        }

        private void GestionService_Load(object sender, EventArgs e)
        {
            List<Service> services = ServiceController.GetServices();
           
            foreach (Service s in services)
            {
                dgvServices.Rows.Add(s.Nom, s.NbreLits, "Dr. " + s.ChefServ.Prenom + " " + s.ChefServ.Nom);
            }
            List<Medecin> medecins = MedecinController.GetMedecins();
           
            cbMedecins.Items.AddRange(medecins.ToArray());
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Length == 0)
            { MessageBox.Show("Saisir le nom du service", "Verifier"); }
            else
            {
                if (cbMedecins.SelectedIndex < 0)
                {
                    MessageBox.Show("Selectionner un Medecin", "Verifier");

                }
                else
                {
                    Medecin m = (Medecin)cbMedecins.SelectedItem;
                    try
                    {
                        int n = Convert.ToInt32(txtNbreLits.Text);
                        Service s = new Service(txtNom.Text, n, m);
                        bool ajouter=ServiceController.Add(s);
                        if (ajouter == true)
                        {
                            dgvServices.Rows.Add(s.Nom, s.NbreLits, "Dr. " + s.ChefServ.Prenom + " " + s.ChefServ.Nom);
                            viderChamps();
                        }
                    }
                    catch (FormatException ex)
                    { MessageBox.Show("Nombre de lit doit être numérique", "Verifier"); }
                }
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {

            if (cbMedecins.SelectedIndex < 0)
            {
                MessageBox.Show("Selectionner un Medecin", "Verifier");

            }
            else
            {
                Medecin m = (Medecin)cbMedecins.SelectedItem;
                try
                {
                    int n = Convert.ToInt32(txtNbreLits.Text);
                    Service s = new Service(txtNom.Text, n, m);
                    ServiceController.Update(s);
                    dgvServices.Rows.Clear();
                    GestionService_Load( sender,  e);

                    viderChamps();
                }
                catch (FormatException ex)
                { MessageBox.Show("Nombre de lit doit être numérique", "Verifier"); }
            }
        }
        void viderChamps()
        {
            txtNom.Text = "";
            txtNbreLits.Text = "";
            cbMedecins.SelectedIndex = -1;

        }

        private void btnChercherNom_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Length == 0)
            { MessageBox.Show("Saisir le nom du service", "Verifier"); }
            else
            {
                
                   
              
                Service s = ServiceController.Find(txtNom.Text);
                    if (s != null)
                    {
                        txtNbreLits.Text = s.NbreLits.ToString();
                        cbMedecins.SelectedItem = s.ChefServ;
                    }
                    else { MessageBox.Show("Utilisateur n'existe pas", "Verifier"); }
                

            }
        }

        private void dgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbMedecins_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
