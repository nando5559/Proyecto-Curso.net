using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Reglas;
using Newtonsoft.Json;
namespace BPeliculasActualizada
{
    public partial class PersonasForm : Form
    {
       int posicion;
       
        public PersonasForm()
        {
            InitializeComponent();

                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                string NombreData, ApellidoData;
                DateTime FechaDeNacimientoData;
                NombreData = textBox1.Text;
                ApellidoData = textBox2.Text;
                FechaDeNacimientoData = Convert.ToDateTime(textBox3.Text);

               
                    DatosPersonas.Rows.Add(NombreData, ApellidoData, FechaDeNacimientoData);
                   
                
                Persona persona1 = new Persona();
                persona1.Nombre = NombreData;
                persona1.Apellido = ApellidoData;
                persona1.FechaNacimento = FechaDeNacimientoData;

                PersonaMapper pMapper = new PersonaMapper();
                pMapper.Grabar(persona1);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
            catch (AplicattionException ex)
            {

                MessageBox.Show(ex.Message);
            }
          
            
        }

        private void PersonasForm_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatosPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void DatosPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         // posicion = DatosPersonas.CurrentRow.Index;

          
            //textBox1.Text = DatosPersonas[1,posicion].Value.ToString();
          //  textBox2.Text = DatosPersonas[2 ,posicion].Value.ToString();
           // textBox3.Text = DatosPersonas[3,posicion].Value.ToString();
         
          textBox1.Text = DatosPersonas.CurrentRow.Cells["Nombre"].Value.ToString();
     textBox2.Text = DatosPersonas.CurrentRow.Cells["Apellido"].Value.ToString();
      textBox3.Text = DatosPersonas.CurrentRow.Cells["FechaDeNacimiento"].Value.ToString();
     
      
            }

        private void button2_Click(object sender, EventArgs e)
        {
           
            string NombreData, ApellidoData;
            DateTime FechaDeNacimientoData;
            NombreData = textBox1.Text;
            ApellidoData = textBox2.Text;
            FechaDeNacimientoData = Convert.ToDateTime(textBox3.Text);
          var Nombre=  DatosPersonas.CurrentRow.Cells["Nombre"].Value = textBox1.Text;
           var Apellido= DatosPersonas.CurrentRow.Cells["Apellido"].Value = textBox2.Text;
           var FechaNac= DatosPersonas.CurrentRow.Cells["FechaDeNacimiento"].Value = textBox3.Text;
     

            Persona persona1 = new Persona();
            persona1.Nombre = Nombre.ToString();
            persona1.Apellido = Apellido.ToString();
            persona1.FechaNacimento = Convert.ToDateTime(FechaNac);

           PersonaMapper pMapper = new PersonaMapper();
           pMapper.Grabar(persona1);
           textBox1.Text = "";
           textBox2.Text = "";
           textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
      
         
         DatosPersonas.Rows.RemoveAt(posicion);
        
       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        }
    }

