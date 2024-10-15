using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Data
{
    public class UsersDat
    {
        Persistence objPer = new Persistence();

        // Método para insertar un nuevo usuario
        public bool InsertUsuario(string nombre, string apellido, string correo, string contrasena, string direccion, int telefono, string registro)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procInsertUsuario"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros al procedimiento
            objCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = nombre;
            objCmd.Parameters.Add("v_apellido", MySqlDbType.VarChar).Value = apellido;
            objCmd.Parameters.Add("v_correo", MySqlDbType.VarChar).Value = correo;
            objCmd.Parameters.Add("v_contrasena", MySqlDbType.Text).Value = contrasena;
            objCmd.Parameters.Add("v_direccion", MySqlDbType.Text).Value = direccion;
            objCmd.Parameters.Add("v_telefono", MySqlDbType.Int32).Value = telefono;
            objCmd.Parameters.Add("v_registro", MySqlDbType.Text).Value = registro;

            try
            {
                row = objCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }

        // Método para actualizar un usuario existente
        public bool UpdateUsuario(int id, string nombre, string apellido, string correo, string contrasena, string direccion, int telefono)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procUpdateUsuario"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros al procedimiento
            objCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = id;
            objCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = nombre;
            objCmd.Parameters.Add("v_apellido", MySqlDbType.VarChar).Value = apellido;
            objCmd.Parameters.Add("v_correo", MySqlDbType.VarChar).Value = correo;
            objCmd.Parameters.Add("v_contrasena", MySqlDbType.Text).Value = contrasena;
            objCmd.Parameters.Add("v_direccion", MySqlDbType.Text).Value = direccion;
            objCmd.Parameters.Add("v_telefono", MySqlDbType.Int32).Value = telefono;

            try
            {
                row = objCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }

        // Método para mostrar todos los usuarios
        public DataSet ShowUsuarios()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procShowUsuarios"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objCmd;
            objAdapter.Fill(objData);

            objPer.closeConnection();
            return objData;
        }

        // Método para eliminar un usuario
        public bool DeleteUsuario(int id)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procDeleteUsuario"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetro al procedimiento
            objCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = id;

            try
            {
                row = objCmd.ExecuteNonQuery();
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            objPer.closeConnection();
            return executed;
        }

    }
}