using System;
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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void ModificarCatequistas(string idCatequista)
        {
            txtId.Text = idCatequista;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void limpiar()
        {
            lblObligatorio1.Visible = false;
            lblObligatorio2.Visible = false;
            lblObligatorio3.Visible = false;
            lblObligatorio4.Visible = false;
        }
        private void Modificar_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bd.SelectString("Select nombre from catequistas where id = '" + txtId.Text + "'").ToString();
            txtAP.Text = bd.SelectString("Select apellidoPaterno from catequistas where id = '" + txtId.Text + "'").ToString();
            txtAM.Text = bd.SelectString("Select apellidoMaterno from catequistas where id = '" + txtId.Text + "'").ToString();
            txtTelefono.Text = bd.SelectString("Select telefono from catequistas where id = '" + txtId.Text + "'").ToString();
            txtEmail.Text = bd.SelectString("Select correoElectronico from catequistas where id = '" + txtId.Text + "'").ToString();
            txtDireccion.Text = bd.SelectString("Select direccion from catequistas where id = '" + txtId.Text + "'").ToString();
            string estatus = bd.SelectString("Select idEstatus from catequistas where id = '" + txtId.Text + "'").ToString();

            if (estatus == "1")
            {
                checkEstatus.Checked = true;
            }
            else
            {
                checkEstatus.Checked = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            limpiar();
            int estatus;
            if (checkEstatus.Checked == true)
            {
                estatus = 1;
            }
            else
            {
                estatus = 2;
            }
            txtTelefono.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtNombre.Text == "")
            {
                lblObligatorio1.Visible = true;
            }
            if (txtAP.Text == "")
            {
                lblObligatorio2.Visible = true;
            }
            if (txtAM.Text == "")
            {
                lblObligatorio3.Visible = true;
            }
            if (txtTelefono.Text == "")
            {
                lblObligatorio4.Visible = true;
            }
            else if (txtNombre.Text != "" && txtAP.Text != "" && txtAM.Text != "" && txtTelefono.Text != "")
            {
                string actualizar = "update catequistas set nombre = '" + txtNombre.Text + "', apellidoPaterno = '" + txtAP.Text + "', apellidoMaterno = '" + txtAM.Text + "', telefono = " + txtTelefono.Text +
                ", correoElectronico = '" + txtEmail.Text + "', direccion = '" + txtDireccion.Text + "', idEstatus = " + estatus + " where id = '" + txtId.Text + "'";

                if (bd.ExecuteCommand(actualizar))
                {
                    MessageBox.Show("Registro actualizado correctamente", "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
