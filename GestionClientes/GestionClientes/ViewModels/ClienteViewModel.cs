using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace GestionClientes.ViewModels
{
    public class ClienteViewModel:BindableObject
    {
        string nombre; 
        string apellido; 
        string identificacion;
        string direccion;
        DateTime fechaNacimiento;


        public string Nombre { 
            get { return nombre; } 
            set { nombre = value; OnPropertyChanged("Nombre");} 
        }


        public string Apellido { 
            get { return apellido; } 
            set { apellido = value; OnPropertyChanged("Apellido"); } 
        }

        public string Identificacion
        {
            get { return identificacion; }
            set { identificacion = value; OnPropertyChanged("Identificacion"); }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; OnPropertyChanged("Direccion"); }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; OnPropertyChanged("FechaNacimiento"); }
        }

    }
}
