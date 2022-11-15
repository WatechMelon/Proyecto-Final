using Acceso_a_Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Repartidor
{
    
    public partial class Pedidos : Form
    {

        Modelo modelo;
        public Pedidos()
        {
            InitializeComponent();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modelo = new Modelo();
           
            int NumPedido = Convert.ToInt32(txtNum.Text);

            dgvPedidos.DataSource = modelo.verTabla(NumPedido);
            

            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Controlador controlador = new Controlador();
            Esta esta = new Esta();
            string opt = comboEstado.Text;
            if (txtNum.Text == "")
            {
                MessageBox.Show("No has seleccionado ningun pedido");
            }
            else
            {


                switch (opt)
                {
                    case "Pedido Cancelado":
                        esta.ID_Estado = 0;
                        esta.FechaInicio = DateTime.Today;
                        esta.NumPedido = Convert.ToInt32(txtNum.Text);
                        controlador.ctrlEstadoPedido(esta);
                        MessageBox.Show("Estado actualizado con exito");

                        break;

                    case "Esperando Aprobacion":
                        esta.ID_Estado = 1;
                        esta.FechaInicio = DateTime.Today;
                        esta.NumPedido = Convert.ToInt32(txtNum.Text);
                        controlador.ctrlEstadoPedido(esta);
                        MessageBox.Show("Estado actualizado con exito");
                        break;

                    case "Armando el pedido":
                        esta.ID_Estado = 2;
                        esta.FechaInicio = DateTime.Today;
                        esta.NumPedido = Convert.ToInt32(txtNum.Text);
                        controlador.ctrlEstadoPedido(esta);
                        MessageBox.Show("Estado actualizado con exito");
                        break;

                    case "Pedido despachado":
                        esta.ID_Estado = 3;
                        esta.FechaInicio = DateTime.Today;
                        esta.NumPedido = Convert.ToInt32(txtNum.Text);
                        controlador.ctrlEstadoPedido(esta);
                        MessageBox.Show("Estado actualizado con exito");
                        break;
                    case "En ruta":
                        esta.ID_Estado = 4;
                        esta.FechaInicio = DateTime.Today;
                        esta.NumPedido = Convert.ToInt32(txtNum.Text);
                        controlador.ctrlEstadoPedido(esta);
                        MessageBox.Show("Estado actualizado con exito");
                        break;
                    case "Recibido":
                        esta.ID_Estado = 5;
                        esta.FechaInicio = DateTime.Today;
                        esta.NumPedido = Convert.ToInt32(txtNum.Text);
                        controlador.ctrlEstadoPedido(esta);
                        MessageBox.Show("Estado actualizado con exito");
                        break;
                    case "No recibido":
                        esta.ID_Estado = 6;
                        esta.FechaInicio = DateTime.Today;
                        esta.NumPedido = Convert.ToInt32(txtNum.Text);
                        controlador.ctrlEstadoPedido(esta);
                        MessageBox.Show("Estado actualizado con exito");
                        break;

                    default:
                        MessageBox.Show("No has seleccionado ningun estado");
                        break;



                }
            }





        }  
     
    }
}
