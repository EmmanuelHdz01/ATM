using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class vistaUsuarios : Form
    {
        public vistaUsuarios()
        {
            InitializeComponent();
            mostrarUsuario();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
                modelUsuario registrar = new modelUsuario()
                {
                    Usuario = txtUsuarioRegistro.Text,
                    Contrasena = txtContrasenaRegistro.Text,
                    Dinero = int.Parse(txtDinero.Text)
                };

                if (controlCRUD.RegistrarUsuario(registrar))
                {
                    mostrarUsuario();
                    MessageBox.Show("¡Registro exitoso! Ahora puedes iniciar sesión.");
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario. Inténtalo de nuevo." + e);
                }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            modelUsuario actualizar = new modelUsuario()
            {
                idUsuario = int.Parse(txtidUsuario.Text),
                Usuario = txtUsuarioRegistro.Text,
                Contrasena = txtContrasenaRegistro.Text,
                Dinero = int.Parse(txtDinero.Text)
            };
            if (controlCRUD.ActualizarUsuario(actualizar))
            {
                mostrarUsuario();
                MessageBox.Show("¡Actualización exitosa!");
            }
            else
            {
                MessageBox.Show("Error al actualizar el usuario. Inténtalo de nuevo.");
            }
        }

        private void mostrarUsuario()
        {
            dtgvUsuarios.AutoGenerateColumns = false;
            controlCRUD.MostrarUsuarios();
            List<modelUsuario> vista = controlCRUD.MostrarUsuarios();
            dtgvUsuarios.DataSource = vista;
        }

        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            modelUsuario modelUsuario = dtgvUsuarios.CurrentRow.DataBoundItem as modelUsuario;
            txtidUsuario.Text = modelUsuario.idUsuario.ToString();
            txtUsuarioRegistro.Text = modelUsuario.Usuario;
            txtContrasenaRegistro.Text = modelUsuario.Contrasena;
            txtDinero.Text = modelUsuario.Dinero.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            modelUsuario modelUsuario = dtgvUsuarios.CurrentRow.DataBoundItem as modelUsuario;
            if (controlCRUD.EliminarUsuario(modelUsuario.idUsuario))
            {
                mostrarUsuario();
                MessageBox.Show("¡Eliminación exitosa!");
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario. Inténtalo de nuevo.");
            }
        }
    }
}
