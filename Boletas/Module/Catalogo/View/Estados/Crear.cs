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

namespace Boletas.Module.Catalogo.View.Estados
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
            txtNombre.Text = "";

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                string agregar = "insert into estados values ('" + txtNombre.Text + "')";
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
            else
            {
                MessageBox.Show("Debe escribir el nombre del Estado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        
    }
}
