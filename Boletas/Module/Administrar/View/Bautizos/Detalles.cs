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
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void ConsultarBautizos(string idBautizo)
        {
            txtId.Text = idBautizo;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bd.SelectString("Select nombre from bautismos where id = '" + txtId.Text + "'").ToString();
            txtAP.Text = bd.SelectString("Select apellidoPaterno from bautismos where id = '" + txtId.Text + "'").ToString();
            txtAM.Text = bd.SelectString("Select apellidoMaterno from bautismos where id = '" + txtId.Text + "'").ToString();
            dateTimeFechaBautismo.Text = bd.SelectString("Select fechaBautismo from bautismos where id = '" + txtId.Text + "'").ToString();
            dateTimeFechaNacimiento.Text = bd.SelectString("Select fechaNacimiento from bautismos where id = '" + txtId.Text + "'").ToString();
            string sexo = bd.SelectString("Select sexo from bautismos where id = '" + txtId.Text + "'").ToString();
            if (sexo == "1")
            {
                comboBoxSexo.Text = "MASCULINO";
            }
            else
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
    }
}
