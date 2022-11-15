using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_a_Datos;
using Negocio;
using Vista.Clientes;

namespace Vista.Usuarios.Productos
{


    public partial class ProductosE : Form
    {
        Hace pedido;
        LoginCliente log;
        public ProductosE()
        {

            InitializeComponent();

            pedido = new Hace();
            log = new LoginCliente();
          


        }

     

        private void Estaciones_Load(object sender, EventArgs e)
        {

        }


        private void btnAjoO_Click(object sender, EventArgs e)
        {
        }

        private void txtLechuga_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLechugaP_Click(object sender, EventArgs e)
        {
        }

        private void btnPorotoVEV_Click(object sender, EventArgs e)
        {
        }

        private void btnApioV_Click(object sender, EventArgs e)
        {
        }

        private void btnHabasO_Click(object sender, EventArgs e)
        {
        }

        private void btnArvejasO_Click(object sender, EventArgs e)
        {
        }

        private void btnTomateI_Click(object sender, EventArgs e)
        {
        }

        private void btnAcelgaV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRepolloV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCebollinV_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPapaV_Click(object sender, EventArgs e)
        {
           
        }

        private void btnZanahoriaV_Click(object sender, EventArgs e)
        {
          
        }

        private void btnCebollaV_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChocloP_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPimentonI_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBetarragaIP_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBerenjenaP_Click(object sender, EventArgs e)
        {
          
        }

        private void btnFrutillaO_Click(object sender, EventArgs e)
        {
           
        }

        private void btnPorotoV_Click(object sender, EventArgs e)
        {
           
          
        }

        
        private void btnLechugaA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Lechuga");
            pedido.CantProductos.Add(txtLechuga.Text);
        }

        private void btnPorotoVA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("PorotosVerdes");
            pedido.CantProductos.Add(txtPorotoV.Text);
        }

        private void btnApioA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Apio");
            pedido.CantProductos.Add(txtApio.Text);
        }

        private void btnHabasA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Habas");
            pedido.CantProductos.Add(txtHabas.Text);
        }

        private void btnArvejasA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Arvejas");
            pedido.CantProductos.Add(txtArvejas.Text);
        }

        private void btnTomateA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Tomate");
            pedido.CantProductos.Add(txtTomate.Text);
        }

        private void btnAjoA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Ajo");
            pedido.CantProductos.Add(txtAjo.Text);
        }

        private void btnAcelgaA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Acelga");
            pedido.CantProductos.Add(txtAcelga.Text);
        }

        private void btnRepolloA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Repollo");
            pedido.CantProductos.Add(txtRepollo.Text);
        }

        private void btnCebollinA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Cebollin");
            pedido.CantProductos.Add(txtCebollin.Text);
        }

        private void btnPapaA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Papa");
            pedido.CantProductos.Add(txtPapa.Text);
        }

        private void btnZanahoriaA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Zanahoria");
            pedido.CantProductos.Add(txtZanahoria.Text);
        }

        private void btnCebollaA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Cebolla");
            pedido.CantProductos.Add(txtCebolla.Text);
        }

        private void btnChocloA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Choclo");
            pedido.CantProductos.Add(txtChoclo.Text);
        }

        private void btnPimentonA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Pimenton");
            pedido.CantProductos.Add(txtPimenton.Text);
        }

        private void btnBetarragaA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Remolacha");
            pedido.CantProductos.Add(txtBetarraga.Text);
        }

        private void btnBerenjenaA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Berenjena");
            pedido.CantProductos.Add(txtBerenjena.Text);
        }

        private void btnFrutillaA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Frutilla");
            pedido.CantProductos.Add(txtFrutilla.Text);
        }

        private void btnPorotoA_Click(object sender, EventArgs e)
        {
            pedido.Producto.Add("Porotos");
            pedido.CantProductos.Add(txtPoroto.Text);
        }

        private void comboPago_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBerrataga_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnComprar_Click(object sender, EventArgs e)
        { 
            if (comboPago.Text == "Elegir metodo de pago")
            {
                MessageBox.Show("Metodo de pago no seleccionado");
            }
            else
            {
                Modelo modelo = new Modelo();
                pedido.MetodoPago = comboPago.Text;
                pedido.FechaEntrega = Convert.ToDateTime(dateEntrega.Text);


                modelo.PedidoE(pedido);

                int i = 0;
                foreach (string produ in pedido.Producto) {
                    
                    pedido.Productounitario = produ;
                    pedido.Cantunitaria = pedido.CantProductos[i];
                    pedido.Rut = log.Rut;
                    modelo.Hace(pedido);
                    i++;
                }


                MessageBox.Show("Pedido hecho con exito");
            }
        }
    }
}
