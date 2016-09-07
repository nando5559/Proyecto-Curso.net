using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPeliculasActualizada
{
    public partial class ActoresYDirectoresForm : Form
    {
        public ActoresYDirectoresForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NombreData, ApellidoData;
            DateTime FechaDeNacimientoData;

            NombreData = NombreText.Text;
            ApellidoData = ApellidoText.Text;
            FechaDeNacimientoData = Convert.ToDateTime(FechaDeNacimientoText.Text);
           
        }
    }
}
