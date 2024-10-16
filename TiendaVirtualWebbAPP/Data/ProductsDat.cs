using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class ProductsDat
    {

        Persistence objPer = new Persistence();

        // Método para insertar un nuevo producto
        public bool InsertProduct(string nombre, string descripcion, double precio, int stock, string imagen, int proveedorId, int categoriaId)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procInsertProduct"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros al procedimiento
            objCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = nombre;
            objCmd.Parameters.Add("v_descripcion", MySqlDbType.VarChar).Value = descripcion;
            objCmd.Parameters.Add("v_precio", MySqlDbType.Double).Value = precio;
            objCmd.Parameters.Add("v_stock", MySqlDbType.Int32).Value = stock;
            objCmd.Parameters.Add("v_imagen", MySqlDbType.Text).Value = imagen;
            objCmd.Parameters.Add("v_proveedor_id", MySqlDbType.Int32).Value = proveedorId;
            objCmd.Parameters.Add("v_categoria_id", MySqlDbType.Int32).Value = categoriaId;

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
        public bool UpdateProduct(int id, string nombre, string descripcion, double precio, int stock, string imagen)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procUpdateProduct"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros al procedimiento
            objCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = id;
            objCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = nombre;
            objCmd.Parameters.Add("v_descripcion", MySqlDbType.VarChar).Value = descripcion;
            objCmd.Parameters.Add("v_precio", MySqlDbType.Double).Value = precio;
            objCmd.Parameters.Add("v_stock", MySqlDbType.Int32).Value = stock;
            objCmd.Parameters.Add("v_imagen", MySqlDbType.Text).Value = imagen;

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
        public bool DeleteProduct(int id)
        {
            bool executed = false;
            int row;

            MySqlCommand objCmd = new MySqlCommand();
            objCmd.Connection = objPer.openConnection();
            objCmd.CommandText = "procDeleteProduct"; // Nombre del procedimiento almacenado
            objCmd.CommandType = CommandType.StoredProcedure;

            // Añadir parámetros al procedimiento
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