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
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void ConsultarConfirmaciones(string idConfirmacion)
        {
            txtId.Text = idConfirmacion;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
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
    }
}
