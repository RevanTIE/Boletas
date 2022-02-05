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
    public partial class RespaldarBD : Form
    {
        public RespaldarBD()
        {
            InitializeComponent();
        }
        BaseDeDatos bd = new BaseDeDatos();

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDireccion.Text == string.Empty)
                {
                    MessageBox.Show("Debe seleccionarse la ruta donde se realizará el respaldo", "Resultado de la copia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string nombreCopia = (System.DateTime.Today.Day.ToString() + "-" + System.DateTime.Today.Month.ToString() + "-" + System.DateTime.Today.Year.ToString() + "_" + System.DateTime.Now.Hour.ToString() + "-" + System.DateTime.Now.Minute.ToString() + "-" + System.DateTime.Now.Second.ToString() + "_SanCristobal");
                    string comandoConsulta = "BACKUP DATABASE [boletas] TO  DISK = N'"+ txtDireccion.Text + "\\" + nombreCopia + ".bak' WITH NOFORMAT, NOINIT,  NAME = N'boletas-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

                    if (bd.ExecuteCommand(comandoConsulta)){
                        MessageBox.Show("La copia se ha creado satisfactoriamente en: " + txtDireccion.Text, "Resultado de la copia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnRespaldar.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al respaldar", "Resultado de la copia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El siguiente error ha ocurrido: " + ex.ToString(), "Resultado de la copia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtDireccion.Text = dlg.SelectedPath;
                btnRespaldar.Enabled = true;
            }
            if(txtDireccion.Text == "")
            {
                btnRespaldar.Enabled = false;
            }
        }

        private void RespaldarBD_Load(object sender, EventArgs e)
        {
            string path = @"C:\Boletas_San_Cristobal\respaldos";
            
            if (Directory.Exists(path))
            {
                txtDireccion.Text = path.ToString();
            }
            //else
            //{
               // DirectoryInfo di = Directory.CreateDirectory(path);
               // txtDireccion.Text = path.ToString();
            //}

            if (txtDireccion.Text == "")
            {
                btnRespaldar.Enabled = false;
            }
        }
    }
}
