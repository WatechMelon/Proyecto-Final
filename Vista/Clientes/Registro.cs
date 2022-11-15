using System;
using System.Windows.Forms;
using Acceso_a_Datos;
using Negocio;


namespace Vista.Cliente
{
    public partial class Registro : Form
    {
        public Registro()
        {

            InitializeComponent();
            txtCI.Enabled = false;
            txtPriNom.Enabled = false;
            txtSegNom.Enabled = false;
            txtPriApe.Enabled = false;
            txtSegApe.Enabled = false;
            txtRut.Enabled = false;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void rdbEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            txtCI.Enabled = false;
            txtPriNom.Enabled = false;
            txtSegNom.Enabled = false;
            txtPriApe.Enabled = false;
            txtSegApe.Enabled = false;
            txtRut.Enabled = true;
        }

        private void rdbTerminal_CheckedChanged(object sender, EventArgs e)
        {
            txtCI.Enabled = true;
            txtPriNom.Enabled = true;
            txtSegNom.Enabled = true;
            txtPriApe.Enabled = true;
            txtSegApe.Enabled = true;
            txtRut.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCI.Text = "";
            txtPriApe.Text = "";
            txtPriNom.Text = "";
            txtSegApe.Text = "";
            txtSegNom.Text = "";
            txtRut.Text = "";
            txtBarrio.Text = "";
            txtNum.Text = "";
            txtEsquina.Text = "";
            txtCalle.Text = "";
            txtEmail.Text = "";
            txtPass.Text = "";
            txtTel.Text = "";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(rdbTerminal.Checked || rdbEmpresa.Checked)
            {
                if(rdbTerminal.Checked && (txtBarrio.Text == "" || txtEsquina.Text == "" || txtCalle.Text == "" || txtEmail.Text == "" || txtTel.Text == "" ||
                    txtPass.Text == "" || txtNum.Text == "" || txtCI.Text == "" || txtPriNom.Text == "" || txtPriApe.Text == ""))
                {
                    MessageBox.Show("Hay campos obligatorios sin rellenar.");
                }
                else if(rdbTerminal.Checked){

                    ClienteTerminal clienteTerminal = new ClienteTerminal();

                    clienteTerminal.Email = txtEmail.Text;
                    clienteTerminal.Pass = txtPass.Text;
                    clienteTerminal.Telefono = Convert.ToInt32(txtTel.Text);
                    clienteTerminal.Barrio = txtBarrio.Text;
                    clienteTerminal.Numero = Convert.ToInt32(txtNum.Text);
                    clienteTerminal.Esquina = txtEsquina.Text;
                    clienteTerminal.Calle = txtCalle.Text;
                    clienteTerminal.CI = txtCI.Text;
                    clienteTerminal.PrimerApellido = txtPriApe.Text;
                    clienteTerminal.PrimerNombre = txtPriNom.Text;
                    clienteTerminal.SegundoApellido = txtSegApe.Text;
                    clienteTerminal.SegundoNombre = txtSegNom.Text;
                    Controlador controlador = new Controlador();
                    controlador.ctrlRegistroTerminal(clienteTerminal);
                    MessageBox.Show("Te has registrado en el sistema exitosamente");
                    Dispose();

                }
                else if (rdbEmpresa.Checked && (txtBarrio.Text == "" || txtEsquina.Text == "" || txtCalle.Text == "" || txtEmail.Text == "" || txtTel.Text == "" ||
                    txtPass.Text == "" || txtNum.Text == "" || txtRut.Text == ""))
                {
                    MessageBox.Show("Hay campos obligatorios sin rellenar.");

                }else if (rdbEmpresa.Checked)
                {
                    ClienteEmpresa clienteEmpresa = new ClienteEmpresa();

                    clienteEmpresa.Rut = Convert.ToInt32(txtRut.Text);
                    clienteEmpresa.Email = txtEmail.Text;
                    clienteEmpresa.Pass = txtPass.Text;
                    clienteEmpresa.Telefono = Convert.ToInt32(txtTel.Text);
                    clienteEmpresa.Barrio = txtBarrio.Text;
                    clienteEmpresa.Numero = Convert.ToInt32(txtNum.Text);
                    clienteEmpresa.Esquina = txtEsquina.Text;
                    clienteEmpresa.Calle = txtCalle.Text;
                    Controlador controlador = new Controlador();
                    controlador.ctrlRegistroEmpresa(clienteEmpresa);
                    MessageBox.Show("Te has registrado en el sistema exitosamente");
                    Dispose();
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún cliente");
                }
                
            }
        }

        private void txtCI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
