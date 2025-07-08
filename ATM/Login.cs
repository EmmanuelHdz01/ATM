using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            modelUsuario modelLogin = new modelUsuario();
            { 
                modelLogin.Usuario = String.Format(txtUsuario.Text);
                modelLogin.Contrasena = String.Format(txtContrasena.Text);
            }

            if (controlLogin.ValidarCredenciales(modelLogin))
            {
                Hide();
                mdiMenu menuUsuario = new mdiMenu();
                LimpiarCampos();
                //MessageBox.Show("Bienvenido " + modelLogin.Usuario);
                menuUsuario.ShowDialog();
                Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        public void LimpiarCampos()
        {
            txtUsuario.Text = "";
            txtContrasena.Text = "";
        }
    }
}
