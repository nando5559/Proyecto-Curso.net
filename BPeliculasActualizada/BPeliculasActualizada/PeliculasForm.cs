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
    public partial class PeliculasForm : Form
    {
        public PeliculasForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NombrePeli, 
             Genero, Actores, Directores;
            int  AnioEstrenoD;
            NombrePeli = textBox1.Text;
            GeneroD = Convert.ToString(textBox2.Text);
            AnioEstrenoD = Convert.ToInt32(textBox3.Text);
            Actores = textBox4.Text;
            Directores = textBox5.Text;
            DatosPeliculas.Rows.Add(NombrePeli, GeneroD,AnioEstrenoD,ActoresD,DirectoresD);

            Pelicula peli = new Pelicula();
            peli.Nombre = NombrePeli;
            peli.Genero = GeneroD;
            peli.AnioEstreno = Convert.ToInt32(AnioEstrenoD);
            peli.Actores = ActoresD;
            peli.Actores = DirectoresD;
           PeliculaMapper peliMapper = new PeliculaMapper();
            peliMapper.Grabar(peli);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public object GeneroD { get; set; }

        public object AnioEstrenoD { get; set; }

        public object ActoresD { get; set; }

        public object DirectoresD { get; set; }
    }
}
