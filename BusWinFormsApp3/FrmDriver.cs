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
using CapaEntidades;
using CapaNegocio;

namespace BusWinFormsApp3
{
    public partial class FrmDriver : Form
    {
        public string co,ce;
        public FrmDriver()
        {
            InitializeComponent();
        }

        
        
        B_Informacion metodo = new B_Informacion();
        public void save()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_nombre.Text) || string.IsNullOrWhiteSpace(txt_apellido.Text) || string.IsNullOrWhiteSpace(txt_cedula.Text) || string.IsNullOrWhiteSpace(txt_correo.Text) || string.IsNullOrWhiteSpace(txt_pass.Text) || string.IsNullOrWhiteSpace(cmb_Rol.Text))
                {
                    MessageBox.Show("Has Dejado Campos en Blancos", "Informacion");

                }

                else
                {
                    E_InformacionDriver date = metodo.driverCheck(txt_correo.Text.ToUpper(), txt_cedula.Text.ToUpper());

                    if (date != null)
                    {
                        
                        
                       
                        if (txt_cedula.Text == date.Cedula && txt_correo.Text.ToUpper() == date.Correo)
                        {
                            MessageBox.Show($"La Cedula: {date.Cedula} y Correo: {txt_correo.Text} Existen Anteriolmente", "Advertencia");
                            
                        }
                        if (txt_cedula.Text == date.Cedula)
                        {

                        MessageBox.Show($"La Cedula{date.Cedula} ya fue Agregada", "Advertencia");
                        }
                        if (txt_correo.Text.ToUpper() == date.Correo)
                        {
                             MessageBox.Show($"El correo{date.Correo} Existe Anteriolmente ", "Informacion");

                        }
                       
                        







                    }
                   else
                    {
                        E_InformacionDriver infoDriver = new E_InformacionDriver();


                        infoDriver.Nombre = txt_nombre.Text.ToUpper();
                        infoDriver.Apellido = txt_apellido.Text.ToUpper();
                        infoDriver.Cedula = txt_cedula.Text.ToUpper();
                        infoDriver.Correo = txt_correo.Text.ToUpper();
                        infoDriver.Clave = txt_pass.Text.ToUpper();
                        infoDriver.Nacimiento = DateTime.Parse(fecha.Text);
                        infoDriver.Rol = cmb_Rol.Text.ToUpper();
                        metodo.insertandoDriver(infoDriver);
                        MessageBox.Show("Agregado Exitosamente", "Informacion");
                        clear();

                    }
                }



                















            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error" + ex);
            }








          
            
            
            
            

        }
        
         

        
        public void clear()
        {
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_cedula.Text = "";
            txt_correo.Text = "";
            txt_pass.Text = "";
            cmb_Rol.SelectedItem = null;
        }
         

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana1 lo = new ventana1();
            lo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
          
           


        }
        private void chekfecha( )
        {
            
            

        }
        
    }            
}
