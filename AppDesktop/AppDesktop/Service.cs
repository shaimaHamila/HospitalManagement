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
    public partial class Service : Form
    {
        private readonly ServiceApiService _serviceApiService;

        public Service()
        {
            InitializeComponent();
            _serviceApiService = new ServiceApiService("http://localhost:5117/");

        }

        private  async void Service_Load(object sender, EventArgs e)
        {
            await UpdateServices();
        }

        private async Task UpdateServices()
        {
            List<ServiceDto> services = await _serviceApiService.GetAllServices();
            lstServices.Items.Clear();
            foreach (var service in services)
            {
                lstServices.Items.Add($"{service.Id} - {service.Name} - {service.Description}");
            }
        }
        
        private async void timer1_Tick_1(object sender, EventArgs e)
        {
            await UpdateServices();

        }
        


        

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void description_TextChanged(object sender, EventArgs e)
        {

        }

        private async void ADD_Click(object sender, EventArgs e)
        {
            // Create a new service object
            ServiceDto newService = new ServiceDto
            {
                Name = name.Text,
                Description = description.Text
            };

            // Call the CreateService method of ServiceApiService
            bool result = await _serviceApiService.CreateService(newService);

            // Display a message based on the result
            if (result)
            {
                MessageBox.Show("Service added successfully");
                // Reload the list of services
                await UpdateServices();
            }
            else
            {
                MessageBox.Show("Failed to add service");
            }

        }

        private void lstServices_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void discriptin_Click(object sender, EventArgs e)
        {

        }

        private void Remove_TextChanged(object sender, EventArgs e)
        {

        }

        private async void Removee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Remove.Text))
            {
                MessageBox.Show("Please enter a service ID");
                return;
            } 
            if (!int.TryParse(Remove.Text, out int serviceId))
            {
                MessageBox.Show("Invalid service ID");
                return;
            }

            bool result = await _serviceApiService.DeleteService(serviceId);
            if (result)
            {
                MessageBox.Show("Service removed successfully");
                await UpdateServices(); // Update the list of services
            }
            else
            {
                MessageBox.Show("Failed to remove service");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void PUT_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(Remove.Text, out int serviceId))
            {
                MessageBox.Show("Invalid service ID");
                return;
            }

            ServiceDto updatedService = new ServiceDto
            {
                Id = serviceId,
                Name = name.Text,
                Description = description.Text
            };

            bool result = await _serviceApiService.UpdateService(serviceId,updatedService);
            if (result)
            {
                MessageBox.Show("Service updated successfully");
                await UpdateServices(); // Update the list of services
            }
            else
            {
                MessageBox.Show("Failed to update service");
            }
        }
    }
}
