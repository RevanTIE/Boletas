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

namespace Boletas.Module.Catalogo.View.Catequistas
{
    public partial class Catequistas : Form
    {
        int poc;

        public Catequistas()
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
        private void dataGridCatequistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridCatequistas.CurrentRow.Index;
            txtId.Text = dataGridCatequistas[0, poc].Value.ToString();

            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnConsultar.Enabled = true;
            btnAgregar.Enabled = true;
        }

        private void Catequistas_Load(object sender, EventArgs e)
        {
            dataGridCatequistas.DataSource = bd.SelectDataTable("Select catequistas.id as Código, CONCAT(catequistas.nombre,' ',catequistas.apellidoPaterno,' ',catequistas.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from catequistas INNER JOIN estatus ON catequistas.idEstatus = estatus.id");
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Crear ventanaCrear = new Crear();
            ventanaCrear.StartPosition = FormStartPosition.CenterScreen;
            ventanaCrear.ShowDialog();

            dataGridCatequistas.DataSource = bd.SelectDataTable("Select catequistas.id as Código, CONCAT(catequistas.nombre,' ',catequistas.apellidoPaterno,' ',catequistas.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from catequistas INNER JOIN estatus ON catequistas.idEstatus = estatus.id");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Modificar ventanaModificar = new Modificar();
                ventanaModificar.ModificarCatequistas(txtId.Text);

                ventanaModificar.StartPosition = FormStartPosition.CenterScreen;
                ventanaModificar.ShowDialog();

                dataGridCatequistas.DataSource = bd.SelectDataTable("Select catequistas.id as Código, CONCAT(catequistas.nombre,' ',catequistas.apellidoPaterno,' ',catequistas.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from catequistas INNER JOIN estatus ON catequistas.idEstatus = estatus.id");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Eliminar ventanaEliminar = new Eliminar();
                ventanaEliminar.EliminarCatequistas(txtId.Text);

                ventanaEliminar.StartPosition = FormStartPosition.CenterScreen;
                ventanaEliminar.ShowDialog();

                dataGridCatequistas.DataSource = bd.SelectDataTable("Select catequistas.id as Código, CONCAT(catequistas.nombre,' ',catequistas.apellidoPaterno,' ',catequistas.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from catequistas INNER JOIN estatus ON catequistas.idEstatus = estatus.id");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (txtBusqueda.Text == "")
            {
                dataGridCatequistas.DataSource = bd.SelectDataTable("Select catequistas.id as Código, CONCAT(catequistas.nombre,' ',catequistas.apellidoPaterno,' ',catequistas.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from catequistas INNER JOIN estatus ON catequistas.idEstatus = estatus.id");
                limpiar();
            }
            else
            {
                dataGridCatequistas.DataSource = bd.SelectDataTable("Select catequistas.id as Código, CONCAT(catequistas.nombre,' ',catequistas.apellidoPaterno,' ',catequistas.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from catequistas INNER JOIN estatus ON catequistas.idEstatus = estatus.id where CONCAT(catequistas.nombre,' ',catequistas.apellidoPaterno,' ',catequistas.apellidoMaterno) like '%" + txtBusqueda.Text + "%' OR catequistas.id like '%" + txtBusqueda.Text + "%' OR estatus.estatus = '" + txtBusqueda.Text + "'");
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Detalles ventanaConsultar = new Detalles();
                ventanaConsultar.ConsultarCatequistas(txtId.Text);

                ventanaConsultar.StartPosition = FormStartPosition.CenterScreen;
                ventanaConsultar.ShowDialog();

                dataGridCatequistas.DataSource = bd.SelectDataTable("Select catequistas.id as Código, CONCAT(catequistas.nombre,' ',catequistas.apellidoPaterno,' ',catequistas.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from catequistas INNER JOIN estatus ON catequistas.idEstatus = estatus.id");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a consultar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
