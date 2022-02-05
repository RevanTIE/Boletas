using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Boletas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=boletas;Integrated Security=True");

        public void loguear(string usuario, string contrasenia)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT idEmpleado FROM usuarios WHERE nombre = @usuario AND contrasenia = @password",con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("password", contrasenia);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    new Form1(usuario.ToString()).Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            loguear(this.txtUsuario.Text, this.txtPassword.Text);
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
