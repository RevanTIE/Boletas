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
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void ConsultarComuniones(string idComunion)
        {
            txtId.Text = idComunion;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bd.SelectString("Select nombre from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            txtAP.Text = bd.SelectString("Select apellidoPaterno from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            txtAM.Text = bd.SelectString("Select apellidoMaterno from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            dateTimeFechaComunion.Text = bd.SelectString("Select fechaComunion from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            txtNombrePadrino.Text = bd.SelectString("Select nombrePadrino from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            txtNombreMadrina.Text = bd.SelectString("Select nombreMadrina from primerasComuniones where id = '" + txtId.Text + "'").ToString();
            comboBoxCatequista.Text = bd.SelectString("Select catequistas.nombre from primerasComuniones INNER JOIN catequistas ON primerasComuniones.idCatequista = catequistas.id where primerasComuniones.id = '" + txtId.Text + "'").ToString();
            comboBoxParroco.Text = bd.SelectString("Select CONCAT(parroco.nombre,' ',parroco.apellidoPaterno,' ',parroco.apellidoMaterno) from primerasComuniones INNER JOIN parroco ON primerasComuniones.idParroco = parroco.id where primerasComuniones.id = '" + txtId.Text + "'").ToString();
        }
    }
}
