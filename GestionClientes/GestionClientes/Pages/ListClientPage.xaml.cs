using GestionClientes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GestionClientes.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListClientPage : ContentPage
    {
        public ListClientPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            LoadData();
        }

        private void LoadData()
        {
            List<Cliente> clientes = new List<Cliente>();

            clientes.Add(
                new Cliente() 
                { 
                    Id = 1,
                    Nombre = "Paulina", 
                    Apellido = "Cabrera", 
                    Identificacion = "01051764873"
                });

            clientes.Add(
                new Cliente()
                {
                    Id = 2,
                    Nombre = "Juanito",
                    Apellido = "Maria",
                    Identificacion = "0105874932"
                });

            clientes.Add(
                new Cliente()
                {
                    Id = 3,
                    Nombre = "Carlos",
                    Apellido = "Perez",
                    Identificacion = "0105874932"
                });

            clientes.Add(
                new Cliente()
                {
                    Id = 4,
                    Nombre = "maria",
                    Apellido = "Blanca  Nieves",
                    Identificacion = "0105874932"
                });

            clientes.Add(
                new Cliente()
                {
                    Id = 5,
                    Nombre = "Aleatorio",
                    Apellido = "Perez",
                    Identificacion = "0105874932"
                });


            listView.ItemsSource = clientes;

        }

        private void ClienteButtonClicked(object sender, EventArgs e)

        {
            this.Navigation.PushAsync(new ClientePage());
        }



    }
}