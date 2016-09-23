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
    public partial class MostrarPersonasForm : Form
    {
        public MostrarPersonasForm()
        {
            InitializeComponent();
            PersonaMapper personaslista = new PersonaMapper();
            MostrarPersonas.DataSource = personaslista.ObtenerTodas();
        }

        private void MostrarPersonasForm_Load(object sender, EventArgs e)
        {
           
        }

        private void MostrarPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
