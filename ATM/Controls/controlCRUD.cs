using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    internal class controlCRUD
    {
        public static bool RegistrarUsuario(modelUsuario registrar)
        {
            try
            {
                using (SqlConnection connection = conexion())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO tblUsuario (Usuario, Contrasena, Dinero) VALUES (@Usuario, @Contrasena, @Dinero)", connection);
                    command.Parameters.AddWithValue("@Usuario", registrar.Usuario);
                    command.Parameters.AddWithValue("@Contrasena", registrar.Contrasena);
                    command.Parameters.AddWithValue("@Dinero", registrar.Dinero); // Asignar un valor inicial de 0 a Dinero

                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar el usuario: " + ex.Message);
                return false;
            }
            return true;
        }


        public static List<modelUsuario> MostrarUsuarios()
        {
            try
            {
                using (SqlConnection connection = conexion())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM tblUsuario", connection);

                    List<modelUsuario> usuarios = new List<modelUsuario>();


                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        modelUsuario vistaDatos = new modelUsuario();
                        vistaDatos.idUsuario = (int)reader["idUsuario"];
                        vistaDatos.Usuario = reader["Usuario"].ToString(); // Asignar el valor del campo Usuario
                        vistaDatos.Contrasena = reader["Contrasena"].ToString();
                        vistaDatos.Dinero = (int)reader["Dinero"];

                        usuarios.Add(vistaDatos);
                    }
                    return usuarios;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al mostrar los usuarios: " + ex.Message);
                return null;
            }
        }

        public static bool ActualizarUsuario(modelUsuario modelo)
        {
            try
            {
                using (SqlConnection connection = conexion())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("UPDATE tblUsuario SET Usuario = @Usuario, Contrasena = @Contrasena, Dinero = @Dinero WHERE idUsuario = @idUsuario", connection);
                    command.Parameters.AddWithValue("@idUsuario", modelo.idUsuario);
                    command.Parameters.AddWithValue("@Usuario", modelo.Usuario);
                    command.Parameters.AddWithValue("@Contrasena", modelo.Contrasena);
                    command.Parameters.AddWithValue("@Dinero", modelo.Dinero);

                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al actualizar el usuario: " + e.Message);
                return false;
            }
        }

        public static bool EliminarUsuario(int idUsuario)
        {
            try
            {
                using (SqlConnection connection = conexion())
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM tblUsuario WHERE idUsuario = @idUsuario", connection);
                    command.Parameters.AddWithValue("@idUsuario", idUsuario);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al eliminar el usuario: " + e.Message);    
                return false;
            }
        }
        public static SqlConnection conexion()
        {
            SqlConnection connection = new SqlConnection("SERVER=WORK-TEAM\\SQLEXPRESS; DATABASE=ATM; Integrated Security=true");
            return connection;
        }
    }



}