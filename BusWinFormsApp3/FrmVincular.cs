using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
using CapaEntidades;

namespace BusWinFormsApp3
{
    public partial class FrmVincular : Form
    {
        
        B_Informacion entra = new B_Informacion();
      

        public FrmVincular()
        {
            InitializeComponent();
       
        }
        
        public void validar()
        {
            if (string.IsNullOrWhiteSpace(Cmb_ruta.Text) || string.IsNullOrWhiteSpace(Cmb_chofer.Text) || string.IsNullOrWhiteSpace(Cmb_autobus.Text))
            {
                MessageBox.Show("Dejastes Campos en Blanco","Informacion");

            }
            else
            {
                add();
                ActualizarUsuario();
                ActualizarRuta();
                ActualizarRBus();
                clear();
                cargarMarca();
                cragarRuta();
                cagarChofer();

            }
        }
	

         
        private void clear()
        {
            Cmb_autobus.Text = "";
            Cmb_chofer.Text = "";
            Cmb_ruta.Text = "";
        }
        private void cargarMarca()
        {
            Cmb_autobus.Items.Clear();
            var result = entra.load("SP_Bus_Load");
            foreach (var item in result)
            {
                Cmb_autobus.Items.Add(item);
            }
        }
        private void cragarRuta()
        {
            Cmb_ruta.Items.Clear();

            var result2 = entra.loadR("SP_Ruta_Load");
            foreach (var item in result2)
            {
                Cmb_ruta.Items.Add(item);
            }
        }
       private void cagarChofer()
        {
            Cmb_chofer.Items.Clear();

            var result3 = entra.loadC("SP_Conductor_Load");
            foreach (var item in result3)
            {
                Cmb_chofer.Items.Add(item);
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            Tabla.ClearSelection();
            cargarMarca();
            cragarRuta();
            cagarChofer();
            MostrarBusqueda("");

        }
        public void MostrarBusqueda(string buscar)
        {
            B_Informacion cap = new B_Informacion();
            Tabla.DataSource = cap.lista(buscar);
            Tabla.ClearSelection();

        }
        public void add()
        {
            E_Vincular ad = new E_Vincular();

            ad.Chofer = Cmb_chofer.Text.Split("-")[1];
            ad.Ruta = Cmb_ruta.Text.Split("-")[1];
            ad.Autobus = Cmb_autobus.Text.Split("-")[1];
            entra.Insert(ad);
            MessageBox.Show("Agregado Exitosamente","Informacion");
            MostrarBusqueda("");


        }
        public void ActualizarUsuario()
        {
            E_Vincular v = new E_Vincular();
            v.Id = Cmb_chofer.Text.Split("-")[1];
            entra.uptateU(v);
            

        }
        public void ActualizarRuta()
        {
            E_InformacionR r = new E_InformacionR();
            r.Id  = Cmb_ruta.Text.Split("-")[1];
            entra.UpdateRuta(r);
        }
        public void ActualizarRBus()
        {
            E_InfromacionB b = new E_InfromacionB();
            b.Id = Cmb_autobus.Text.Split("-")[1];
            entra.UpdateBus(b);
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            validar();
            
        }

        
    }
}
