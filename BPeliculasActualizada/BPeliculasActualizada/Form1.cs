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
            var p = new Persona();
            p.Nombre = "Juan";
            p.Apellido= "Perez";
            p.FechaNacimiento = DateTime.Now.AddYears(-25);
            p.Nacionalidad = "Argentino";

            var mapper = new PersonaMapper();
            mapper.Grabar(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mapper = new PersonaMapper();
            var id = new Guid("5c5740a6-2091-4346-afa6-383ec33cc027");

            var p = mapper.ObtenerUna(id);

            p.Nombre = "Juan Alberto";

            mapper.Grabar(p);

        }
    }
}
