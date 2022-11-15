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
using Vista.Usuarios.Productos;

namespace Vista.Clientes
{
    public partial class LoginCliente : Form
    {
        public int Rut;
        public string CI;
        ProductosE compras;
        ProductosT compras2;
        ClienteEmpresa clienteEmpresa;
        ClienteTerminal clienteTerminal;
    
        public LoginCliente()
        {
            InitializeComponent();
            txtLogin.Enabled = false;
            compras = new ProductosE();
            compras2 = new ProductosT();
            clienteEmpresa = new ClienteEmpresa();
            clienteTerminal = new ClienteTerminal();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controlador ctrl = new Controlador();
            CI = txtLogin.Text;
            string Pass = txtPass.Text;
            Rut = Convert.ToInt32(txtLogin.Text);

            if (rdbEmpresa.Checked == true)
            {
                string RespuestaE = ctrl.ctrlLoginEmpresa(Rut, Pass);
                try
                {

                    string RespuestaT = ctrl.ctrlLoginTerminal(CI, Pass);


                    if (RespuestaE.Length > 0)
                    {
                        MessageBox.Show(RespuestaE, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(Convert.ToString(clienteEmpresa.Rut));
                        this.Hide();
                        compras.ShowDialog();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                try
                {

                    string RespuestaT = ctrl.ctrlLoginTerminal(CI, Pass);

                    if (RespuestaT.Length > 0 )
                    {
                        MessageBox.Show(RespuestaT, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        this.Hide();
                        compras2.ShowDialog();
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
            
        
            

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPass.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void rdbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            txtLogin.Enabled = true;
        }

        private void rdbTerminal_CheckedChanged(object sender, EventArgs e)
        {
            txtLogin.Enabled = true;
        }
    }
}
