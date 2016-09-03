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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona1 =new Persona();
            persona1.Nombre = "Will";
            persona1.Apellido = "Smith";

            var genero = new Genero();
            genero.Descripcion = "Ciencia ficcion";

            Pelicula pelicula1 = new Pelicula();
            pelicula1.Nombre = "Dia de la independencia";
            pelicula1.AnioEstreno = 12 / 06 / 2016;
            pelicula1.Actores.Add(persona1);
            pelicula1.Genero = genero;


            var pm = new PeliculaMapper();
            pm.Grabar(pelicula1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var pf = new PersonasForm();
            pf.Show();
        }
    }
}
