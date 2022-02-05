using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletas.Module.Administrar.View.Matrimonios
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void ModificarMatrimonios(string idMatrimonio)
        {
            txtId.Text = idMatrimonio;

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
            lblObligatorio8.Visible = false;
            lblObligatorio9.Visible = false;
            lblObligatorio10.Visible = false;
            lblObligatorio11.Visible = false;
            lblObligatorio12.Visible = false;
            lblObligatorio13.Visible = false;
        }
        private void Modificar_Load(object sender, EventArgs e)
        {
            /**
             * Se carga el DataSource del comboBox Parroco.
             * **/
            comboBoxParroco.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from parroco where idEstatus = 1");
            comboBoxParroco.DisplayMember = "Nombre";
            comboBoxParroco.ValueMember = "id";

            comboBoxMinistro.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from ministros where idEstatus = 1");
            comboBoxMinistro.DisplayMember = "Nombre";
            comboBoxMinistro.ValueMember = "id";

            /**
             * Se cargan los datos actuales de los campos a modificar
             * **/

            dateTimeFechaMatrimonio.Text = bd.SelectString("Select fechaMatrimonio from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtNombreEsposo.Text = bd.SelectString("Select nombreEsposo from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtAPEsposo.Text = bd.SelectString("Select apellidoPaternoEsposo from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtAMEsposo.Text = bd.SelectString("Select apellidoMaternoEsposo from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtNombreEsposa.Text = bd.SelectString("Select nombreEsposa from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtAPEsposa.Text = bd.SelectString("Select apellidoPaternoEsposa from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtAMEsposa.Text = bd.SelectString("Select apellidoMaternoEsposa from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtParroquiaProcedencia.Text = bd.SelectString("Select parroquiaProcedencia from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtPadrinoVelacion.Text = bd.SelectString("Select padrinoVelacion from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtMadrinaVelacion.Text = bd.SelectString("Select madrinaVelacion from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtPadrinoAnillos.Text = bd.SelectString("Select padrinoAnillos from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtMadrinaAnillos.Text = bd.SelectString("Select madrinaAnillos from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtPadrinoArras.Text = bd.SelectString("Select padrinoArras from matrimonios where id = '" + txtId.Text + "'").ToString();
            txtMadrinaArras.Text = bd.SelectString("Select madrinaArras from matrimonios where id = '" + txtId.Text + "'").ToString();
            comboBoxParroco.Text = bd.SelectString("Select CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) from matrimonios INNER JOIN parroco ON matrimonios.idParroco = parroco.id where matrimonios.id = '" + txtId.Text + "'").ToString();
            comboBoxMinistro.Text = bd.SelectString("Select CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) from matrimonios INNER JOIN ministros ON matrimonios.idMinistro = ministros.id where matrimonios.id = '" + txtId.Text + "'").ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiar();

                if (txtNombreEsposo.Text == "")
                {
                    lblObligatorio1.Visible = true;
                }
                if (txtAPEsposo.Text == "")
                {
                    lblObligatorio2.Visible = true;
                }
                if (txtAMEsposo.Text == "")
                {
                    lblObligatorio3.Visible = true;
                }
                if (txtNombreEsposa.Text == "")
                {
                    lblObligatorio4.Visible = true;
                }
                if (txtAPEsposa.Text == "")
                {
                    lblObligatorio5.Visible = true;
                }
                if (txtAMEsposa.Text == "")
                {
                    lblObligatorio6.Visible = true;
                }
                if (txtParroquiaProcedencia.Text == "")
                {
                    lblObligatorio7.Visible = true;
                }
                if (txtPadrinoVelacion.Text == "")
                {
                    lblObligatorio8.Visible = true;
                }
                if (txtMadrinaVelacion.Text == "")
                {
                    lblObligatorio9.Visible = true;
                }
                if (txtPadrinoAnillos.Text == "")
                {
                    lblObligatorio10.Visible = true;
                }
                if (txtMadrinaAnillos.Text == "")
                {
                    lblObligatorio11.Visible = true;
                }
                if (txtPadrinoArras.Text == "")
                {
                    lblObligatorio12.Visible = true;
                }
                if (txtMadrinaArras.Text == "")
                {
                    lblObligatorio13.Visible = true;
                }
                else if (txtNombreEsposo.Text != "" && txtAPEsposo.Text != "" && txtAMEsposo.Text != "" && txtNombreEsposa.Text != "" && txtAPEsposa.Text != "" && txtAMEsposa.Text != "" && txtParroquiaProcedencia.Text != "" && txtPadrinoVelacion.Text != "" && txtMadrinaVelacion.Text != "" && txtPadrinoAnillos.Text != "" && txtMadrinaAnillos.Text != "" && txtPadrinoArras.Text != "" && txtMadrinaArras.Text != "")
                {
                    DateTime fechaMatrimonio = Convert.ToDateTime(dateTimeFechaMatrimonio.Text);

                    string actualizar = "update matrimonios set fechaMatrimonio = " + fechaMatrimonio.ToOADate() + ", nombreEsposo = '" + txtNombreEsposo.Text + "', apellidoPaternoEsposo = '" + txtAPEsposo.Text + "', apellidoMaternoEsposo = '" + txtAMEsposo.Text + "', nombreEsposa = '" +
                        txtNombreEsposa.Text + "', apellidoPaternoEsposa = '" + txtAPEsposa.Text + "', apellidoMaternoEsposa = '" + txtAMEsposa.Text + "', parroquiaProcedencia = '" + txtParroquiaProcedencia.Text + "', padrinoVelacion = '" +
                                                  txtPadrinoVelacion.Text + "', madrinaVelacion = '" + txtMadrinaVelacion.Text + "', padrinoAnillos = '" + txtPadrinoAnillos.Text + "', madrinaAnillos = '" + txtMadrinaAnillos.Text + "', padrinoArras = '" + txtPadrinoArras.Text + "', madrinaArras = '" + txtMadrinaArras.Text + "', idParroco = " + comboBoxParroco.SelectedValue + ", idMinistro = " + comboBoxMinistro.SelectedValue + " where id = '" + txtId.Text + "'";
                   

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
