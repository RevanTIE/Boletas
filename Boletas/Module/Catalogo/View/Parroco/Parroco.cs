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

namespace Boletas.Module.Catalogo.View.Parroco

{
    public partial class Parroco : Form
    {
        int poc;
        public Parroco()
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

        private void dataGridParroco_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridParroco.CurrentRow.Index;
            txtId.Text = dataGridParroco[0, poc].Value.ToString();

            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnConsultar.Enabled = true;
            btnAgregar.Enabled = true;
        }

        private void Parroco_Load(object sender, EventArgs e)
        {
            dataGridParroco.DataSource = bd.SelectDataTable("Select parroco.id as Código, CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from parroco INNER JOIN estatus ON parroco.idEstatus = estatus.id");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Crear ventanaCrear = new Crear();
            ventanaCrear.StartPosition = FormStartPosition.CenterScreen;
            ventanaCrear.ShowDialog();

            dataGridParroco.DataSource = bd.SelectDataTable("Select parroco.id as Código, CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from parroco INNER JOIN estatus ON parroco.idEstatus = estatus.id");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Modificar ventanaModificar = new Modificar();
                ventanaModificar.ModificarParroco(txtId.Text);

                ventanaModificar.StartPosition = FormStartPosition.CenterScreen;
                ventanaModificar.ShowDialog();

                dataGridParroco.DataSource = bd.SelectDataTable("Select parroco.id as Código, CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from parroco INNER JOIN estatus ON parroco.idEstatus = estatus.id");
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
                ventanaEliminar.EliminarParroco(txtId.Text);

                ventanaEliminar.StartPosition = FormStartPosition.CenterScreen;
                ventanaEliminar.ShowDialog();

                dataGridParroco.DataSource = bd.SelectDataTable("Select parroco.id as Código, CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from parroco INNER JOIN estatus ON parroco.idEstatus = estatus.id");
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
                dataGridParroco.DataSource = bd.SelectDataTable("Select parroco.id as Código, CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from parroco INNER JOIN estatus ON parroco.idEstatus = estatus.id");
                limpiar();
            }
            else
            {
                dataGridParroco.DataSource = bd.SelectDataTable("Select parroco.id as Código, CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from parroco INNER JOIN estatus ON parroco.idEstatus = estatus.id where CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) like '%" + txtBusqueda.Text + "%' OR parroco.id like '%" + txtBusqueda.Text + "%' OR estatus.estatus = '" + txtBusqueda.Text + "'");
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
                ventanaConsultar.ConsultarParroco(txtId.Text);

                ventanaConsultar.StartPosition = FormStartPosition.CenterScreen;
                ventanaConsultar.ShowDialog();

                dataGridParroco.DataSource = bd.SelectDataTable("Select parroco.id as Código, CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) as Nombre, " +
                "estatus.estatus as Estatus from parroco INNER JOIN estatus ON parroco.idEstatus = estatus.id");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a consultar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
