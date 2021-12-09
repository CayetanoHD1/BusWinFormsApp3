using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;
using CapaEntidades;

using CapaDatos;

namespace BusWinFormsApp3
{
    public partial class ventana1 : Form
    {
        bool t = false;
        private B_Informacion date= new B_Informacion();
        public ventana1()
        {
            InitializeComponent();

        }

        public void logear()
        {
             
                try
                {
                    FrmPrincipal win2 = new FrmPrincipal();

                    if (string.IsNullOrWhiteSpace(caja_correo.Text)|| string.IsNullOrEmpty(caja_pass.Text))
                    {
                        MessageBox.Show("Revisa que Los Campos esten Correctamente", "Advertencia");


                    }
                     
                   /* if (cmb_Rol.Text == "Usuario")
                     {

                         win2.btnVincular.Visible = false;
                         win2.Btb_conductor.Visible = false;
                        win2.Show();
                        






                     }*/
                else
                {

                        E_informacion2 info = date.logger(caja_correo.Text, caja_pass.Text, cmb_Rol.SelectedItem.ToString());
                   if (info != null)
                   {
                        if (info.Rol == "USUARIO")
                        {
                            win2.btnVincular.Visible = false;
                            win2.Btb_conductor.Visible = false;
                            MessageBox.Show("Welcome:" + info.Nombre, "Informacion");

                            this.Hide();
                            win2.Nombre = info.Nombre;


                            win2.Show();


                        }
                        else
                        {

                            MessageBox.Show("Welcome:" + info.Nombre, "Informacion");

                            this.Hide();
                            win2.Nombre = info.Nombre;


                            win2.Show();
                        }


                   }
                      else
                      {
                         MessageBox.Show("Datos Incorrectos", "Informacion");
                      }


                    }

                   

                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ha ocurrido Un Error Revisa que los Campos Esten Correctos", "Informacion");
                }

            
            
           
        }
       

        

        private void Form1_Load(object sender, EventArgs e)
        {
           /* con.Open();
            MessageBox.Show("Test");*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maximizar_v1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maximizar_v1.Visible = false;
            restaurar_v1.Visible = true;
            caja_correo.Width = 600;
            caja_pass.Width = 600;
            cmb_Rol.Width = 600;
            lbl1.Font = new Font(lbl1.Font.Name, 20);
            lblp.Font = new Font(lblp.Font.Name, 20);
            lbl2.Font = new Font(lbl2.Font.Name, 20);
            lbl3.Font = new Font(lbl3.Font.Name, 20);
            btn2.Width = 97;
            Ok.Width = 97;
        }

        private void restaurar_v2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar_v1.Visible = false;
            maximizar_v1.Visible = true;
            lbl1.Font = new Font(lbl1.Font.Name, 15);
            lbl2.Font = new Font(lbl2.Font.Name, 15);
            lblp.Font = new Font(lblp.Font.Name, 15);
            lbl3.Font = new Font(lbl3.Font.Name, 15);
            caja_correo.Width = 289;
            caja_pass.Width = 289;
            cmb_Rol.Width = 289;
            

        }

        private void minimizar_v2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            logear();
            
        }
    }
}
