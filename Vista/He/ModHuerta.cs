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

namespace Vista.He
{
    public partial class ModHuerta : Form
    {
        Planta he;
        public ModHuerta()
        {
            InitializeComponent();
            he = new Planta();
           

        }

        private void ModHuerta_Load(object sender, EventArgs e)
        {

        }

        private void txtEspecie3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEspecie2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEspecie1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            he.ID_HE = Convert.ToInt32(txtId.Text);

            try
            {
                Controlador ctrl = new Controlador();
                string Respuesta = ctrl.ctrlElegirHuerta(he.ID_HE);

                if (Respuesta.Length > 0)
                {
                    MessageBox.Show(Respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (comboEspecie1.Text == "Elegir Especie" || comboEstado1.Text == "Elegir Estado" || txtMeta1.Text == "")
                    {
                        MessageBox.Show("No puedes dejar cambos obligatorios sin rellenar.");
                    }
                    else if (comboEspecie1.Text != "Elegir Especie")
                    {
                        he.Especie = comboEspecie1.Text;
                        he.EstadoCultivo = comboEstado1.Text; ;
                        he.MetaCultivo = txtMeta1.Text;
                        he.FechaCultivo = Convert.ToDateTime(dateCultivo.Text);
                        he.CantidadCosecha = Convert.ToInt32(txtCant1.Text);
                        MessageBox.Show("Datos actualizados con exito");
                        Controlador controlador = new Controlador();
                        controlador.ctrlHuerta(he);



                    }
                     if ((comboEspecie2.Text != "Elegir Especie") && (comboEstado2.Text == "Elegir Estado" || txtMeta2.Text == ""))
                    {
                        MessageBox.Show("No puedes dejar cambos obligatorios sin rellenar.");
                    }
                    else if (comboEspecie2.Text != "Elegir Especie")
                    {
                        he.Especie = comboEspecie2.Text;
                        he.EstadoCultivo = comboEstado2.Text; ;
                        he.MetaCultivo = txtMeta2.Text;
                        he.FechaCultivo = Convert.ToDateTime(dateCultivo.Text);
                        he.CantidadCosecha = Convert.ToInt32(txtCant2.Text);
                        Controlador controlador = new Controlador();
                        controlador.ctrlHuerta(he);
                        MessageBox.Show("Datos actualizados con exito ");

                    }
                    if ((comboEspecie3.Text != "Elegir Especie") && (comboEstado3.Text == "Elegir Estado" || txtMeta3.Text == ""))
                    {
                        MessageBox.Show("No puedes dejar cambos obligatorios sin rellenar.");
                    }
                    else if (comboEspecie3.Text != "Elegir Especie")
                    {
                        he.Especie = comboEspecie3.Text;
                        he.EstadoCultivo = comboEstado3.Text; ;
                        he.MetaCultivo = txtMeta3.Text;
                        he.FechaCultivo = Convert.ToDateTime(dateCultivo.Text);
                        he.CantidadCosecha = Convert.ToInt32(txtCant3.Text);
                        Controlador controlador = new Controlador();
                        controlador.ctrlHuerta(he);
                        MessageBox.Show("Datos actualizados con exito");

                    }
                    if ((comboEspecie4.Text != "Elegir Especie") && (comboEstado4.Text == "Elegir Estado" || txtMeta4.Text == ""))
                    {
                        MessageBox.Show("No puedes dejar cambos obligatorios sin rellenar.");
                    }
                    else if (comboEspecie4.Text != "Elegir Especie")
                    {
                        he.Especie = comboEspecie4.Text;
                        he.EstadoCultivo = comboEstado4.Text; ;
                        he.MetaCultivo = txtMeta4.Text;
                        he.FechaCultivo = Convert.ToDateTime(dateCultivo.Text);
                        he.CantidadCosecha = Convert.ToInt32(txtCant4.Text);

                        Controlador controlador = new Controlador();
                        controlador.ctrlHuerta(he);
                        MessageBox.Show("Datos actualizados con exito");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
