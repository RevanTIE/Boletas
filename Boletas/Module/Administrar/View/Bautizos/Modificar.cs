using Boletas.Module.Administrar.Controller.Bautizos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletas.Module.Administrar.View.Bautizos
{
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        BaseDeDatos bd = new BaseDeDatos();

        public void ModificarBautizos(string idBautizo)
        {
            txtId.Text = idBautizo;

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
        }
        
        private void Modificar_Load(object sender, EventArgs e)
        {
            /**
             * Se cargan los DataSource de los comboBox Estado y Parroco.
             * **/
            comboBoxEstado.DataSource = bd.SelectDataTable("Select id, nombre from estados");
            comboBoxEstado.DisplayMember = "nombre";
            comboBoxEstado.ValueMember = "id";

            comboBoxMinistro.DataSource = bd.SelectDataTable("Select id, CONCAT(nombre,' ',apellidoPaterno,' ',apellidoMaterno) as Nombre from ministros where idEstatus = 1");
            comboBoxMinistro.DisplayMember = "Nombre";
            comboBoxMinistro.ValueMember = "id";

            List<GeneroBautizado> lista = new List<GeneroBautizado>();
            lista.Add(new GeneroBautizado("MASCULINO", 1));
            lista.Add(new GeneroBautizado("FEMENINO", 2));

            comboBoxSexo.DataSource = lista;
            comboBoxSexo.DisplayMember = "name";
            comboBoxSexo.ValueMember = "value";

            /**
             * Se cargan los datos actuales de los campos a modificar
             * **/
            txtNombre.Text = bd.SelectString("Select nombre from bautismos where id = '" + txtId.Text + "'").ToString();
            txtAP.Text = bd.SelectString("Select apellidoPaterno from bautismos where id = '" + txtId.Text + "'").ToString();
            txtAM.Text = bd.SelectString("Select apellidoMaterno from bautismos where id = '" + txtId.Text + "'").ToString();
            dateTimeFechaBautismo.Text = bd.SelectString("Select fechaBautismo from bautismos where id = '" + txtId.Text + "'").ToString();
            dateTimeFechaNacimiento.Text = bd.SelectString("Select fechaNacimiento from bautismos where id = '" + txtId.Text + "'").ToString();
            string sexo = bd.SelectString("Select sexo from bautismos where id = '" + txtId.Text + "'").ToString();
            if (sexo == "1")
            {
                comboBoxSexo.Text = "MASCULINO";
            }else
            {
                comboBoxSexo.Text = "FEMENINO";
            }
            txtNombrePadre.Text = bd.SelectString("Select nombrePadre from bautismos where id = '" + txtId.Text + "'").ToString();
            txtNombreMadre.Text = bd.SelectString("Select nombreMadre from bautismos where id = '" + txtId.Text + "'").ToString();
            txtNombrePadrino.Text = bd.SelectString("Select nombrePadrino from bautismos where id = '" + txtId.Text + "'").ToString();
            txtNombreMadrina.Text = bd.SelectString("Select nombreMadrina from bautismos where id = '" + txtId.Text + "'").ToString();
            txtParroquia.Text = bd.SelectString("Select parroquia from bautismos where id = '" + txtId.Text + "'").ToString();
            txtMunicipio.Text = bd.SelectString("Select municipio from bautismos where id = '" + txtId.Text + "'").ToString();
            txtCiudad.Text = bd.SelectString("Select ciudad from bautismos where id = '" + txtId.Text + "'").ToString();
            comboBoxEstado.Text = bd.SelectString("Select estados.nombre from bautismos INNER JOIN estados ON bautismos.idEstado = estados.id where bautismos.id = '" + txtId.Text + "'").ToString();
            comboBoxMinistro.Text = bd.SelectString("Select CONCAT(ministros.nombre,' ',ministros.apellidoPaterno,' ',ministros.apellidoMaterno) from bautismos INNER JOIN ministros ON bautismos.idMinistro = ministros.id where bautismos.id = '" + txtId.Text + "'").ToString();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaBautismo = Convert.ToDateTime(dateTimeFechaBautismo.Text);
                DateTime fechaNacimiento = Convert.ToDateTime(dateTimeFechaNacimiento.Text);

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
                if (txtParroquia.Text == "")
                {
                    lblObligatorio6.Visible = true;
                }
                if (txtMunicipio.Text == "")
                {
                    lblObligatorio7.Visible = true;
                }
                if (txtCiudad.Text == "")
                {
                    lblObligatorio8.Visible = true;
                }
                if (fechaNacimiento > fechaBautismo)
                {
                    MessageBox.Show("La fecha de nacimiento no debe ser mayor a la fecha de bautismo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtNombre.Text != "" && txtAP.Text != "" && txtAM.Text != "" && txtNombrePadre.Text != "" && txtNombreMadre.Text != "" && txtParroquia.Text != "" && txtMunicipio.Text != "" && txtCiudad.Text != "")
                {
                    string actualizar = "update bautismos set fechaBautismo = " + fechaBautismo.ToOADate() + ", nombre = '" + txtNombre.Text + "', apellidoPaterno = '" + txtAP.Text + "', apellidoMaterno = '" + txtAM.Text + "', fechaNacimiento = " +
                                                   fechaNacimiento.ToOADate() + ", nombrePadre ='" + txtNombrePadre.Text + "', nombreMadre ='" + txtNombreMadre.Text + "', nombrePadrino ='" + txtNombrePadrino.Text + "', nombreMadrina ='" +
                                                   txtNombreMadrina.Text + "', parroquia = '" + txtParroquia.Text + "', municipio = '" + txtMunicipio.Text + "', ciudad = '" + txtCiudad.Text + "', idEstado = " +
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
