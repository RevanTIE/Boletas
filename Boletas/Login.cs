using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Boletas.Model;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace Boletas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        Entities context = new Entities();
        //SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=boletas;Integrated Security=True");


        public void loguear(string usuario, string contrasenia)
        {
            try
            {
                var User = EncontrarUsuario(usuario);

                if (User == null)
                {
                    MessageBox.Show("EL USUARIO NO EXISTE", "ERROR AL INICIAR SESIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    if (User.contrasenia.Equals(contrasenia))
                    {
                        this.Hide();
                        new Form1(usuario.ToString()).Show();
                    }
                    else {
                        MessageBox.Show("USUARIO Y/O CONTRASEÑA INCORRECTOS", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Legacy: El siguiente código representa la cadena de conexión anterior. Ahora se hace con la instancia del Modelo.
                //con.Open();
                //SqlCommand cmd = new SqlCommand("SELECT idEmpleado FROM usuarios WHERE nombre = @usuario AND contrasenia = @password",con);
                //cmd.Parameters.AddWithValue("usuario", usuario);
                //cmd.Parameters.AddWithValue("password", contrasenia);
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //DataTable dt = new DataTable();
                //sda.Fill(dt);

                //if (dt.Rows.Count == 1)
                //{
                //    this.Hide();
                //    new Form1(usuario.ToString()).Show();
                //}
                //else
                //{
                //    MessageBox.Show("Usuario y/o Contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private usuario EncontrarUsuario(string username)
        {
            try
            {
                var user = context.usuarios
                    .FirstOrDefault(x =>x.nombre == username);

                return user;

            }
            catch (Exception e)
            {
                MessageBox.Show("HA OCURRIDO EL SIGUIENTE ERROR: \n" + e.Message, "ERROR AL CONSULTAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
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
