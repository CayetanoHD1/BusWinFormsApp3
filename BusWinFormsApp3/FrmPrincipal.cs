using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;


namespace BusWinFormsApp3
{

    public partial class FrmPrincipal : Form
    {
        public string Nombre { get; set; }
        public Form  Activado = null;
        B_Informacion cap = new B_Informacion();
       


        public FrmPrincipal()
        {

            InitializeComponent();

            var();







        } 
        private void var()
        {
           // tableLayoutPanel1.Visible = true;
        }



        private void Form2_Load(object sender, EventArgs e)
        {   name.Text =$"Welcome! { Nombre}";
            cargar();
           
           

        }
        private void cargar()
        {
           /* var tab = cap.ContarU(new Tablero());
            labelCtotal.Text = tab.Conductor;
            labelBtotal.Text = tab.Bus;
            labelRtotal.Text = tab.RutaD;
            label1RDtotal.Text = tab.RutaO;*/
            



        }
         

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ventana1 vv = new ventana1();
            vv.Show();
        }

        private void maximizar_v2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizar_v2.Visible = false;
            restaurar_v2.Visible = true;

        }

        private void agrandar_v2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar_v2.Visible = false;
            maximizar_v2.Visible = true;
        }

        private void minimizar_v2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {

            

            Abrirhija2(new ventana5());

        }

         

    
        
        private void Abrirhija(FrmRuta FormHijo)
        {
             
                if (Activado != null)
                    Activado.Close();
                 Activado = FormHijo;
                FormHijo.TopLevel = false;
                FormHijo.Dock = DockStyle.Fill;
                panel_Centrar.Controls.Add(FormHijo);
                panel_Centrar.Tag = FormHijo;
                FormHijo.BringToFront();
                 FormHijo.Show();
            
           
            
        }
        private void Abrirhija1(object formhija1)
        {
            if (this.panel_Centrar.Controls.Count > 0)
            {
                this.panel_Centrar.Controls.RemoveAt(0);
                Form v1 = formhija1 as Form;
                v1.TopLevel = false;
                v1.Dock = DockStyle.Fill;
                this.panel_Centrar.Controls.Add(v1);
                this.panel_Centrar.Tag = v1;
                v1.Show();
            }


        }
       

        private void Abrirhija2(ventana5 Hija2)
        {
            if ( Activado != null)
              Activado.Close();
             Activado =  Hija2;
            Hija2.TopLevel = false;
            Hija2.Dock = DockStyle.Fill;
            panel_Centrar.Controls.Add(Hija2);
            panel_Centrar.Tag = Hija2;
             Hija2.BringToFront();
             Hija2.Show();


        }

        private void Btn_Ruta_Click(object sender, EventArgs e)
        {
            
            Abrirhija(new FrmRuta());
        }

        private void Btb_conductor_Click(object sender, EventArgs e)
        {
             
            Abrirhija1(new FrmDriver());
        }

        private void timerOcultar_Tick(object sender, EventArgs e)
        {
            if (panel_Laterar.Width<=60)
            {
                this.timerOcultar.Enabled=false;
                   
            }
            else
            {
                this.panel_Laterar.Width = panel_Laterar.Width - 20;

                this.panel_Centrar.Width = panel_Centrar.Width + 20;


            }

        }
        private void mostrar_Tick(object sender, EventArgs e)
        {
            if (panel_Laterar.Width >= 190)
            {
                this.mostrar.Enabled = false;


            }
            if (panel_Laterar.Width <= 190)

            {
                this.panel_Laterar.Width = panel_Laterar.Width + 20;
                this.panel_Centrar.Width  = panel_Centrar.Width - 20;




            }
        } 
        
       

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Abrirhija3(FrmVincular formhija3)
        {
            if (Activado != null)
                Activado.Close();
            Activado = formhija3;
            formhija3.TopLevel = false;
            formhija3.Dock = DockStyle.Fill;
            panel_Centrar.Controls.Add(formhija3);
            panel_Centrar.Tag = formhija3;
            formhija3.BringToFront();
            formhija3.Show();


        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
           
            Abrirhija3(new FrmVincular());
        }
        private void Abrirhija4(FrmStop formhija3)
        {
            if (Activado != null)
                 Activado.Close();
             Activado = formhija3;
            formhija3.TopLevel = false;
            formhija3.Dock = DockStyle.Fill;
            panel_Centrar.Controls.Add(formhija3);
            panel_Centrar.Tag = formhija3;
            formhija3.BringToFront();
            formhija3.Show();


        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            panel_Centrar.Visible = false;

            Abrirhija4(new FrmStop());
        }

        

        

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            if (panel_Laterar.Width >= 206)
            {
                this.timerOcultar.Enabled = true;

                auto1.Visible = false;
                opcion2.Visible = true;

            }
            if (panel_Laterar.Width <= 60)
            {
                this.mostrar.Enabled = true;
                auto1.Visible = true;
                opcion2.Visible = false;

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void auto1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
