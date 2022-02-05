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

namespace Boletas.Module.Administrar.View.Matrimonios
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
            dateTimeFechaMatrimonio.Text = "";
            txtNombreEsposo.Text = "";
            txtAPEsposo.Text = "";
            txtAMEsposo.Text = "";
            txtNombreEsposa.Text = "";
            txtAPEsposa.Text = "";
            txtAMEsposa.Text = "";
            txtParroquiaProcedencia.Text = "";
            txtPadrinoVelacion.Text = "";
            txtMadrinaVelacion.Text = "";
            txtPadrinoAnillos.Text = "";
            txtMadrinaAnillos.Text = "";
            txtPadrinoArras.Text = "";
            txtMadrinaArras.Text = "";

            comboBoxParroco.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from parroco where idEstatus = 1");
            comboBoxParroco.DisplayMember = "Nombre";
            comboBoxParroco.ValueMember = "id";

            comboBoxMinistro.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from ministros where idEstatus = 1");
            comboBoxMinistro.DisplayMember = "Nombre";
            comboBoxMinistro.ValueMember = "id";

        }
        void ocultarEtiquetas()
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

        private void Crear_Load(object sender, EventArgs e)
        {
            comboBoxParroco.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from parroco where idEstatus = 1");
            comboBoxParroco.DisplayMember = "Nombre";
            comboBoxParroco.ValueMember = "id";

            comboBoxMinistro.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from ministros where idEstatus = 1");
            comboBoxMinistro.DisplayMember = "Nombre";
            comboBoxMinistro.ValueMember = "id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ocultarEtiquetas();

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

                    string agregar = "insert into matrimonios values (" + fechaMatrimonio.ToOADate() + ",'" + txtNombreEsposo.Text + "','" + txtAPEsposo.Text + "','" + txtAMEsposo.Text + "','" +
                        txtNombreEsposa.Text + "','" + txtAPEsposa.Text + "','" + txtAMEsposa.Text + "','" + txtParroquiaProcedencia.Text + "', '" +
                                                  txtPadrinoVelacion.Text + "','" + txtMadrinaVelacion.Text + "','" + txtPadrinoAnillos.Text + "','" + txtMadrinaAnillos.Text + "','" + txtPadrinoArras.Text + "','" + txtMadrinaArras.Text + "'," +
                                                   comboBoxParroco.SelectedValue + "," + comboBoxMinistro.SelectedValue + ")";

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
    

