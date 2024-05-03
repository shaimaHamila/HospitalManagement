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
    public partial class Doctor : Form
    {
        private readonly DoctorApiService _doctorApiService;
        private List<int> _serviceIds;


        public Doctor()
        {
            InitializeComponent();
            _doctorApiService = new DoctorApiService("http://localhost:5117/");

        }

        private async void Doctor_Load(object sender, EventArgs e)
        {
            await UpdateDoctorList();
            await LoadServiceIds();


        }
        private async Task LoadServiceIds()
        {
            _serviceIds = await _doctorApiService.GetServiceIds(); // Assuming a method to get available Service IDs
            cmbServiceIds.DataSource = _serviceIds;
        }

        private async Task UpdateDoctorList()
        {
            List<DoctorDto> doctors = await _doctorApiService.GetAllDoctors();
            lstDoctor.Items.Clear();
            foreach (var doctor in doctors)
            {
                lstDoctor.Items.Add($"{doctor.Id} - {doctor.FirstName} - {doctor.LastName} - {doctor.Address} ");
            }
        }

        private async void ADD_Click(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            string lastName = LastName.Text;
            DateTime birthday = birth.Value;
            string address = Adress.Text;
            int serviceId = (int)cmbServiceIds.SelectedItem; // Use the selected Service ID

            DoctorDto newDoctor = new DoctorDto
            {
                FirstName = firstName,
                LastName = lastName,
                Birthday = birthday,
                Address = address,
                ServiceIds = new List<int> { serviceId }
            };

            bool result = await _doctorApiService.CreateDoctor(newDoctor);
            if (result)
            {
                MessageBox.Show("Doctor added successfully");
                await UpdateDoctorList();
            }
            else
            {
                MessageBox.Show("Failed to add doctor");
            }
        }

        private void Adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4g_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbServiceIds_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async  void button1_Click(object sender, EventArgs e)
        {
          
            if (int.TryParse(txtDoctorId.Text, out int doctorId))
            {
                bool result = await _doctorApiService.DeleteDoctor(doctorId);
                if (result)
                {
                    MessageBox.Show("Doctor removed successfully");
                    await UpdateDoctorList();
                }
                else
                {
                    MessageBox.Show("Failed to remove doctor");
                }
            }
            else
            {
                MessageBox.Show("Invalid doctor ID");
            }
        }

        private void lstDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDoctorId_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDoctorId.Text, out int doctorId))
            {
                DoctorDto updatedDoctor = new DoctorDto
                {
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Birthday = birth.Value,
                    Address = Adress.Text,
                    ServiceIds = new List<int> { 1 } // Example: Assuming you have a way to select the service IDs
                };

                bool result = await _doctorApiService.UpdateDoctor(doctorId, updatedDoctor);
                if (result)
                {
                    MessageBox.Show("Doctor updated successfully");
                    await UpdateDoctorList();
                }
                else
                {
                    MessageBox.Show("Failed to update doctor");
                }
            }
            else
            {
                MessageBox.Show("Invalid doctor ID");
            }
        }
        private async Task PopulateServiceIdsComboBox()
        {
            List<int> serviceIds = await _doctorApiService.GetServiceIds(); // Assuming a method to get available Service IDs
            cmbServiceIds.DataSource = serviceIds;
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDoctorId.Text, out int doctorId))
            {
                DoctorDto doctor = await _doctorApiService.GetDoctorById(doctorId);
                if (doctor != null)
                {
                    FirstName.Text = doctor.FirstName;
                    LastName.Text = doctor.LastName;
                    birth.Value = doctor.Birthday ?? DateTime.Now; 
                    Adress.Text = doctor.Address;


                    cmbServiceIds.SelectedItem = doctor.ServiceIds;
                }
                else
                {
                    MessageBox.Show("Doctor not found");
                }
            }
            else
            {
                MessageBox.Show("Invalid doctor ID");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuHopital menu = new MenuHopital();
            menu.Show();
        }
    }
    }

