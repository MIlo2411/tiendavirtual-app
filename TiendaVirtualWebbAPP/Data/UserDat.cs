using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class UserDat
    {
        using MySql.Data.MySqlClient;
using System;
using System.Data;

public class Persistence
    {
        private MySqlConnection connection;

        // Método para abrir la conexión a la base de datos
        public MySqlConnection openConnection()
        {
            if (connection == null)
            {
                // Cambia los valores por tu configuración de base de datos
                string connectionString = "server=localhost;database=TiendaVirtual;uid=root;pwd=yourpassword;";
                connection = new MySqlConnection(connectionString);
            }

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            return connection;
        }

        // Método para cerrar la conexión a la base de datos
        public void closeConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }

    public class UsuarioManager
    {
        Persistence objPer = new Persistence();

        // Método para insertar un nuevo usuario
        public bool saveUsuario(string nombre, string apellido, string correo, string contrasena, string direccion, int telefono, string registro)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procInsertUsuario"; // nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan los parámetros al comando
            objSelectCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = nombre;
            objSelectCmd.Parameters.Add("v_apellido", MySqlDbType.VarChar).Value = apellido;
            objSelectCmd.Parameters.Add("v_correo", MySqlDbType.VarChar).Value = correo;
            objSelectCmd.Parameters.Add("v_contrasena", MySqlDbType.Text).Value = contrasena;
            objSelectCmd.Parameters.Add("v_direccion", MySqlDbType.Text).Value = direccion;
            objSelectCmd.Parameters.Add("v_telefono", MySqlDbType.Int32).Value = telefono;
            objSelectCmd.Parameters.Add("v_registro", MySqlDbType.Text).Value = registro;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }

        // Método para actualizar un usuario existente
        public bool updateUsuario(int id, string nombre, string apellido, string correo, string contrasena, string direccion, int telefono)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procUpdateUsuario"; // nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan los parámetros al comando
            objSelectCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = id;
            objSelectCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = nombre;
            objSelectCmd.Parameters.Add("v_apellido", MySqlDbType.VarChar).Value = apellido;
            objSelectCmd.Parameters.Add("v_correo", MySqlDbType.VarChar).Value = correo;
            objSelectCmd.Parameters.Add("v_contrasena", MySqlDbType.Text).Value = contrasena;
            objSelectCmd.Parameters.Add("v_direccion", MySqlDbType.Text).Value = direccion;
            objSelectCmd.Parameters.Add("v_telefono", MySqlDbType.Int32).Value = telefono;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }

        // Método para mostrar todos los usuarios
        public DataSet showUsuarios()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procShowUsuarios"; // nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        // Método para eliminar un usuario
        public bool deleteUsuario(int id)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procDeleteUsuario"; // nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agrega el parámetro al comando
            objSelectCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = id;

            try
            {
                row = objSelectCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }
    }
}
}