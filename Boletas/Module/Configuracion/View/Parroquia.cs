using System;
using Boletas.View;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletas.Module.Configuracion.View
{
    public partial class Parroquia : Form
    {
        public Parroquia()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();
        

        private void Parroquia_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bd.SelectString("Select nombre from parroquia where id = 1").ToString();
            txtDireccion.Text = bd.SelectString("Select direccion from parroquia where id = 1").ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                string actualizar = "update parroquia set nombre = '" + txtNombre.Text + "', direccion = '" + txtDireccion.Text + "' where id = 1";

                if (bd.ExecuteCommand(actualizar))
                {
                    MessageBox.Show("Registro actualizado correctamente", "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Debe escribir el nombre de la Parroquia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
