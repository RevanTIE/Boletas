using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletas.Module.Catalogo.View.Estados
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void ModificarEstados(string idEstado)
        {
            txtId.Text = idEstado;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                string actualizar = "update estados set nombre = '" + txtNombre.Text + "' where id = '" + txtId.Text + "'";

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
                MessageBox.Show("Debe escribir el nombre del Estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bd.SelectString("Select nombre from estados where id = '" + txtId.Text + "'").ToString();
        }
    }
}
