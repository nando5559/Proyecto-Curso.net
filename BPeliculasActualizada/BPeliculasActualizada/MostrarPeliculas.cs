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
    public partial class MostrarPeliculas : Form
    {
        public MostrarPeliculas()
        {
            InitializeComponent();
            PeliculaMapper peliculalista = new PeliculaMapper();
            dataGridView1.DataSource = peliculalista.ObtenerTodas();
        }

        private void MostrarPeliculas_Load(object sender, EventArgs e)
        {

        }
    }
}
