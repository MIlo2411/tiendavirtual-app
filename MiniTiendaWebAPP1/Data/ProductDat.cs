using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;

namespace Data
{
    public class ProductDat
    {
        Persistence objPer = new Persistence();

        // Método para insertar un nuevo producto
        public bool InsertProduct(string _nombre, string _descripcion, double _precio, int _stock, string _imagen, int _proveedor_Id, int _categoria_Id)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procInsertProduct"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros al procedimiento
            objCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = _nombre;
            objCmd.Parameters.Add("v_descripcion", MySqlDbType.VarChar).Value = _descripcion;
            objCmd.Parameters.Add("v_precio", MySqlDbType.Double).Value = _precio;
            objCmd.Parameters.Add("v_stock", MySqlDbType.Int32).Value = _stock;
            objCmd.Parameters.Add("v_imagen", MySqlDbType.Text).Value = _imagen;
            objCmd.Parameters.Add("v_proveedor_id", MySqlDbType.Int32).Value = _proveedor_Id;
            objCmd.Parameters.Add("v_categoria_id", MySqlDbType.Int32).Value = _categoria_Id;

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

        // Método para actualizar un producto existente
        public bool UpdateProduct(int _id, string _nombre, string _descripcion, double _precio, int _stock, string _imagen)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procUpdateProduct"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros al procedimiento
            objCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = _id;
            objCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = _nombre;
            objCmd.Parameters.Add("v_descripcion", MySqlDbType.VarChar).Value = _descripcion;
            objCmd.Parameters.Add("v_precio", MySqlDbType.Double).Value = _precio;
            objCmd.Parameters.Add("v_stock", MySqlDbType.Int32).Value = _stock;
            objCmd.Parameters.Add("v_imagen", MySqlDbType.Text).Value = _imagen;

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

        // Método para mostrar todos los productos
        public DataSet ShowProducts()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procShowProducts"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objCmd;
            objAdapter.Fill(objData);

            objPer.closeConnection();
            return objData;
        }

        // Método para eliminar un producto
        public bool DeleteProduct(int _id)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procDeleteProduct"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros al procedimiento
            objCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = _id;

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

        public DataSet ShowProductsDDL()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procShowProductsDDL";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }
    }
}