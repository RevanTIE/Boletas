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
            checkEstatus.Checked = false;

            checkParroco.Checked = false;
            lblParroco.Visible = false;
            comboBoxParroco.Visible = false;

        }
        void ocultarEtiquetas()
        {
            lblObligatorio1.Visible = false;
            lblObligatorio2.Visible = false;
            lblObligatorio3.Visible = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ocultarEtiquetas();
                string nombreMinistro, ApPaternoMinistro, ApMaternoMinistro;
                int estatus;
                string agregar = "";
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


                /**
                 * Si los campos nombre, apellido paterno y apellido materno del ministro están habilitados, toma en cuenta el contenido para mandarlo
                 * a guardar en la base de datos.
                 **/

                if (txtNombre.Enabled == true && txtAP.Enabled == true && txtAM.Enabled == true)
                {
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

                }
                /**
                 * Si no, toma el valor a partir del párroco.
                 * **/
                else
                {
                    nombreMinistro = bd.SelectString("Select nombre from parroco where id = '" + comboBoxParroco.SelectedValue + "'").ToString();
                    ApPaternoMinistro = bd.SelectString("Select apellidoPaterno from parroco where id = '" + comboBoxParroco.SelectedValue + "'").ToString();
                    ApMaternoMinistro = bd.SelectString("Select apellidoMaterno from parroco where id = '" + comboBoxParroco.SelectedValue + "'").ToString();
                }

                if (checkParroco.Checked == false)
                {
                    if (txtNombre.Text != "" && txtAP.Text != "" && txtAM.Text != "")
                    {
                        agregar = "insert into ministros values ('" + nombreMinistro + "','" + ApPaternoMinistro + "','" + ApMaternoMinistro + "'," + estatus + ")";
                        if (bd.ExecuteCommand(agregar))
                        {
                            MessageBox.Show("Registro agregado correctamente", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            limpiar();
                        }
                        else
                        {
                            MessageBox.Show("No se puede agregar el registro, es posible que esté intentando registrar un ministro que ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    agregar = "insert into ministros values ('" + nombreMinistro + "','" + ApPaternoMinistro + "','" + ApMaternoMinistro + "'," + estatus + ")";
                    if (bd.ExecuteCommand(agregar))
                    {
                        MessageBox.Show("Registro agregado correctamente", "Agregar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se puede agregar el registro, es posible que esté intentando registrar un ministro que ya existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkParroco_CheckedChanged(object sender, EventArgs e)
        {
            if (checkParroco.Checked == true)
            {
                comboBoxParroco.Visible = true;

                comboBoxParroco.DataSource = bd.SelectDataTable("Select parroco.id AS ID, CONCAT (parroco.nombre, ' ', parroco.apellidoPaterno, ' ', parroco.apellidoMaterno) AS Nombre from parroco WHERE parroco.idEstatus = 1 and CONCAT (parroco.nombre, ' ', parroco.apellidoPaterno, ' ', parroco.apellidoMaterno) NOT IN (SELECT CONCAT (ministros.nombre, ' ',ministros.apellidoPaterno, ' ',ministros.apellidoMaterno) FROM ministros)");
                comboBoxParroco.DisplayMember = "Nombre";
                comboBoxParroco.ValueMember = "ID";
            }
            else if (checkParroco.Checked == false)
            {
                comboBoxParroco.Visible = false;

                txtNombre.Enabled = true;
                txtAP.Enabled = true;
                txtAM.Enabled = true;
            }
            
        }

        private void comboBoxParroco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxParroco.Text != "")
            {
                txtNombre.Enabled = false;
                txtAP.Enabled = false;
                txtAM.Enabled = false;

            }

        }
    }
}
