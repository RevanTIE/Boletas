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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void EliminarMatrimonios(string idMatrimonio)
        {
            txtId.Text = idMatrimonio;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "delete from matrimonios where id = '" + txtId.Text + "'";
            if (bd.ExecuteCommand(eliminar))
            {
                MessageBox.Show("Registro eliminado correctamente", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
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
    }
}
