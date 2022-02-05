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

namespace Boletas
{
    public partial class RestaurarBD : Form
    {
        public RestaurarBD()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Restauración de base de datos";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDireccion.Text = dlg.FileName;
                btnRestaurar.Enabled = true;
            }
            if (txtDireccion.Text == "")
            {
                btnRestaurar.Enabled = false;
            }
        }

        private void RestaurarBD_Load(object sender, EventArgs e)
        {
            if (txtDireccion.Text == "")
            {
                btnRestaurar.Enabled = false;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStat1 = string.Format("ALTER DATABASE [boletas] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                bd.ExecuteCommand(sqlStat1);

                string sqlStat2 = "USE MASTER RESTORE DATABASE [boletas] FROM DISK = '" + txtDireccion.Text +"'WITH REPLACE;";
                bd.ExecuteCommand(sqlStat2);

                string sqlStat3 = string.Format("ALTER DATABASE [boletas] SET MULTI_USER");
                bd.ExecuteCommand(sqlStat3);

                MessageBox.Show("La copia se ha restaurado satisfactoriamente en: " + txtDireccion.Text, "Resultado de la restauración", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnRestaurar.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("El siguiente error ha ocurrido: " + ex.ToString(), "Resultado de la restauración", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
