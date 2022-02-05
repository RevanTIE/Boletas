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

namespace Boletas.Module.Catalogo.View.Ministros
{
    public partial class Ministros : Form
    {
        int poc;

        public Ministros()
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

        private void dataGridMinistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridMinistros.CurrentRow.Index;
            txtId.Text = dataGridMinistros[0, poc].Value.ToString();

            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnConsultar.Enabled = true;
            btnAgregar.Enabled = true;
        }

        private void Ministros_Load(object sender, EventArgs e)
        {
            dataGridMinistros.DataSource = bd.SelectDataTable("Select ministros.id as Código, CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from ministros INNER JOIN estatus ON ministros.idEstatus = estatus.id");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Crear ventanaCrear = new Crear();
            ventanaCrear.StartPosition = FormStartPosition.CenterScreen;
            ventanaCrear.ShowDialog();

            dataGridMinistros.DataSource = bd.SelectDataTable("Select ministros.id as Código, CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from ministros INNER JOIN estatus ON ministros.idEstatus = estatus.id");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Detalles ventanaConsultar = new Detalles();
                ventanaConsultar.ConsultarMinistros(txtId.Text);

                ventanaConsultar.StartPosition = FormStartPosition.CenterScreen;
                ventanaConsultar.ShowDialog();

                dataGridMinistros.DataSource = bd.SelectDataTable("Select ministros.id as Código, CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) as Nombre, " +
                 "estatus.estatus as Estatus from ministros INNER JOIN estatus ON ministros.idEstatus = estatus.id");
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
                ventanaEliminar.EliminarMinistros(txtId.Text);

                ventanaEliminar.StartPosition = FormStartPosition.CenterScreen;
                ventanaEliminar.ShowDialog();

                dataGridMinistros.DataSource = bd.SelectDataTable("Select ministros.id as Código, CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) as Nombre, " +
                 "estatus.estatus as Estatus from ministros INNER JOIN estatus ON ministros.idEstatus = estatus.id");
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
                ventanaModificar.ModificarMinistros(txtId.Text);

                ventanaModificar.StartPosition = FormStartPosition.CenterScreen;
                ventanaModificar.ShowDialog();

                dataGridMinistros.DataSource = bd.SelectDataTable("Select ministros.id as Código, CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from ministros INNER JOIN estatus ON ministros.idEstatus = estatus.id");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                dataGridMinistros.DataSource = bd.SelectDataTable("Select ministros.id as Código, CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from ministros INNER JOIN estatus ON ministros.idEstatus = estatus.id");
                limpiar();
            }
            else
            {
                dataGridMinistros.DataSource = bd.SelectDataTable("Select ministros.id as Código, CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from ministros INNER JOIN estatus ON ministros.idEstatus = estatus.id where CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) like '%" + txtBusqueda.Text + "%' OR ministros.id like '%" + txtBusqueda.Text + "%' OR estatus.estatus = '" + txtBusqueda.Text + "'");
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
    }
}
