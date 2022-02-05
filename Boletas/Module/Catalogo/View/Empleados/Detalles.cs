using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletas.Module.Catalogo.View.Empleados
{
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void ConsultarEmpleados(string idEmpleado)
        {
            txtId.Text = idEmpleado;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bd.SelectString("Select nombre from empleados where id = '" + txtId.Text + "'").ToString();
            txtAP.Text = bd.SelectString("Select apellidoPaterno from empleados where id = '" + txtId.Text + "'").ToString();
            txtAM.Text = bd.SelectString("Select apellidoMaterno from empleados where id = '" + txtId.Text + "'").ToString();
            txtPuesto.Text = bd.SelectString("Select puesto from empleados where id = '" + txtId.Text + "'").ToString();
            txtTelefono.Text = bd.SelectString("Select telefono from empleados where id = '" + txtId.Text + "'").ToString();
            txtEmail.Text = bd.SelectString("Select correoElectronico from empleados where id = '" + txtId.Text + "'").ToString();
            txtDireccion.Text = bd.SelectString("Select direccion from empleados where id = '" + txtId.Text + "'").ToString();
            string estatus = bd.SelectString("Select idEstatus from empleados where id = '" + txtId.Text + "'").ToString();

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
