using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_No_5
{
    internal class Reporte
    {
        string nombreEmpleado;
        int mes;
        double sueldoMensual;


        public double SueldoMensual { get => sueldoMensual; set => sueldoMensual = value; }
        public int Mes { get => mes; set => mes = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
    }
}
