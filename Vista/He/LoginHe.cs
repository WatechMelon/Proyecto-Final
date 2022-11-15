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

namespace Vista.He
{
   
    public partial class LoginHe : Form
    {
        ModHuerta modHuerta;
        string email = "huerta@gmail.com";
        string pass = "he123";
        public LoginHe()
        {
            InitializeComponent();
            modHuerta = new ModHuerta();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == email && txtPass.Text == pass)
            {
                this.Hide();
                modHuerta.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email o contraseña invalidos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtPass.Text = "";
        }
    }
}
