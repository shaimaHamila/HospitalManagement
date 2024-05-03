using AppDesktop.APIservice;
using AppDesktop.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDesktop
{
    public partial class Patient : Form
    {
        private readonly PatientApiService _patientApiService;

        public Patient()
        {
            InitializeComponent();
            _patientApiService = new PatientApiService("http://localhost:5117/");

        }

        private async Task UpdatePatient()
        {
            try
            {
                List<PatientDto> patients = await _patientApiService.GetAllPatients();
                lstPatient.Items.Clear();
                foreach (var patient in patients)
                {
                    lstPatient.Items.Add($"{patient.Id} - {patient.UserName} - {patient.Phone} - {patient.ServiceId}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to retrieve patients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Patient_Load(object sender, EventArgs e)
        {
            await UpdatePatient();

        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {

        }



        private void lstPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void ADD_Click(object sender, EventArgs e)
        {


            try
            {
                if (!int.TryParse(Phone.Text, out int phone))
                {
                    MessageBox.Show("Invalid phone number");
                    return;
                }

                if (!int.TryParse(ServiceID.Text, out int serviceId))
                {
                    MessageBox.Show("Invalid service ID");
                    return;
                }

                PatientDto newPatient = new PatientDto
                {
                    UserName = userName.Text,
                    Phone = phone,
                    ServiceId = serviceId
                };

                bool result = await _patientApiService.CreatePatient(newPatient);
                if (result)
                {
                    MessageBox.Show("Patient added successfully");
                    await UpdatePatient(); // Update the list of patients
                    ClearFields(); // Clear the text boxes
                }
                else
                {
                    MessageBox.Show("Failed to add patient");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add patient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            userName.Text = "";
            Phone.Text = "";
            ServiceID.Text = "";
        }

        private void ServiceID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void IdPatient_TextChanged(object sender, EventArgs e)
        {

        }

        private async void DEL_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(IdPatient.Text, out int patientId))
            {
                MessageBox.Show("Invalid patient ID");
                return;
            }

            bool result = await _patientApiService.DeletePatient(patientId);
            if (result)
            {
                MessageBox.Show("Patient removed successfully");
                await UpdatePatient(); // Update the list of patients
            }
            else
            {
                MessageBox.Show("Failed to remove patient");
            }
        }

        private async void PUT_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(IdPatient.Text, out int patientId))
            {
                MessageBox.Show("Invalid patient ID");
                return;
            }

            if (!int.TryParse(Phone.Text, out int phone))
            {
                MessageBox.Show("Invalid phone number");
                return;
            }

            if (!int.TryParse(ServiceID.Text, out int serviceId))
            {
                MessageBox.Show("Invalid service ID");
                return;
            }

            PatientDto updatedPatient = new PatientDto
            {
                Id = patientId,
                UserName = userName.Text,
                Phone = phone,
                ServiceId = serviceId
            };

            bool result = await _patientApiService.UpdatePatient(patientId, updatedPatient);
            if (result)
            {
                MessageBox.Show("Patient updated successfully");
                await UpdatePatient(); // Update the list of patients
            }
            else
            {
                MessageBox.Show("Failed to update patient");
            }
        }
    }
        }

