using Boletas.Module.Administrar.View;
using Boletas.Module.Catalogo.View;
using Boletas.Module.Catalogo.View.Catequistas;
using Boletas.Module.Catalogo.View.Estados;
using Boletas.Module.Catalogo.View.Empleados;
using Boletas.Module.Catalogo.View.Parroco;
using Boletas.Module.Configuracion.View;
using Boletas.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boletas.Module.Administrar.View.Bautizos;
using Boletas.Module.Administrar.View.Confirmaciones;
using Boletas.Module.Administrar.View.Matrimonios;
using Boletas.Module.Administrar.View.PrimerasComuniones;
using Boletas.Module.Configuracion.View.Usuarios;
using Boletas.Module.Catalogo.View.Ministros;

namespace Boletas
{
    public partial class Form1 : Form
    {
        public Form1(string nombre)
        {
            InitializeComponent();
            lblMensaje.Text = "Bienvenido: " + nombre;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje;
            string NL = Environment.NewLine;
            mensaje = "Aplicación Boletas San Cristóbal. Versión 1.0" + NL + NL;
            mensaje += "Es un software de control de boletas para la Parroquia de San Cristóbal, Acapulco, Gro. " + NL + NL +
                "Copyright (c) Emmanuel López Hernández, 2018" + NL +
                "Soporte Técnico: (744) 323 97 67" + NL +
                "Email: emmanuel.lopezh@gmail.com";
            MessageBox.Show(mensaje, "Acerca de San Cristóbal",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void abrirFormHija(object formHija)
        {
            if (panelPrincipal.Panel2.Controls.Count > 0)
            {
                this.panelPrincipal.Panel2.Controls.RemoveAt(0);
            }
            Form insertada = formHija as Form;
            insertada.TopLevel = false;
            insertada.Dock = DockStyle.Fill;
            this.panelPrincipal.Panel2.Controls.Add(insertada);
            this.panelPrincipal.Tag = insertada;
            insertada.Show();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Inicio());
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Inicio());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicioToolStripMenuItem_Click(null, e);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Estados());
        }

        private void bautizosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Bautizos());
        }

        private void btnBautizos_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Bautizos());
        }

        private void confirmacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Confirmaciones());
        }

        private void btnConfirmaciones_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Confirmaciones());
        }

        private void primerasComunionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new PrimerasComuniones());
        }

        private void btnComuniones_Click(object sender, EventArgs e)
        {
            abrirFormHija(new PrimerasComuniones());
        }

        private void matrimoniosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Matrimonios());
        }

        private void btnMatrimonios_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Matrimonios());
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Empleados());
        }

        private void catequistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Catequistas());
        }

        private void párrocoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Parroco());
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Usuarios());
        }

        private void parroquiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Parroquia());
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Función para realizar una copia de seguridad de la base de datos actual.
         * **/
        private void respaldarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RespaldarBD ventanaRespaldarBD = new RespaldarBD();
            ventanaRespaldarBD.StartPosition = FormStartPosition.CenterScreen;
            ventanaRespaldarBD.ShowDialog();
            abrirFormHija(new Inicio());

        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestaurarBD ventanaRestaurarBD = new RestaurarBD();
            ventanaRestaurarBD.StartPosition = FormStartPosition.CenterScreen;
            ventanaRestaurarBD.ShowDialog();
            abrirFormHija(new Inicio());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ministrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Ministros());
        }
    }
}
