using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecursosHumanos
{
    internal class ClsEmpleado
    {

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public double Salario { get; set; }

        public ClsEmpleado(string cedula, string nombre, string direccion, string telefono, double salario)
        {
            Cedula = cedula;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Salario = salario;
        }
    }
}
