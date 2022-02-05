using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletas.Module.Configuracion.View.Usuarios
{
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void EliminarUsuarios(string idUsuario)
        {
            txtId.Text = idUsuario;

        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bd.SelectString("Select nombre from usuarios where id = '" + txtId.Text + "'").ToString();
            comboBoxEmpleado.Text = bd.SelectString("Select CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) from usuarios INNER JOIN empleados ON usuarios.idEmpleado = empleados.id where usuarios.id = '" + txtId.Text + "'").ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "delete from usuarios where id = '" + txtId.Text + "' and id != 1";

            if (txtId.Text == "1")
            {
                MessageBox.Show("No puede eliminar al superadmin", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (bd.ExecuteCommand(eliminar))
                {
                    MessageBox.Show("Registro eliminado correctamente", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

           
        }
    }
}
