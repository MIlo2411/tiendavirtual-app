using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class CategoryDat
    {
        Persistence objPer = new Persistence();

        // Método para insertar una nueva categoría
        public bool saveCategory(string nombre, string descripcion)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procInsertCategory"; // nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan los parámetros al comando
            objSelectCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = nombre;
            objSelectCmd.Parameters.Add("v_descripcion", MySqlDbType.VarChar).Value = descripcion;

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

        // Método para actualizar una categoría existente
        public bool updateCategory(int id, string nombre, string descripcion)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procUpdateCategory"; // nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan los parámetros al comando
            objSelectCmd.Parameters.Add("v_id", MySqlDbType.Int32).Value = id;
            objSelectCmd.Parameters.Add("v_nombre", MySqlDbType.VarChar).Value = nombre;
            objSelectCmd.Parameters.Add("v_descripcion", MySqlDbType.VarChar).Value = descripcion;

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

        // Método para mostrar todas las categorías
        public DataSet showCategories()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procShowCategories"; // nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);
            objPer.closeConnection();
            return objData;
        }

        // Método para eliminar una categoría
        public bool deleteCategory(int id)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "procDeleteCategory"; // nombre del procedimiento almacenado
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