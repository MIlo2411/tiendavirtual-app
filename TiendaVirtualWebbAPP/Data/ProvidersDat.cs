using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Data
{
    public class ProvidersDat
    {

        Persistence objPer = new Persistence();

        // Método para insertar un nuevo proveedor
        public bool InsertSupplier(string nombre, string contacto, int telefono, string direccion)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procInsertSupplier"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros al procedimiento
            objCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = nombre;
            objCmd.Parameters.Add("v_contacto", MySqlDbType.VarChar).Value = contacto;
            objCmd.Parameters.Add("v_telefono", MySqlDbType.Int32).Value = telefono;
            objCmd.Parameters.Add("v_direccion", MySqlDbType.Text).Value = direccion;

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

        // Método para actualizar un proveedor existente
        public bool UpdateSupplier(int id, string nombre, string contacto, int telefono, string direccion)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procUpdateSupplier"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros al procedimiento
            objCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = id;
            objCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = nombre;
            objCmd.Parameters.Add("v_contacto", MySqlDbType.VarChar).Value = contacto;
            objCmd.Parameters.Add("v_telefono", MySqlDbType.Int32).Value = telefono;
            objCmd.Parameters.Add("v_direccion", MySqlDbType.Text).Value = direccion;

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

        // Método para mostrar todos los proveedores
        public DataSet ShowSuppliers()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procShowSuppliers"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objCmd;
            objAdapter.Fill(objData);

            objPer.closeConnection();
            return objData;
        }

        // Método para eliminar un proveedor
        public bool DeleteSupplier(int id)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procDeleteSupplier"; // Nombre del procedimiento almacenado
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