using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletas.Module.Administrar.View.PrimerasComuniones
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void ModificarComuniones(string idComunion)
        {
            txtId.Text = idComunion;

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
        }
        private void Modificar_Load(object sender, EventArgs e)
        {
            /**
             * Se cargan los DataSource de los comboBox Catequistas y Parroco.
             * **/

            comboBoxCatequista.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from catequistas where idEstatus = 1");
            comboBoxCatequista.DisplayMember = "nombre";
            comboBoxCatequista.ValueMember = "id";

            comboBoxParroco.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from parroco where idEstatus = 1");
            comboBoxParroco.DisplayMember = "Nombre";
            comboBoxParroco.ValueMember = "id";

            /**
             * Se cargan los datos actuales de los campos a modificar
             * **/
            txtNombre.Text = bd.SelectString("Select nombre from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            txtAP.Text = bd.SelectString("Select apellidoPaterno from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            txtAM.Text = bd.SelectString("Select apellidoMaterno from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            dateTimeFechaComunion.Text = bd.SelectString("Select fechaComunion from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            txtNombrePadrino.Text = bd.SelectString("Select nombrePadrino from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            txtNombreMadrina.Text = bd.SelectString("Select nombreMadrina from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            comboBoxCatequista.Text = bd.SelectString("Select CONCAT(catequistas.nombre,' ',catequistas.apellidoPaterno,' ',catequistas.apellidoMaterno) from primerasComuniones INNER JOIN catequistas ON primerasComuniones.idCatequista = catequistas.id where primerasComuniones.id = '" + txtId.Text + "'").ToString();
            comboBoxParroco.Text = bd.SelectString("Select CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) from primerasComuniones INNER JOIN parroco ON primerasComuniones.idParroco = parroco.id where primerasComuniones.id = '" + txtId.Text + "'").ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
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
                else if (txtNombre.Text != "" && txtAP.Text != "" && txtAM.Text != "")
                {
                    DateTime fechaComunion = Convert.ToDateTime(dateTimeFechaComunion.Text);

                    string actualizar = "update primerasComuniones set nombre = '" + txtNombre.Text + "', apellidoPaterno = '" + txtAP.Text + "', apellidoMaterno = '" + txtAM.Text + "', fechaComunion = " +
                                                   fechaComunion.ToOADate() + ", nombrePadrino = '" + txtNombrePadrino.Text + "', nombreMadrina = '" + txtNombreMadrina.Text + "', idCatequista = " +
                                                   comboBoxCatequista.SelectedValue + ", idParroco = " + comboBoxParroco.SelectedValue + " where id = '" + txtId.Text + "'";

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
