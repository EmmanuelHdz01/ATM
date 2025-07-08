using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATM
{
    internal class controlLogin
    {

        public static bool ValidarCredenciales(modelUsuario login)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("SERVER=WORK-TEAM\\SQLEXPRESS; DATABASE=ATM; Integrated Security=true"))
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM tblUsuario WHERE Usuario = @usuario AND Contrasena = @contrasena", connection); // Consulta para verificar las credenciales
                    command.Parameters.AddWithValue("@usuario", login.Usuario); // Parámetro para el nombre de usuario
                    command.Parameters.AddWithValue("@contrasena", login.Contrasena); // Parámetro para la contraseña
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Retorna true si las credenciales son válidas
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                return false;
            }
        }

    }
}