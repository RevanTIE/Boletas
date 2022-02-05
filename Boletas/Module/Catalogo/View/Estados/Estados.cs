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

namespace Boletas.Module.Catalogo.View.Estados
{
    public partial class Estados : Form
    {
        int poc;

        public Estados()
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

        private void Estados_Load(object sender, EventArgs e)
        {
            dataGridEstados.DataSource = bd.SelectDataTable("Select id as Código, nombre as Estado from estados");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBusqueda.Text == "")
            {
                dataGridEstados.DataSource = bd.SelectDataTable("Select id as Código, nombre as Estado from estados");
                limpiar();
            }
            else
            {
                dataGridEstados.DataSource = bd.SelectDataTable("Select id as Código, nombre as Estado from estados where nombre like '%" + txtBusqueda.Text + "%' OR id like '%" + txtBusqueda.Text + "%'");
                limpiar();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Crear ventanaCrear = new Crear();
            ventanaCrear.StartPosition = FormStartPosition.CenterScreen;
            ventanaCrear.ShowDialog();

            dataGridEstados.DataSource = bd.SelectDataTable("Select id as Código, nombre as Estado from estados");
        }


        private void dataGridEstados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridEstados.CurrentRow.Index;
            txtId.Text = dataGridEstados[0, poc].Value.ToString();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnConsultar.Enabled = true;
            btnAgregar.Enabled = true;

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
                ventanaConsultar.ConsultarEstados(txtId.Text);

                ventanaConsultar.StartPosition = FormStartPosition.CenterScreen;
                ventanaConsultar.ShowDialog();

                dataGridEstados.DataSource = bd.SelectDataTable("Select id as Código, nombre as Estado from estados");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a consultar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Modificar ventanaModificar = new Modificar();
                ventanaModificar.ModificarEstados(txtId.Text);

                ventanaModificar.StartPosition = FormStartPosition.CenterScreen;
                ventanaModificar.ShowDialog();

                dataGridEstados.DataSource = bd.SelectDataTable("Select id as Código, nombre as Estado from estados");
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
                ventanaEliminar.EliminarEstados(txtId.Text);

                ventanaEliminar.StartPosition = FormStartPosition.CenterScreen;
                ventanaEliminar.ShowDialog();

                dataGridEstados.DataSource = bd.SelectDataTable("Select id as Código, nombre as Estado from estados");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
    }
}
