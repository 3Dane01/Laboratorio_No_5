using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_No_5
{
    public partial class Form1 : Form
    {
        //cargar empleados
        List<Empleado> empleados = new List<Empleado>();
        //cargar asistencia
        List<Asistencia> asistencias = new List<Asistencia>();
        List<Reporte> reportes = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }
        public void cargarEmpleados()
        {
            //leer el archivo y cargarlo a la lista 
            string nombreArchivo = "Empleados.txt";
            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                //leer datos de un empleado
                Empleado empleado = new Empleado();
                empleado.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                empleado.NombreCompleto = reader.ReadLine();
                empleado.SueldoHora = Convert.ToInt16(reader.ReadLine());
                //Guardar el empleado a la lista de empleados
                empleados.Add(empleado);
            }
            //para que cierre despues de abrir el archivo y no se quede abierto
            reader.Close();
        }
        public void MostrarEmpleados()
        {
            //mostrar la lista de empleados en el dataGridview
            dataGridViewEmpleados.DataSource = null;
            dataGridViewEmpleados.DataSource = empleados;
            dataGridViewEmpleados.Refresh();
        }
        public void cargarAsistencia()
        {
            //leer el archivo y cargarlo a la lista 
            string nombreArchivo = "Asistencia.txt";
            FileStream stream = new FileStream(nombreArchivo, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                //leer datos
                Asistencia asistencia = new Asistencia();
                asistencia.NoEmpleado = Convert.ToInt16(reader.ReadLine());
                asistencia.HorasMes = Convert.ToInt16(reader.ReadLine());
                asistencia.Mes = Convert.ToInt16(reader.ReadLine());
                asistencias.Add(asistencia);
            }
            //para que cierre despues de abrir el archivo y no se quede abierto
            reader.Close();
        }
        public void MostrarAsistencia()
        {
            //mostrar la lista de asistencia en el dataGridview
            dataGridViewAsistencia.DataSource = null;
            dataGridViewAsistencia.DataSource = asistencias;
            dataGridViewAsistencia.Refresh();
        }
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            MostrarEmpleados();
            cargarAsistencia();
            MostrarAsistencia();
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            //va tomando de empleados y lo guarda en empleado
            foreach (Empleado empleado in empleados)
            {
                foreach (Asistencia asistencia in asistencias)
                {
                    if (empleado.NoEmpleado == asistencia.NoEmpleado)
                    {
                        Reporte reporte = new Reporte();
                        reporte.NombreEmpleado = empleado.NombreCompleto;
                        reporte.Mes = asistencia.Mes;
                        reporte.SueldoMensual = empleado.SueldoHora * asistencia.HorasMes;
                        reportes.Add(reporte);
                    }
                }
            }
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes;
            dataGridViewReporte.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarEmpleados();
            comboBoxEmpleados.DataSource = empleados;
            comboBoxEmpleados.DisplayMember = "NombreCompleto";
        }

        private void comboBoxEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int noEmpleado = Convert.ToInt16(comboBoxEmpleados.SelectedValue);

            Empleado empleadoEncontrado = empleados.Find(c => c.NoEmpleado == noEmpleado);

            label1.Text = empleadoEncontrado.NombreCompleto;
        }
    }
} 
