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
    public partial class FAffectationService : Form
    {
        public FAffectationService()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FAffectationService_Load(object sender, EventArgs e)
        {
            List<AffectationService> affectations = AffectationServiceController.GetAffectationServices();
            foreach (AffectationService af in affectations)
            {
                dgvAffecServices.Rows.Add(af.Medecin.Cin, af.Service.Nom, af.Debut, af.Fin);

            }

            List<Medecin> medecins = MedecinController.GetMedecins();
            cbMedecins.DataSource = medecins;
            cbMedecins.DisplayMember = "nom";

            List<Service> services = ServiceController.GetServices();
            cbServices.DataSource = services;
            cbServices.DisplayMember = "nom";

        }
        
        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            if (cbMedecins.SelectedIndex < 0)
            {
                MessageBox.Show("Selectinner un Medecin", "Attention");
            }
            else
            {
                Medecin m = (Medecin)cbMedecins.SelectedItem;
                if (cbServices.SelectedIndex < 0)
                {
                    MessageBox.Show("Selectinner un Service", "Attention");
                }
                else
                {
                    Service s = (Service)cbServices.SelectedItem;

                    DateTime debut = dtpDebut.Value;
                    DateTime fin = dtpFin.Value;
                    if (debut.CompareTo(fin) >= 0)
                    {
                        MessageBox.Show("Verifier date de fin ", "Attention");
                    }
                    else
                    {
                        AffectationService aff = new AffectationService(m, s, debut, fin);
                        bool verif = AffectationServiceController.Add(aff);
                        if (verif)
                        {
                            dgvAffecServices.Rows.Add(aff.Medecin.Cin, aff.Service.Nom, aff.Debut, aff.Fin);
                            MessageBox.Show("Medecin affécté avec succées\n" + aff.ToString(), "Attention");
                            viderChamps();
                        }
                    }
                }
            }

        }
        void viderChamps()
        {
            cbMedecins.SelectedIndex = -1;
            cbServices.SelectedIndex = -1;
            dtpDebut.Value = DateTime.Now;
            dtpFin.Value = DateTime.Now;

        }

        private void btnAfficherTout_Click(object sender, EventArgs e)
        {
            dgvAffecServices.Rows.Clear();
            List<AffectationService> affectations = AffectationServiceController.GetAffectationServices();
            foreach (AffectationService af in affectations)
            {
                dgvAffecServices.Rows.Add(af.Medecin.Cin, af.Service.Nom, af.Debut, af.Fin);

            }

            List<Medecin> medecins = MedecinController.GetMedecins();
            cbMedecins.Items.AddRange(medecins.ToArray());

            List<Service> services = ServiceController.GetServices();
            cbServices.Items.AddRange(services.ToArray());

        }

        private void btnChercherService_Click(object sender, EventArgs e)
        {
            dgvAffecServices.Rows.Clear();
            if (cbServices.SelectedIndex < 0)
                MessageBox.Show("SVP serctionner un Service", "Attention");
            else
            {
                Service ser = (Service)cbServices.SelectedItem;
                List<AffectationService> affectations = AffectationServiceController.FindToService(ser.Nom);
                foreach (AffectationService af in affectations)
                {
                    dgvAffecServices.Rows.Add(af.Medecin.Cin, af.Service.Nom, af.Debut, af.Fin);

                }

                List<Medecin> medecins = MedecinController.GetMedecins();
                cbMedecins.Items.AddRange(medecins.ToArray());

                List<Service> services = ServiceController.GetServices();
                cbServices.Items.AddRange(services.ToArray());
            }

        }

        private void btnMedecin_Click(object sender, EventArgs e)
        {
            dgvAffecServices.Rows.Clear();
            if (cbMedecins.SelectedIndex < 0)
                MessageBox.Show("SVP serctionner un médecin", "Attention");
            else
            {
                Medecin m = (Medecin)cbMedecins.SelectedItem;
                List<AffectationService> affectations = AffectationServiceController.FindToMedecin(m.Cin);
                foreach (AffectationService af in affectations)
                {
                    dgvAffecServices.Rows.Add(af.Medecin.Cin, af.Service.Nom, af.Debut, af.Fin);

                }

                List<Medecin> medecins = MedecinController.GetMedecins();
                cbMedecins.Items.AddRange(medecins.ToArray());

                List<Service> services = ServiceController.GetServices();
                cbServices.Items.AddRange(services.ToArray());
            }


        }

        private void dgvAffecServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
