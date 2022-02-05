using System;
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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        BaseDeDatos bd = new BaseDeDatos();

        public void ModificarConfirmaciones(string idConfirmacion)
        {
            txtId.Text = idConfirmacion;

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
            lblObligatorio5.Visible = false;
            lblObligatorio6.Visible = false;
            lblObligatorio7.Visible = false;
            lblObligatorio9.Visible = false;
            lblObligatorio10.Visible = false;

        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            /**
             * Se carga el DataSource del comboBox Estado.
             * **/

            comboBoxEstado.DataSource = bd.SelectDataTable("Select id, nombre from estados");
            comboBoxEstado.DisplayMember = "nombre";
            comboBoxEstado.ValueMember = "id";

            comboBoxMinistro.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from ministros where idEstatus = 1");
            comboBoxMinistro.DisplayMember = "Nombre";
            comboBoxMinistro.ValueMember = "id";

            /**
             * Se cargan los datos actuales de los campos a modificar
             * **/
            txtNombre.Text = bd.SelectString("Select nombre from confirmaciones where id = '" + txtId.Text + "'").ToString();
            txtAP.Text = bd.SelectString("Select apellidoPaterno from confirmaciones where id = '" + txtId.Text + "'").ToString();
            txtAM.Text = bd.SelectString("Select apellidoMaterno from confirmaciones where id = '" + txtId.Text + "'").ToString();
            txtNombrePadre.Text = bd.SelectString("Select nombrePadre from confirmaciones where id = '" + txtId.Text + "'").ToString();
            txtNombreMadre.Text = bd.SelectString("Select nombreMadre from confirmaciones where id = '" + txtId.Text + "'").ToString();
            txtNombrePadrino.Text = bd.SelectString("Select nombrePadrino from confirmaciones where id = '" + txtId.Text + "'").ToString();
            txtNombreMadrina.Text = bd.SelectString("Select nombreMadrina from confirmaciones where id = '" + txtId.Text + "'").ToString();
            txtLugarBautismo.Text = bd.SelectString("Select lugarBautismo from confirmaciones where id = '" + txtId.Text + "'").ToString();
            dateTimeFechaBautismo.Text = bd.SelectString("Select fechaBautismo from confirmaciones where id = '" + txtId.Text + "'").ToString();
            txtLugarConfirmacion.Text = bd.SelectString("Select lugarConfirmacion from confirmaciones where id = '" + txtId.Text + "'").ToString();
            dateTimeFechaConfirmacion.Text = bd.SelectString("Select fechaConfirmacion from confirmaciones where id = '" + txtId.Text + "'").ToString();
            txtMunicipio.Text = bd.SelectString("Select municipio from confirmaciones where id = '" + txtId.Text + "'").ToString();
            txtCiudad.Text = bd.SelectString("Select ciudad from confirmaciones where id = '" + txtId.Text + "'").ToString();
            comboBoxEstado.Text = bd.SelectString("Select estados.nombre from confirmaciones INNER JOIN estados ON confirmaciones.idEstado = estados.id where confirmaciones.id = '" + txtId.Text + "'").ToString();
            comboBoxMinistro.Text = bd.SelectString("Select CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) from confirmaciones INNER JOIN ministros ON confirmaciones.idMinistro = ministros.id where confirmaciones.id = '" + txtId.Text + "'").ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaBautismo = Convert.ToDateTime(dateTimeFechaBautismo.Text);
                DateTime fechaConfirmacion = Convert.ToDateTime(dateTimeFechaConfirmacion.Text);

                limpiar();

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
                if (txtNombrePadre.Text == "")
                {
                    lblObligatorio4.Visible = true;
                }
                if (txtNombreMadre.Text == "")
                {
                    lblObligatorio5.Visible = true;
                }
                if (txtLugarBautismo.Text == "")
                {
                    lblObligatorio6.Visible = true;
                }
                if (txtLugarConfirmacion.Text == "")
                {
                    lblObligatorio7.Visible = true;
                }
                if (txtMunicipio.Text == "")
                {
                    lblObligatorio9.Visible = true;

                }
                if (txtCiudad.Text == "")
                {
                    lblObligatorio10.Visible = true;
                }
                if (fechaBautismo > fechaConfirmacion)
                {
                    MessageBox.Show("La fecha de bautismo no debe ser mayor a la fecha de confirmación", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtNombre.Text != "" && txtAP.Text != "" && txtAM.Text != "" && txtNombrePadre.Text != "" && txtNombreMadre.Text != "" && txtLugarBautismo.Text != "" && txtLugarConfirmacion.Text != "" && txtMunicipio.Text != "" && txtCiudad.Text != "")
                {

                    string actualizar = "update confirmaciones set nombre = '" + txtNombre.Text + "', apellidoPaterno = '" + txtAP.Text + "', apellidoMaterno = '" + txtAM.Text +
                        "', nombrePadre ='" + txtNombrePadre.Text + "', nombreMadre ='" + txtNombreMadre.Text + "', nombrePadrino ='" + txtNombrePadrino.Text + "', nombreMadrina ='" + txtNombreMadrina.Text +
                        "', lugarBautismo = '" + txtLugarBautismo.Text + "',  fechaBautismo = " + fechaBautismo.ToOADate() +
                        ", lugarConfirmacion = '" + txtLugarConfirmacion.Text + "', fechaConfirmacion = " + fechaConfirmacion.ToOADate() +
                        ", municipio = '" + txtMunicipio.Text + "', ciudad = '" + txtCiudad.Text + "', idEstado = " +
                                                   comboBoxEstado.SelectedValue + ", idMinistro = " + comboBoxMinistro.SelectedValue + " where id = '" + txtId.Text + "'";

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
