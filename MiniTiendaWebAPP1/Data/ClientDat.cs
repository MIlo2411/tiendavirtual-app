using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Data
{
    public class ClientDat
    {
        // Se crea una instancia de la clase Persistence para manejar la conexión a la base de datos.
        Persistence objPer = new Persistence();


        // Método para mostrar los productos desde la base de datos.
        public DataSet procShowClients()
        {
            // Se crea un adaptador de datos para MySQL.
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procShowClients";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        //Metodo para guardar un nuevo Producto
        public bool SaveClients(string _nombre, string _apellido, string _correo, string _contrasena, string _direccion_envio, int _telefono)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procInsertClient";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = _nombre;
            objSelectCmd.Parameters.Add("v_apellido", MySqlDbType.VarChar).Value = _apellido;
            objSelectCmd.Parameters.Add("v_correo", MySqlDbType.String).Value = _correo;
            objSelectCmd.Parameters.Add("v_contrasena", MySqlDbType.String).Value = _contrasena;
            objSelectCmd.Parameters.Add("v_direccion", MySqlDbType.String).Value = _direccion_envio;
            objSelectCmd.Parameters.Add("v_telefono", MySqlDbType.Int32).Value = _telefono;
           

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
            finally
            {
                objPer.closeConnection();
            }
            return executed;
        }



        //Metodo para actulizar un producto
        public bool UpdateClients(int _id, string _nombre, string _apellido, string _correo, string _contrasena, string _direccion_envio, int _telefono)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procUpdateClient"; //nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan parámetros al comando para pasar los valores del producto.
            objSelectCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = _id;
            objSelectCmd.Parameters.Add("v_nombre", MySqlDbType.VarString).Value = _nombre;
            objSelectCmd.Parameters.Add("v_apellido", MySqlDbType.VarString).Value = _apellido;
            objSelectCmd.Parameters.Add("v_correo", MySqlDbType.VarChar).Value = _correo;
            objSelectCmd.Parameters.Add("v_contrasena", MySqlDbType.VarChar).Value = _contrasena;
            objSelectCmd.Parameters.Add("v_direccion", MySqlDbType.VarChar).Value = _direccion_envio;
            objSelectCmd.Parameters.Add("v_telefono", MySqlDbType.Int32).Value = _telefono;
           

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

        // Método para eliminar un cliente
        public bool DeleteClient(int id)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procDeleteClient"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros al procedimiento
            objCmd.Parameters.Add("cli_id", MySqlDbType.Int32).Value = id;

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

        public DataSet ShowClientsDDL()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procShowClientsDDL";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }
    }
}