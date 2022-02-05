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
using System.IO;
using Boletas.Module.Administrar.Model.Comuniones;

namespace Boletas.Module.Administrar.View.PrimerasComuniones
{
    public partial class PrimerasComuniones : Form
    {
        int poc;
        private string _fecha1;

        public string fecha1
        {
            get => _fecha1;
            set
            {
                _fecha1 = value;
            }
        }

        private string _fecha2;

        public string fecha2
        {
            get => _fecha2;
            set
            {
                _fecha2 = value;
            }
        }

        public PrimerasComuniones()
        {
            InitializeComponent();
            limpiar();
        }
        BaseDeDatos bd = new BaseDeDatos();

        void limpiar()
        {
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = true;
            btnConsultar.Enabled = false;
            txtId.Text = "";
            txtBusqueda.Text = "";
            btnBoletaPdf.Enabled = false;
        }

        private void dataGridComuniones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            poc = dataGridComuniones.CurrentRow.Index;
            txtId.Text = dataGridComuniones[0, poc].Value.ToString();

            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            btnConsultar.Enabled = true;
            btnAgregar.Enabled = true;
            btnBoletaPdf.Enabled = true;
        }
        private void RecargarFechas()
        {
            fecha1 = new DateTime(dateTimeMonth.Value.Year, dateTimeMonth.Value.Month, 1).ToString("yyyy/MM/dd") + " 00:00:00";
            fecha2 = new DateTime(dateTimeMonth.Value.Year, dateTimeMonth.Value.Month + 1, 1).AddDays(-1).ToString("yyyy/MM/dd") + " 23:59:59";
        }

