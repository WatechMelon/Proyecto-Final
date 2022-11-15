using Acceso_a_Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Clientes
{
    public partial class ProductosT : Form
    {
        LoginCliente log;
        Realiza pedido;
        public ProductosT()
        {
            InitializeComponent();
            pedido = new Realiza();
            log = new LoginCliente();
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


                modelo.PedidoT(pedido);


                int i = 0;
                foreach (string produ in pedido.Producto)
                {

                    pedido.Productounitario = produ;
                    pedido.Cantunitaria = pedido.CantProductos[i];
                    pedido.CI = log.CI;
                    modelo.Realiza(pedido);
                    i++;
                }


                MessageBox.Show("Pedido hecho con exito");
            }
        }
    }
}
