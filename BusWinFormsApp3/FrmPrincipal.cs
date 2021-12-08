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

        public FrmPrincipal()
        {

            InitializeComponent();
            




        } 



        private void Form2_Load(object sender, EventArgs e)
        {
            name.Text = Nombre;

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

         

        

        private void Abrirhija(object formhija)
        {
            if (this.panel_Centrar.Controls.Count>0)
            {
                this.panel_Centrar.Controls.RemoveAt(0);
                Form v = formhija as Form;
                v.TopLevel = false;
                v.Dock = DockStyle.Fill;
                this.panel_Centrar.Controls.Add(v);
                this.panel_Centrar.Tag = v;
                v.Show();
            }
           
            
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
        private void Abrirhija2(object formhija2)
        {
            if (this.panel_Centrar.Controls.Count > 0)
            {
                this.panel_Centrar.Controls.RemoveAt(0);
                Form v2 = formhija2 as Form;
                v2.TopLevel = false;
                v2.Dock = DockStyle.Fill;
                this.panel_Centrar.Controls.Add(v2);
                this.panel_Centrar.Tag = v2;
                v2.Show();
            }


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
            }
        }
        private void mostrar_Tick(object sender, EventArgs e)
        {
            if (panel_Laterar.Width >= 206)
            {
                this.mostrar.Enabled = false;


            }
            if (panel_Laterar.Width <= 206)

            {
                this.panel_Laterar.Width = panel_Laterar.Width + 20;

            }
        }





       

        private void menu_Click(object sender, EventArgs e)
        {
            
            
            if (panel_Laterar.Width >= 206)
            {
               this.timerOcultar.Enabled = true;

                auto.Visible = false;
                opcion2.Visible = true;

            }
            if (panel_Laterar.Width <= 60)
            {
                 this.mostrar.Enabled = true;
                auto.Visible = true;
                opcion2.Visible = false;

            }
           
            
                        
         


        }

        
       

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Abrirhija3(object formhija3)
        {
            if (this.panel_Centrar.Controls.Count > 0)
            {
                this.panel_Centrar.Controls.RemoveAt(0);
                Form frmssss = formhija3 as Form;
                frmssss.TopLevel = false;
                frmssss.Dock = DockStyle.Fill;
                this.panel_Centrar.Controls.Add(frmssss);
                this.panel_Centrar.Tag = frmssss;
                frmssss.Show();
            }


        }

        private void btnVincular_Click(object sender, EventArgs e)
        {
            Abrirhija3(new FrmVincular());
        }
        private void Abrirhija4(object formhija3)
        {
            if (this.panel_Centrar.Controls.Count > 0)
            {
                this.panel_Centrar.Controls.RemoveAt(0);
                Form frmsss = formhija3 as Form;
                frmsss.TopLevel = false;
                frmsss.Dock = DockStyle.Fill;
                this.panel_Centrar.Controls.Add(frmsss);
                this.panel_Centrar.Tag = frmsss;
                frmsss.Show();
            }


        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            Abrirhija4(new FrmStop());
        }

        private void name_Click(object sender, EventArgs e)
        {

        }
    }
}
