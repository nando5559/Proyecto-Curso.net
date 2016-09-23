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
    public partial class peliculasForm2 : Form
    {
        public peliculasForm2()
        {
            InitializeComponent();
        }

        private void peliculasForm2_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NombreActores1;
            string ApellidoActores1;
            string NombreActores2;
            string ApellidoActores2;
            string NombrePeliD;
            string GeneroD;
            int AnioEstrenoD;
             
            NombrePeliD = textBox1.Text;
            GeneroD = textBox2.Text;
            AnioEstrenoD = Convert.ToInt32(textBox3.Text);

          
			 NombreActores1 = textBox4.Text;
             ApellidoActores1=textBox5.Text;
             NombreActores2= textBox6.Text;
             ApellidoActores2 = textBox7.Text;

            
              DatosPeliculas1.Rows.Add(NombrePeliD, AnioEstrenoD, GeneroD, NombreActores1, ApellidoActores1, NombreActores2, ApellidoActores2);
			
            
       
     

           

            Genero genero1 = new Genero();
            genero1.Descripcion = GeneroD;
           Persona persona1 = new Persona();
           persona1.Nombre = NombreActores1;
           persona1.Apellido = ApellidoActores1;
           Persona persona2 = new Persona();
           persona2.Nombre = NombreActores2;
           persona2.Apellido = ApellidoActores2;
            Pelicula peli = new Pelicula();
            peli.Nombre = NombrePeliD;
            peli.Genero = genero1;
            peli.AnioEstreno = AnioEstrenoD;
            peli.Actores.Add(persona1);
            peli.Actores.Add(persona2);
         
            PeliculaMapper peliMapper = new PeliculaMapper();
            peliMapper.Grabar(peli);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatosPelicula1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
