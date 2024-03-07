using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_No_5
{
    internal class Empleado
    {
        int noEmpleado;
        string nombreCompleto;
        double sueldoHora;

        public int NoEmpleado { get => noEmpleado; set => noEmpleado = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public double SueldoHora { get => sueldoHora; set => sueldoHora = value; }
    }
}
