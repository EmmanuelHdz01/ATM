using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    internal class modelConexion
    {
        //SqlConnection connection = new SqlConnection("SERVER:WORK-TEAM\\SQLEXPRESS; DATABASE:ATM; SECURITY");

        public static SqlConnection connection(string usuario, string contrasena)
        {
            SqlConnection connection = new SqlConnection("SERVER=WORK-TEAM\\SQLEXPRESS; DATABASE=ATM; Integrated Security=true");
            SqlCommand validacion = new SqlCommand("SELECT Usuario, Contrasena FROM tblUsuario WHERE Usuario = @usuario AND Contrasena = @contrasena", connection);

            validacion.Parameters.AddWithValue("@usuario", usuario);
            validacion.Parameters.AddWithValue("@contrasena", contrasena);

            validacion.ExecuteReader();
            try
            {
                if (usuario == "@usuario" && contrasena == "@contrasena")
                {
                    connection.Open();
                    MessageBox.Show("Conexión exitosa a la base de datos.");
                    return connection;
                }
                else 
                {
                    connection.Close();
                    return null; // Si las credenciales no son correctas, retorna null
                }
                    
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                return null;
            }
        }
    }
}
