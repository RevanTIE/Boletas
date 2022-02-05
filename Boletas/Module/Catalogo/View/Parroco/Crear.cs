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
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void limpiar()
        {
            txtNombre.Text = "";
            txtAP.Text = "";
            txtAM.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            checkEstatus.Checked = false;

        }
        void ocultarEtiquetas()
        {
            lblObligatorio1.Visible = false;
            lblObligatorio2.Visible = false;
            lblObligatorio3.Visible = false;
            lblObligatorio4.Visible = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ocultarEtiquetas();
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
                string agregar = "insert into parroco values ('" + txtNombre.Text + "','" + txtAP.Text + "','" + txtAM.Text + "'," + txtTelefono.Text + ",'" + txtEmail.Text + "','" + txtDireccion.Text + "'," + estatus + ")";

                if (bd.ExecuteCommand(agregar))
                {
                    MessageBox.Show("Registro agregado correctamente", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error al agregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
