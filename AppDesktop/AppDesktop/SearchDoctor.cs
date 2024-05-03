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
    public partial class SearchDoctor : Form
    {
        private readonly DoctorApiService _doctorApiService;
        private readonly ServiceApiService _serviceApiService;

        public SearchDoctor()
        {
            InitializeComponent();
            _doctorApiService = new DoctorApiService("http://localhost:5117/");
            LoadServices();
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadDoctors();
        }
        private async Task LoadDoctors()
        {
          
            List<DoctorDto> doctors = await _doctorApiService.GetAllDoctors();
            lstDoctors.Items.Clear();
            lstDoctors.DataSource = doctors;
            
        }

        private async void lstDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private async void btnSaveServices_Click(object sender, EventArgs e)
        {
            List<int> selectedServiceIds = new List<int>();
            foreach (var item in lstServices.SelectedItems)
            {
                selectedServiceIds.Add(((ServiceDto)item).Id);
            }

            DoctorDto newDoctor = new DoctorDto
            {
                FirstName = textBox1.Text,
                LastName = LastName.Text,
                Birthday = Birthday.Value,
                Address = Adress.Text,
                ServiceIds = selectedServiceIds
            };

            bool result = await _doctorApiService.CreateDoctor(newDoctor);
            if (result)
            {
                MessageBox.Show("Doctor created successfully");
                this.Close(); // Close the form after successfully adding the doctor
            }
            else
            {
                MessageBox.Show("Failed to create doctor");
            }
        }
        private async void LoadServices()
        {
            List<ServiceDto> services = await _serviceApiService.GetAllServices();
            lstServices.Items.Clear();
            foreach (var service in services)
            {
                lstServices.Items.Add(service);
            }
        }

        private void SearchDoctor_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveServices_Click(object sender, EventArgs e)
        {

        }

        private void Birthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstDoctors_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

  
    }
