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
using Boletas.Module.Administrar.Controller.Bautizos;

namespace Boletas.Module.Administrar.View.Bautizos
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
            dateTimeFechaBautismo.Text = "";
            dateTimeFechaNacimiento.Text = "";

            txtNombre.Text = "";
            txtAP.Text = "";
            txtAM.Text = "";
            txtNombrePadre.Text = "";
            txtNombreMadre.Text = "";
            txtNombrePadrino.Text = "";
            txtNombreMadrina.Text = "";
            txtParroquia.Text = "";
            txtMunicipio.Text = "";
            txtCiudad.Text = "";

            comboBoxEstado.DataSource = bd.SelectDataTable("Select id, nombre from estados");
            comboBoxEstado.DisplayMember = "nombre";
            comboBoxEstado.ValueMember = "id";

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
        }

        private void Crear_Load(object sender, EventArgs e)
        {
            comboBoxEstado.DataSource = bd.SelectDataTable("Select id, nombre from estados");
            comboBoxEstado.DisplayMember = "nombre";
            comboBoxEstado.ValueMember = "id";

            comboBoxMinistro.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from ministros where idEstatus = 1");
            comboBoxMinistro.DisplayMember = "nombre";
            comboBoxMinistro.ValueMember = "id";
            
            
           List <GeneroBautizado> lista = new List<GeneroBautizado>();
            lista.Add(new GeneroBautizado("MASCULINO", 1));
            lista.Add(new GeneroBautizado("FEMENINO", 2));

            comboBoxSexo.DataSource = lista;
            comboBoxSexo.DisplayMember = "name";
            comboBoxSexo.ValueMember = "value";
             

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaBautismo = Convert.ToDateTime(dateTimeFechaBautismo.Text);
                DateTime fechaNacimiento = Convert.ToDateTime(dateTimeFechaNacimiento.Text);

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
                if (txtNombrePadre.Text == "")
                {
                    lblObligatorio4.Visible = true;
                }
                if(txtNombreMadre.Text == "")
                {
                    lblObligatorio5.Visible = true;
                }
                if(txtParroquia.Text == "")
                {
                    lblObligatorio6.Visible = true;
                }
                if(txtMunicipio.Text == "")
                {
                    lblObligatorio7.Visible = true;
                }
                if(txtCiudad.Text == "")
                {
                    lblObligatorio8.Visible = true;
                }
                if (fechaNacimiento > fechaBautismo)
                {
                    MessageBox.Show("La fecha de nacimiento no debe ser mayor a la fecha de bautismo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtNombre.Text != "" && txtAP.Text != "" && txtAM.Text != "" && txtNombrePadre.Text != "" && txtNombreMadre.Text != "" && txtParroquia.Text != "" && txtMunicipio.Text != "" && txtCiudad.Text != "")
                {
                    string agregar = "insert into bautismos values (" + fechaBautismo.ToOADate() + ",'" + txtNombre.Text + "','" + txtAP.Text + "','" + txtAM.Text + "'," +
                                                                       fechaNacimiento.ToOADate() + "," + comboBoxSexo.SelectedValue + ",'" + txtNombrePadre.Text + "','" + txtNombreMadre.Text + "','" + txtNombrePadrino.Text + "','" +
                                                                       txtNombreMadrina.Text + "','" + txtParroquia.Text + "','" + txtMunicipio.Text + "','" + txtCiudad.Text + "'," +
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
