using GestionClientes.Models;
using GestionClientes.ViewModels;
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
    public partial class ClientePage : ContentPage
    {
        ClienteViewModel ClienteViewModel { get { return (ClienteViewModel)this.BindingContext; } }
        public ClientePage()
        {
            InitializeComponent();

            BindingContext = new ClienteViewModel();

            ClienteViewModel.Nombre = "Paulina";
            ClienteViewModel.Apellido = "Cabrera";
            ClienteViewModel.FechaNacimiento = DateTime.Now;
        }

        private void SaveButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Cliente", ClienteViewModel.Nombre +" "+ClienteViewModel.Apellido, "Ok");
        }

        //Ejemplo Agrego aqui codigo, de Paulina
    }
}