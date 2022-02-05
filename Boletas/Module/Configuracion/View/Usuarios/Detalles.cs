using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletas.Module.Configuracion.View.Usuarios
{
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        public void ConsultarUsuarios(string idUsuario)
        {
            txtId.Text = idUsuario;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bd.SelectString("Select nombre from usuarios where id = '" + txtId.Text + "'").ToString();
            comboBoxEmpleado.Text = bd.SelectString("Select CONCAT(empleados.nombre,' ',empleados.apellidoPaterno,' ',empleados.apellidoMaterno) from usuarios INNER JOIN empleados ON usuarios.idEmpleado = empleados.id where usuarios.id = '" + txtId.Text + "'").ToString();
        }
    }
}
