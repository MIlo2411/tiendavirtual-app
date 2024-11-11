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
        public bool SaveUsuario(string _nombre, string _apellido, string _correo, string _contrasena, string _direccion, string _telefono, string _registro)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procInsertUsuario"; // nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan los parámetros al comando
            objSelectCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = _nombre;
            objSelectCmd.Parameters.Add("v_apellido", MySqlDbType.VarChar).Value = _apellido;
            objSelectCmd.Parameters.Add("v_correo", MySqlDbType.VarChar).Value = _correo;
            objSelectCmd.Parameters.Add("v_contrasena", MySqlDbType.Text).Value = _contrasena;
            objSelectCmd.Parameters.Add("v_direccion", MySqlDbType.Text).Value = _direccion;
            objSelectCmd.Parameters.Add("v_telefono", MySqlDbType.String).Value = _telefono;
            objSelectCmd.Parameters.Add("v_registro", MySqlDbType.Text).Value = _registro;

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
        public bool UpdateUsuario(int _id, string _nombre, string _apellido, string _correo, string _contrasena, string _direccion, string _telefono)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procUpdateUsuario"; // nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan los parámetros al comando
            objSelectCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = _id;
            objSelectCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = _nombre;
            objSelectCmd.Parameters.Add("v_apellido", MySqlDbType.VarChar).Value = _apellido;
            objSelectCmd.Parameters.Add("v_correo", MySqlDbType.VarChar).Value = _correo;
            objSelectCmd.Parameters.Add("v_contrasena", MySqlDbType.Text).Value = _contrasena;
            objSelectCmd.Parameters.Add("v_direccion", MySqlDbType.Text).Value = _direccion;
            objSelectCmd.Parameters.Add("v_telefono", MySqlDbType.String).Value = _telefono;

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
        public DataSet ShowUsuarios()
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
        public bool DeleteUsuario(int _id)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procDeleteUsuario"; // nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agrega el parámetro al comando
            objSelectCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = _id;

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