using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Reglas;

using Newtonsoft.Json;
using Entidades;
namespace BPeliculasActualizada
{
    public partial class PeliculasForm : Form
    {
      
               
        public PeliculasForm()
        {
            InitializeComponent();
           // PeliculaMapper PeliculaLista = new PeliculaMapper();
          //  DatosPeliculas.DataSource = PeliculaLista.ObtenerTodas();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
          
         
            string NombrePeli;
            string GeneroD;
            int  AnioEstrenoD;
           // string ActoresD;
            NombrePeli = textBox1.Text;
            GeneroD = textBox2.Text;
            AnioEstrenoD = Convert.ToInt32(textBox3.Text);
          // ActoresD = textBox4.Text;
         // var   DirectoresD = textBox5.Text;
            DatosPeliculas.Rows.Add(NombrePeli, AnioEstrenoD,GeneroD );//ActoresD,DirectoresD);
        
              
            Pelicula peli = new Pelicula();
            peli.Nombre = NombrePeli;
           // peli.Genero.
            peli.AnioEstreno = AnioEstrenoD;
          // peli.Actores.Add(ActoresD);

          // peli.Actores = DirectoresD;
           PeliculaMapper peliMapper = new PeliculaMapper();
            peliMapper.Grabar(peli);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

       // public object GeneroD { get; set; }

        public object AnioEstrenoD { get; set; }

        public object ActoresD { get; set; }

        public object DirectoresD { get; set; }

        private void DatosPeliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PeliculasForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    //    private void textBox4_TextChanged(object sender, EventArgs e)
      //  {

       // }

      //  private void textBox5_TextChanged(object sender, EventArgs e)
       // {

      //  }

        public Genero Entidades { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
