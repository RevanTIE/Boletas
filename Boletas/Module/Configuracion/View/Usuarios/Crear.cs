using System;
using Boletas;
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
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void lblCrearCatequista_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void limpiar()
        {
            txtNombre.Text = "";
            txtContrasenia.Text = "";
            txtConfirmarContrasenia.Text = "";

            comboBoxEmpleado.DataSource = bd.SelectDataTable("Select empleados.id AS ID, CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) as Nombre from empleados where empleados.idEstatus = 1 and empleados.id NOT IN (SELECT usuarios.idEmpleado FROM usuarios)");
            comboBoxEmpleado.DisplayMember = "Nombre";
            comboBoxEmpleado.ValueMember = "id";
        }
        void ocultarEtiquetas()
        {
            lblObligatorio1.Visible = false;
            lblObligatorio2.Visible = false;
            lblObligatorio3.Visible = false;
        }

            private void btnGuardar_Click(object sender, EventArgs e)
        {
            ocultarEtiquetas();

            if (txtNombre.Text == "")
            {
                lblObligatorio1.Visible = true;
            }
            if (txtContrasenia.Text == "")
            {
                lblObligatorio2.Visible = true;
            }
            if (txtConfirmarContrasenia.Text == "")
            {
                lblObligatorio3.Visible = true;
            }
            if (txtNombre.Text != "" && txtContrasenia.Text != "" && txtConfirmarContrasenia.Text != "")
            {

                if (txtContrasenia.Text == txtConfirmarContrasenia.Text)
                {
                    string agregar = "insert into usuarios values ('" + txtNombre.Text + "', '" + txtContrasenia.Text + "', " + comboBoxEmpleado.SelectedValue + ")";
                    if (bd.ExecuteCommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("El empleado ya ha sido asignado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden, intente de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                
            }
        }

        private void Crear_Load(object sender, EventArgs e)
        {
            comboBoxEmpleado.DataSource = bd.SelectDataTable("Select empleados.id AS ID, CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) as Nombre from empleados where empleados.idEstatus = 1 and empleados.id NOT IN (SELECT usuarios.idEmpleado FROM usuarios)");
            comboBoxEmpleado.DisplayMember = "Nombre";
            comboBoxEmpleado.ValueMember = "ID";
        }
    }
}
