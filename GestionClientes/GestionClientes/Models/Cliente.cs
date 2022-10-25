using System;
using System.Collections.Generic;
using System.Text;

namespace GestionClientes.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }
        public string direccion { get; set; }
        public DateTime fechaNacimiento { get; set; }
    }
}
