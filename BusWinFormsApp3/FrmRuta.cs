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
    public partial class FrmRuta : Form
    {
       public string rutaC;  
        public FrmRuta()
        {
            InitializeComponent();
        }
        E_InformacionR ruta = new E_InformacionR();
        B_Informacion metodo = new B_Informacion();
        private void guardar()
        {
           
            try
            {

                if (string.IsNullOrWhiteSpace(txtRuta.Text))
                {
                    MessageBox.Show("Ruta En Blanco", "Informacion");
                     




                }
                
                else
                {

                        ruta.Ruta = txtRuta.Text.ToUpper();
                        metodo.insertandoRuta(ruta);
                     
                        MessageBox.Show($"{txtRuta.Text} Agregada Exitosamente", "Informacion");
                        txtRuta.Text = "";
                        

                    

                        
                   
                  

                    
                    
                }   


                    
              

               
                
                 
                
                   
                   
                
                
            }
            catch (Exception es)
            {
                MessageBox.Show($"La Ruta {txtRuta.Text} Fue Agregada Anteriolmente !Por Favor Igresar una Valida","Informacion");
            }
        }

        

         

        private void button1_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
