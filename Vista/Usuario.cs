using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vista.He;

namespace Vista
{
    public partial class Usuario : Form
    {
        ClienteMenu clienteMenu;
        LoginRepartidor loginRepartidor;
        LoginHe loginHe;
        public Usuario()
        {
            InitializeComponent();
            clienteMenu = new ClienteMenu();
            loginRepartidor = new LoginRepartidor();
            loginHe = new LoginHe();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            clienteMenu.ShowDialog();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginRepartidor.ShowDialog();
            this.Hide();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginHe.ShowDialog();
            this.Hide();
        }
    }
}
