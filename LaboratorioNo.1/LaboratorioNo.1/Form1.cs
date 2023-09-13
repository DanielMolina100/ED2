using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioNo._1
{
    public partial class Form1 : Form
    {
        List<TipoPersona> Personas = new List<TipoPersona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            string BusquedaPerson = TBBuscar.Text;
            DGVVerPersonas.Columns.Clear();
            DGVVerPersonas.Columns.Add("Nombre", "name");
            DGVVerPersonas.Columns.Add("DPI", "dpi");
            DGVVerPersonas.Columns.Add("Fecha Cumpleaños", "fecha cumpleaños");
            DGVVerPersonas.Columns.Add("Direccion", "direccion");
            for (int i = 0; i < Personas.Count; i++)
            {
                if (BusquedaPerson == Personas[i].Name)
                {
                    DGVVerPersonas.Rows.Add(Personas[i].Name, Personas[i].dpi, Personas[i].dateBirth, Personas[i].address);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BBuscar.Enabled = true;
            TBBuscar.Enabled = true;    
            TipoPersona Deserealizacion = new TipoPersona();
            string NombreArchivo = @"C:\Users\josda\OneDrive\Documentos\Labs_Estructuras_II\datos.csv";
            try
            {
                using (StreamReader leer = new StreamReader(NombreArchivo))
                {
                    string linea;
                    while ((linea = leer.ReadLine()) != null)
                    {
                        string[] Datos = linea.Split(';');
                        Deserealizacion = JsonConvert.DeserializeObject<TipoPersona>(Datos[1]);
                        if (Datos[0] == "INSERT")
                        {
                            Personas.Add(Deserealizacion);
                        }
                        else if (Datos[0] == "PATCH")
                        {

                            for (int i = 0; i < Personas.Count; i++)
                            {
                                if (Deserealizacion.Name == Personas[i].Name && Deserealizacion.dpi == Personas[i].dpi)
                                {
                                    Personas[i].dateBirth = Deserealizacion.dateBirth;
                                    Personas[i].address = Deserealizacion.address;
                                }
                            }
                        }
                        else
                        {
                            for (int i = 0; i < Personas.Count; i++)
                            {
                                if (Deserealizacion.Name == Personas[i].Name && Deserealizacion.dpi == Personas[i].dpi)
                                {
                                    Personas.RemoveAt(i);
                                }
                            }
                        }

                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar el archivo");
            }
        }
    }
}
