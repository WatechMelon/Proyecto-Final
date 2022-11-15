using Acceso_a_Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Repartidor;

namespace Vista.He
{

    public partial class LoginRepartidor : Form
    {
        Pedidos pedidos;
        public LoginRepartidor()
        {
            InitializeComponent();
            pedidos = new Pedidos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPass.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int ID_Repartidor = Convert.ToInt32(txtLogin.Text);
            string Pass = txtPass.Text;

            try
            {
                Controlador ctrl = new Controlador();

                string respuesta = ctrl.ctrlRepartidor(ID_Repartidor, Pass);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Hide();
                    pedidos.ShowDialog();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
