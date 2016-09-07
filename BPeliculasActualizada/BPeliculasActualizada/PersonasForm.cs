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

namespace BPeliculasActualizada
{
    public partial class PersonasForm : Form
    {
        public PersonasForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            textBox3.Text="";

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
    }
}
