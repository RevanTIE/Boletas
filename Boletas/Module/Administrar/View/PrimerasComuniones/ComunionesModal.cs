using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletas.Module.Administrar.View.PrimerasComuniones
{
    public partial class ComunionesModal : Form
    {
        public ComunionesModal(string ruta)
        {
            InitializeComponent();
            Process prc = new System.Diagnostics.Process();
            axAcroPDF1.src = ruta;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
