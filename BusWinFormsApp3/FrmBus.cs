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
    public partial class ventana5 : Form
    {
        public ventana5()
        {
            InitializeComponent();
        }
        

        B_Informacion bus = new B_Informacion();
        public void save()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_marca.Text) || string.IsNullOrWhiteSpace(txt_modelo.Text) || string.IsNullOrWhiteSpace(txt_placa.Text) || string.IsNullOrWhiteSpace(txt_año.Text) || string.IsNullOrWhiteSpace(txt_color.Text))
                {
                    MessageBox.Show("Hay Campos en Blancos", "Informacion");

                }
                else
                { E_InformacionBus date = bus.chekarBus(txt_placa.Text.ToUpper());
                
                    if (date!= null)
                    {
                        if (date.Placa==txt_placa.Text.ToUpper())
                        {
                            MessageBox.Show($"La Placa: {txt_placa.Text} Ya Existe Vinculada Marca: {date.Marca} Modelo: {date.Modelo}");

                        }

                    }
                    else
                    {
                        E_InformacionBus dates = new E_InformacionBus();

                        dates.Marca = txt_marca.Text.ToUpper();
                        dates.Modelo = txt_modelo.Text.ToUpper();
                        dates.Placa = txt_placa.Text.ToUpper();
                        dates.Año = txt_año.Text.ToUpper();
                        dates.Color = txt_color.Text.ToUpper();
                        bus.insertandoBus(dates);
                        MessageBox.Show("Guardado Correctamente", "Infromacion");
                        clear();
                    }

                }
               
                 
                 
                 
                

            }

            catch (Exception ex)
            {
                   MessageBox.Show($"Informacion"+ex);
            }
        }
        public void clear()
        {
            txt_año.Text = "";
            txt_color.Text = "";
            txt_marca.Text = "";
            txt_modelo.Text = "";
            txt_placa.Text = "";
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            save();
            //clear();

        }

        private void txt_año_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
