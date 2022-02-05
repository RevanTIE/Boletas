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

namespace Boletas.Module.Administrar.View.PrimerasComuniones
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
            dateTimeFechaComunion.Text = "";

            txtNombre.Text = "";
            txtAP.Text = "";
            txtAM.Text = "";
            txtNombrePadrino.Text = "";
            txtNombreMadrina.Text = "";;

            comboBoxCatequista.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from catequistas where idEstatus = 1");
            comboBoxCatequista.DisplayMember = "nombre";
            comboBoxCatequista.ValueMember = "id";

            comboBoxParroco.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from parroco where idEstatus = 1");
            comboBoxParroco.DisplayMember = "Nombre";
            comboBoxParroco.ValueMember = "id";
        }

        void ocultarEtiquetas()
        {
            lblObligatorio1.Visible = false;
            lblObligatorio2.Visible = false;
            lblObligatorio3.Visible = false;
        }

        private void Crear_Load(object sender, EventArgs e)
        {
            comboBoxCatequista.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from catequistas where idEstatus = 1");
            comboBoxCatequista.DisplayMember = "nombre";
            comboBoxCatequista.ValueMember = "id";

            comboBoxParroco.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from parroco where idEstatus = 1");
            comboBoxParroco.DisplayMember = "Nombre";
            comboBoxParroco.ValueMember = "id";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                ocultarEtiquetas();

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

                    string agregar = "insert into primerasComuniones values ('" + txtNombre.Text + "','" + txtAP.Text + "','" + txtAM.Text + "'," +
                                                   fechaComunion.ToOADate() + ",'" + txtNombrePadrino.Text + "','" + txtNombreMadrina.Text + "'," + 
                                                   comboBoxCatequista.SelectedValue + "," + comboBoxParroco.SelectedValue + ")";

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
