using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace Presentacion
{
    public partial class FrmTablerocs : Form
    {
        public string nombre;
        B_Informacion cap = new B_Informacion();
        public FrmTablerocs()
        {
            InitializeComponent();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cargar()
        {
            var tab = cap.ContarU(new Tablero());
            label10.Text = tab.Conductor;
            label6.Text = tab.Bus;
            labelRtotal.Text = tab.RutaD;
            label1RDtotal.Text = tab.RutaO;




        }

        private void FrmTablerocs_Load(object sender, EventArgs e)
        {
            //name.Text = "hola"+nombre;
            cargar();

        }

         
    }
}
