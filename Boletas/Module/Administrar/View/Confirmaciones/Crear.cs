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

namespace Boletas.Module.Administrar.View.Confirmaciones
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
            txtNombrePadre.Text = "";
            txtNombreMadre.Text = "";
            txtNombrePadrino.Text = "";
            txtNombreMadrina.Text = "";
            txtLugarBautismo.Text = "";
            dateTimeFechaBautismo.Text = "";
            txtLugarConfirmacion.Text = "";
            dateTimeFechaConfirmacion.Text = "";
            txtMunicipio.Text = "";
            txtCiudad.Text = "";

            comboBoxEstado.DataSource = bd.SelectDataTable("Select id, nombre from estados");
            comboBoxEstado.DisplayMember = "nombre";
            comboBoxEstado.ValueMember = "id";

            comboBoxMinistro.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from ministros where idEstatus = 1");
            comboBoxMinistro.DisplayMember = "Nombre";
            comboBoxMinistro.ValueMember = "id";
        }
        void limpiarEtiquetas()
        {
            lblObligatorio1.Visible = false;
            lblObligatorio2.Visible = false;
            lblObligatorio3.Visible = false;
            lblObligatorio4.Visible = false;
            lblObligatorio5.Visible = false;
            lblObligatorio6.Visible = false;
            lblObligatorio7.Visible = false;
            lblObligatorio9.Visible = false;
            lblObligatorio10.Visible = false;
        }

        private void Crear_Load(object sender, EventArgs e)
        {
            comboBoxEstado.DataSource = bd.SelectDataTable("Select id, nombre from estados");
            comboBoxEstado.DisplayMember = "nombre";
            comboBoxEstado.ValueMember = "id";

            comboBoxMinistro.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from ministros where idEstatus = 1");
            comboBoxMinistro.DisplayMember = "nombre";
            comboBoxMinistro.ValueMember = "id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaBautismo = Convert.ToDateTime(dateTimeFechaBautismo.Text);
                DateTime fechaConfirmacion = Convert.ToDateTime(dateTimeFechaConfirmacion.Text);

                limpiarEtiquetas();

                if (txtNombre.Text == "")
                {
                    lblObligatorio1.Visible = true;
                }
                if(txtAP.Text == "")
                {
                    lblObligatorio2.Visible = true;
                }
                if (txtAM.Text == "")
                {
                    lblObligatorio3.Visible = true;
                }
                if(txtNombrePadre.Text == "")
                {
                    lblObligatorio4.Visible = true;
                }
                if(txtNombreMadre.Text == "")
                {
                    lblObligatorio5.Visible = true;
                }
                if(txtLugarBautismo.Text == "")
                {
                    lblObligatorio6.Visible = true;
                }
                if(txtLugarConfirmacion.Text == "")
                {
                    lblObligatorio7.Visible = true;
                }
                if(txtMunicipio.Text == "")
                {
                    lblObligatorio9.Visible = true;
                    
                }
                if(txtCiudad.Text == "")
                {
                    lblObligatorio10.Visible = true;
                }

                if (fechaBautismo > fechaConfirmacion)
                {
                    MessageBox.Show("La fecha de bautismo no debe ser mayor a la fecha de confirmación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtNombre.Text != "" && txtAP.Text != "" && txtAM.Text != "" && txtNombrePadre.Text != "" && txtNombreMadre.Text != "" && txtLugarBautismo.Text != "" && txtLugarConfirmacion.Text != "" && txtMunicipio.Text != "" && txtCiudad.Text != "")
                {
                    string agregar = "insert into confirmaciones values ('" + txtNombre.Text + "','" + txtAP.Text + "','" + txtAM.Text + "','" +
                                                   txtNombrePadre.Text + "','" + txtNombreMadre.Text + "','" + txtNombrePadrino.Text + "','" +
                                                   txtNombreMadrina.Text + "','" + txtLugarBautismo.Text + "', " + fechaBautismo.ToOADate() + ",'" +
                                                   txtLugarConfirmacion.Text + "', " + fechaConfirmacion.ToOADate() + ",'" + txtMunicipio.Text + "','" + txtCiudad.Text + "'," +
                                                   comboBoxEstado.SelectedValue + "," + comboBoxMinistro.SelectedValue + ")";

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