        private void PrimerasComuniones_Load(object sender, EventArgs e)
        {
            RecargarFechas();

            dataGridComuniones.DataSource = bd.SelectDataTable("Select primerasComuniones.id as Código, CONCAT(primerasComuniones.nombre,' ',primerasComuniones.apellidoPaterno,' ',primerasComuniones.apellidoMaterno) as Nombre, " +
                "primerasComuniones.fechaComunion as [Fecha de Primera Comunión], CONCAT(catequistas.nombre, ' ',catequistas.apellidoPaterno, ' ',catequistas.apellidoMaterno) as Catequista from primerasComuniones INNER JOIN catequistas ON primerasComuniones.idCatequista = catequistas.id where primerasComuniones.fechaComunion between '" + fecha1 + "' AND '" + fecha2 + "'");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Crear ventanaCrear = new Crear();
            ventanaCrear.StartPosition = FormStartPosition.CenterScreen;
            ventanaCrear.ShowDialog();

            RecargarFechas();

            dataGridComuniones.DataSource = bd.SelectDataTable("Select primerasComuniones.id as Código, CONCAT(primerasComuniones.nombre,' ',primerasComuniones.apellidoPaterno,' ',primerasComuniones.apellidoMaterno) as Nombre, " +
                "primerasComuniones.fechaComunion as [Fecha de Primera Comunión], CONCAT(catequistas.nombre, ' ',catequistas.apellidoPaterno, ' ',catequistas.apellidoMaterno) as Catequista from primerasComuniones INNER JOIN catequistas ON primerasComuniones.idCatequista = catequistas.id where primerasComuniones.fechaComunion between '" + fecha1 + "' AND '" + fecha2 + "'");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Detalles ventanaConsultar = new Detalles();
                ventanaConsultar.ConsultarComuniones(txtId.Text);

                ventanaConsultar.StartPosition = FormStartPosition.CenterScreen;
                ventanaConsultar.ShowDialog();

                RecargarFechas();

                dataGridComuniones.DataSource = bd.SelectDataTable("Select primerasComuniones.id as Código, CONCAT(primerasComuniones.nombre,' ',primerasComuniones.apellidoPaterno,' ',primerasComuniones.apellidoMaterno) as Nombre, " +
                    "primerasComuniones.fechaComunion as [Fecha de Primera Comunión], CONCAT(catequistas.nombre, ' ',catequistas.apellidoPaterno, ' ',catequistas.apellidoMaterno) as Catequista from primerasComuniones INNER JOIN catequistas ON primerasComuniones.idCatequista = catequistas.id where primerasComuniones.fechaComunion between '" + fecha1 + "' AND '" + fecha2 + "'");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a consultar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Eliminar ventanaEliminar = new Eliminar();
                ventanaEliminar.EliminarComuniones(txtId.Text);

                ventanaEliminar.StartPosition = FormStartPosition.CenterScreen;
                ventanaEliminar.ShowDialog();

                RecargarFechas();

                dataGridComuniones.DataSource = bd.SelectDataTable("Select primerasComuniones.id as Código, CONCAT(primerasComuniones.nombre,' ',primerasComuniones.apellidoPaterno,' ',primerasComuniones.apellidoMaterno) as Nombre, " +
                    "primerasComuniones.fechaComunion as [Fecha de Primera Comunión], CONCAT(catequistas.nombre, ' ',catequistas.apellidoPaterno, ' ',catequistas.apellidoMaterno) as Catequista from primerasComuniones INNER JOIN catequistas ON primerasComuniones.idCatequista = catequistas.id where primerasComuniones.fechaComunion between '" + fecha1 + "' AND '" + fecha2 + "'");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                Modificar ventanaModificar = new Modificar();
                ventanaModificar.ModificarComuniones(txtId.Text);

                ventanaModificar.StartPosition = FormStartPosition.CenterScreen;
                ventanaModificar.ShowDialog();

                RecargarFechas();

                dataGridComuniones.DataSource = bd.SelectDataTable("Select primerasComuniones.id as Código, CONCAT(primerasComuniones.nombre,' ',primerasComuniones.apellidoPaterno,' ',primerasComuniones.apellidoMaterno) as Nombre, " +
                    "primerasComuniones.fechaComunion as [Fecha de Primera Comunión], CONCAT(catequistas.nombre, ' ',catequistas.apellidoPaterno, ' ',catequistas.apellidoMaterno) as Catequista from primerasComuniones INNER JOIN catequistas ON primerasComuniones.idCatequista = catequistas.id where primerasComuniones.fechaComunion between '" + fecha1 + "' AND '" + fecha2 + "'");
                limpiar();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el registro a modificar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RecargarFechas();

            if (txtBusqueda.Text == "")
            {
                dataGridComuniones.DataSource = bd.SelectDataTable("Select primerasComuniones.id as Código, CONCAT(primerasComuniones.nombre,' ',primerasComuniones.apellidoPaterno,' ',primerasComuniones.apellidoMaterno) as Nombre, " +
                    "primerasComuniones.fechaComunion as [Fecha de Primera Comunión], CONCAT(catequistas.nombre, ' ',catequistas.apellidoPaterno, ' ',catequistas.apellidoMaterno) as Catequista from primerasComuniones INNER JOIN catequistas ON primerasComuniones.idCatequista = catequistas.id where primerasComuniones.fechaComunion between '" + fecha1 + "' AND '" + fecha2 + "'");
                limpiar();
            }
            else
            {

                dataGridComuniones.DataSource = bd.SelectDataTable("Select primerasComuniones.id as Código, CONCAT(primerasComuniones.nombre,' ',primerasComuniones.apellidoPaterno,' ',primerasComuniones.apellidoMaterno) as Nombre, " +
                 "primerasComuniones.fechaComunion as [Fecha de Primera Comunión], CONCAT(catequistas.nombre, ' ',catequistas.apellidoPaterno, ' ',catequistas.apellidoMaterno) as Catequista from primerasComuniones INNER JOIN catequistas ON primerasComuniones.idCatequista = catequistas.id  where (primerasComuniones.fechaComunion between '" + fecha1 + "' AND '" + fecha2 + "') AND ((CONCAT(primerasComuniones.nombre,' ',primerasComuniones.apellidoPaterno,' ',primerasComuniones.apellidoMaterno) like '%" + txtBusqueda.Text + "%') OR primerasComuniones.id like '%" + txtBusqueda.Text + "%' )");
                limpiar();
                
            }
        }

        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                AcceptButton = btnBuscar;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                RecargarFechas();

                dataGridComuniones.DataSource = bd.SelectDataTable("Select primerasComuniones.id as Código, CONCAT(primerasComuniones.nombre,' ',primerasComuniones.apellidoPaterno,' ',primerasComuniones.apellidoMaterno) as Nombre, " +
                    "primerasComuniones.fechaComunion as [Fecha de Primera Comunión], CONCAT(catequistas.nombre, ' ',catequistas.apellidoPaterno, ' ',catequistas.apellidoMaterno) as Catequista from primerasComuniones INNER JOIN catequistas ON primerasComuniones.idCatequista = catequistas.id where primerasComuniones.fechaComunion between '" + fecha1 + "' AND '" + fecha2 + "'");
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dateTimeMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                AcceptButton = btnFiltrar;
            }
        }

        private void btnBoletaPdf_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Primero debe seleccionar un registro", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BoletaComuniones bolComuniones = new BoletaComuniones();
                string route = bolComuniones.generarBoletaComunion(txtId.Text);
                /**
             Se eliminar el archivo una vez generada la ventana modal.
             */
                System.IO.File.Delete(route);
            }
        }
    }
}
