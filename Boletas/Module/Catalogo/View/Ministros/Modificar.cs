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
    public partial class Modificar : Form
    {
        public Modificar()
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
            lblObligatorio1.Visible = false;
            lblObligatorio2.Visible = false;
            lblObligatorio3.Visible = false;
        }
        public void ModificarMinistros(string idMinistro)
        {
            txtId.Text = idMinistro;

        }

        private void Modificar_Load(object sender, EventArgs e)
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();
                string nombreMinistro, ApPaternoMinistro, ApMaternoMinistro;
                int estatus;
                string actualizar = "";
                /**
                 El estatus es activo - 1 o inactivo - 2
                 */
                if (checkEstatus.Checked == true)
                {
                    estatus = 1;
                }
                else
                {
                    estatus = 2;
                }

                nombreMinistro = txtNombre.Text;
                ApPaternoMinistro = txtAP.Text;
                ApMaternoMinistro = txtAM.Text;

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
                else if (txtNombre.Text != "" && txtAP.Text != "" && txtAM.Text != "")
                {
                    actualizar = "update ministros set nombre = '" + nombreMinistro + "', apellidoPaterno = '" + ApPaternoMinistro + "', apellidoMaterno = '" + ApMaternoMinistro + "', idEstatus = " + estatus + " where id = '" + txtId.Text + "'";


                    if (bd.ExecuteCommand(actualizar))
                    {
                        MessageBox.Show("Registro actualizado correctamente", "Modificar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se puede actualizar el registro, es posible que esté intentando registrar un ministro que ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
