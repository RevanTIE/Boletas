using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletas.Module.Catalogo.View.Catequistas
{
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void ConsultarCatequistas(string idCatequista)
        {
            txtId.Text = idCatequista;
            
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bd.SelectString("Select nombre from catequistas where id = '" + txtId.Text + "'").ToString();
            txtAP.Text = bd.SelectString("Select apellidoPaterno from catequistas where id = '" + txtId.Text + "'").ToString();
            txtAM.Text = bd.SelectString("Select apellidoMaterno from catequistas where id = '" + txtId.Text + "'").ToString();
            txtTelefono.Text = bd.SelectString("Select telefono from catequistas where id = '" + txtId.Text + "'").ToString();
            txtEmail.Text = bd.SelectString("Select correoElectronico from catequistas where id = '" + txtId.Text + "'").ToString();
            txtDireccion.Text = bd.SelectString("Select direccion from catequistas where id = '" + txtId.Text + "'").ToString();
            string estatus = bd.SelectString("Select idEstatus from catequistas where id = '" + txtId.Text + "'").ToString();
            
            if (estatus == "1")
            {
                checkEstatus.Checked = true;
            }
            else
            {
                checkEstatus.Checked = false;
            }
        }
        
    }
}
