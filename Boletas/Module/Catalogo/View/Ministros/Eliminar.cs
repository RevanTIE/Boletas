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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void EliminarMinistros(string idMinistro)
        {
            txtId.Text = idMinistro;

        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bd.SelectString("Select nombre from ministros where id = '" + txtId.Text + "'").ToString();
            txtAP.Text = bd.SelectString("Select apellidoPaterno from ministros where id = '" + txtId.Text + "'").ToString();
            txtAM.Text = bd.SelectString("Select apellidoMaterno from ministros where id = '" + txtId.Text + "'").ToString();
            string estatus = bd.SelectString("Select idEstatus from ministros where id = '" + txtId.Text + "'").ToString();

            if (estatus == "1")
            {
                checkEstatus.Checked = true;
            }
            else
            {
                checkEstatus.Checked = false;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "delete from ministros where id = '" + txtId.Text + "'";
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
