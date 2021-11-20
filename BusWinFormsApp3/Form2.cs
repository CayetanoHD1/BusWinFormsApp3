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

namespace BusWinFormsApp3
{
    
    public partial class ventana2 : Form
    {
         
        public ventana2(/*string nombre*/)
        {
            
            InitializeComponent();
           /* lbl_nombre.Text = nombre;*/
           
           
            
    }   



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

         

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }

        private void panel_Centrar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Abrirhija(object formhija)
        {
            if (this.panel_Centrar.Controls.Count>0)
            {
                this.panel_Centrar.Controls.RemoveAt(0);
                Form frm = formhija as Form;
                frm.TopLevel = false;
                frm.Dock = DockStyle.Fill;
                this.panel_Centrar.Controls.Add(frm);
                this.panel_Centrar.Tag = frm;
                frm.Show();
            }
           
            
        }
        private void Abrirhija1(object formhija1)
        {
            if (this.panel_Centrar.Controls.Count > 0)
            {
                this.panel_Centrar.Controls.RemoveAt(0);
                Form frms = formhija1 as Form;
                frms.TopLevel = false;
                frms.Dock = DockStyle.Fill;
                this.panel_Centrar.Controls.Add(frms);
                this.panel_Centrar.Tag = frms;
                frms.Show();
            }


        }
        private void Abrirhija2(object formhija2)
        {
            if (this.panel_Centrar.Controls.Count > 0)
            {
                this.panel_Centrar.Controls.RemoveAt(0);
                Form frmss = formhija2 as Form;
                frmss.TopLevel = false;
                frmss.Dock = DockStyle.Fill;
                this.panel_Centrar.Controls.Add(frmss);
                this.panel_Centrar.Tag = frmss;
                frmss.Show();
            }


        }

        private void Btn_Ruta_Click(object sender, EventArgs e)
        {
            Abrirhija(new ventana4());
        }

        private void Btb_conductor_Click(object sender, EventArgs e)
        {
            Abrirhija1(new ventana3());
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





        private void auto_Click(object sender, EventArgs e)
        {
            
        }

        private void panel_Laterar_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
                Form frmsss = formhija3 as Form;
                frmsss.TopLevel = false;
                frmsss.Dock = DockStyle.Fill;
                this.panel_Centrar.Controls.Add(frmsss);
                this.panel_Centrar.Tag = frmsss;
                frmsss.Show();
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Abrirhija3(new Form4());

        }
    }
}
