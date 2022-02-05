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

namespace Boletas.Module.Catalogo.View.Ministros
{
    public partial class Detalles : Form
    {
        public Detalles()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ConsultarMinistros(string idMinistro)
        {
            txtId.Text = idMinistro;

        }

        private void Detalles_Load(object sender, EventArgs e)
        {
            txtNombre.Text = bd.SelectString("Select nombre from ministros where id = '" + txtId.Text + "'").ToString();
            txtAP.Text = bd.SelectString("Select apellidoPaterno from ministros where id = '" + txtId.Text + "'").ToString();
            txtAM.Text = bd.SelectString("Select apellidoMaterno from ministros where id = '" + txtId.Text + "'").ToString();
            string estatus = bd.SelectString("Select idEstatus from ministros where id = '" + txtId.Text + "'").ToString();

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
