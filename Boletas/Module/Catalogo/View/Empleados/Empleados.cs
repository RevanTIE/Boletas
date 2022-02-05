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

namespace Boletas.Module.Catalogo.View.Empleados
{
    public partial class Empleados : Form
    {
        int poc;

        public Empleados()
        {
            InitializeComponent();
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

        private void dataGridEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridEmpleados.CurrentRow.Index;
            txtId.Text = dataGridEmpleados[0, poc].Value.ToString();

            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnConsultar.Enabled = true;
            btnAgregar.Enabled = true;
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            dataGridEmpleados.DataSource = bd.SelectDataTable("Select empleados.id as Código, CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) as Nombre, " +
                "empleados.puesto as Puesto, estatus.estatus as Estatus from empleados INNER JOIN estatus ON empleados.idEstatus = estatus.id");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                dataGridEmpleados.DataSource = bd.SelectDataTable("Select empleados.id as Código, CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) as Nombre, " +
                "empleados.puesto as Puesto, estatus.estatus as Estatus from empleados INNER JOIN estatus ON empleados.idEstatus = estatus.id");
                limpiar();
            }
            else
            {
                dataGridEmpleados.DataSource = bd.SelectDataTable("Select empleados.id as Código, CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) as Nombre, " +
                "empleados.puesto as Puesto, estatus.estatus as Estatus from empleados INNER JOIN estatus ON empleados.idEstatus = estatus.id where CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) like '%" + txtBusqueda.Text + "%'" +
                "or empleados.puesto like '%" + txtBusqueda.Text + "%' OR empleados.id like '%" + txtBusqueda.Text + "%' OR estatus.estatus = '" + txtBusqueda.Text + "'");
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

            dataGridEmpleados.DataSource = bd.SelectDataTable("Select empleados.id as Código, CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) as Nombre, " +
                "empleados.puesto as Puesto, estatus.estatus as Estatus from empleados INNER JOIN estatus ON empleados.idEstatus = estatus.id");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Modificar ventanaModificar = new Modificar();
                ventanaModificar.ModificarEmpleados(txtId.Text);

                ventanaModificar.StartPosition = FormStartPosition.CenterScreen;
                ventanaModificar.ShowDialog();

                dataGridEmpleados.DataSource = bd.SelectDataTable("Select empleados.id as Código, CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) as Nombre, " +
                "empleados.puesto as Puesto, estatus.estatus as Estatus from empleados INNER JOIN estatus ON empleados.idEstatus = estatus.id");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Detalles ventanaConsultar = new Detalles();
                ventanaConsultar.ConsultarEmpleados(txtId.Text);

                ventanaConsultar.StartPosition = FormStartPosition.CenterScreen;
                ventanaConsultar.ShowDialog();

                dataGridEmpleados.DataSource = bd.SelectDataTable("Select empleados.id as Código, CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) as Nombre, " +
                "empleados.puesto as Puesto, estatus.estatus as Estatus from empleados INNER JOIN estatus ON empleados.idEstatus = estatus.id");
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
                ventanaEliminar.EliminarEmpleados(txtId.Text);

                ventanaEliminar.StartPosition = FormStartPosition.CenterScreen;
                ventanaEliminar.ShowDialog();

                dataGridEmpleados.DataSource = bd.SelectDataTable("Select empleados.id as Código, CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) as Nombre, " +
                "empleados.puesto as Puesto, estatus.estatus as Estatus from empleados INNER JOIN estatus ON empleados.idEstatus = estatus.id");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
