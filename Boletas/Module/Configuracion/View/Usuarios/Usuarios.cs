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
    public partial class Usuarios : Form
    {
        int poc;

        public Usuarios()
        {
            InitializeComponent();
            limpiar();
        }

        BaseDeDatos bd = new BaseDeDatos();

        void limpiar()
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = true;
            btnConsultar.Enabled = false;
            txtId.Text = "";
            txtBusqueda.Text = "";

        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridUsuarios.CurrentRow.Index;
            txtId.Text = dataGridUsuarios[0, poc].Value.ToString();

            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnConsultar.Enabled = true;
            btnAgregar.Enabled = true;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dataGridUsuarios.DataSource = bd.SelectDataTable("Select id as Código, nombre as Usuario " +
                "from usuarios");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                dataGridUsuarios.DataSource = bd.SelectDataTable("Select id as Código, nombre as Usuario " +
                "from usuarios");
                limpiar();
            }
            else
            {
                dataGridUsuarios.DataSource = bd.SelectDataTable("Select id as Código, nombre as Usuario " +
                "from usuarios where nombre  like '%" + txtBusqueda.Text + "%' OR id like '%" + txtBusqueda.Text + "%'");
                limpiar();
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                AcceptButton = btnBuscar;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Crear ventanaCrear = new Crear();
            ventanaCrear.StartPosition = FormStartPosition.CenterScreen;
            ventanaCrear.ShowDialog();

            dataGridUsuarios.DataSource = bd.SelectDataTable("Select id as Código, nombre as Usuario from usuarios");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {

                Detalles ventanaConsultar = new Detalles();
                ventanaConsultar.ConsultarUsuarios(txtId.Text);

                ventanaConsultar.StartPosition = FormStartPosition.CenterScreen;
                ventanaConsultar.ShowDialog();

                dataGridUsuarios.DataSource = bd.SelectDataTable("Select id as Código, nombre as Usuario from usuarios");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a consultar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Eliminar ventanaEliminar = new Eliminar();
                ventanaEliminar.EliminarUsuarios(txtId.Text);

                ventanaEliminar.StartPosition = FormStartPosition.CenterScreen;
                ventanaEliminar.ShowDialog();

                dataGridUsuarios.DataSource = bd.SelectDataTable("Select id as Código, nombre as Usuario from usuarios");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Modificar ventanaModificar = new Modificar();
                ventanaModificar.ModificarUsuarios(txtId.Text);

                ventanaModificar.StartPosition = FormStartPosition.CenterScreen;
                ventanaModificar.ShowDialog();

                dataGridUsuarios.DataSource = bd.SelectDataTable("Select id as Código, nombre as Usuario from usuarios");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
