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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void ModificarUsuarios(string idUsuario)
        {
            txtId.Text = idUsuario;

        }
        private void Modificar_Load(object sender, EventArgs e)
        {
            comboBoxEmpleado.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from empleados where idEstatus = 1");
            comboBoxEmpleado.DisplayMember = "Nombre";
            comboBoxEmpleado.ValueMember = "id";

            txtNombre.Text = bd.SelectString("Select nombre from usuarios where id = '" + txtId.Text + "'").ToString();
            comboBoxEmpleado.Text = bd.SelectString("Select CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) from usuarios INNER JOIN empleados ON usuarios.idEmpleado = empleados.id where usuarios.id = '" + txtId.Text + "'").ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void ocultarEtiquetas()
        {
            lblObligatorio2.Visible = false;
            lblObligatorio3.Visible = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ocultarEtiquetas();
            
            if (txtContrasenia.Text == "")
            {
                lblObligatorio2.Visible = true;
            }
            if (txtConfirmarContrasenia.Text == "")
            {
                lblObligatorio3.Visible = true;
            }
            if (txtContrasenia.Text != "" && txtConfirmarContrasenia.Text != "")
            {

                if (txtContrasenia.Text == txtConfirmarContrasenia.Text)
                {
                    string modificar = "update usuarios set contrasenia = '" + txtContrasenia.Text + "' where id = '" + txtId.Text + "'";
                    if (bd.ExecuteCommand(modificar))
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
                    MessageBox.Show("Las contraseñas no coinciden, intente de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            }
        }
    }
}
