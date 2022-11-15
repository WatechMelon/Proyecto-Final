using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.Clientes;
using Vista.Cliente;

namespace Vista
{
    public partial class ClienteMenu : Form
    {
        Registro registro;
        LoginCliente loginCliente;
        public ClienteMenu()
        {
            loginCliente = new LoginCliente();
            registro = new Registro();
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            registro.ShowDialog();
            this.Show();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginCliente.ShowDialog();
            this.Show();
        }
    }
}
