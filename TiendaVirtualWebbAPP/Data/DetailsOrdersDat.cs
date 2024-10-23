using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class DetailsOrdersDat
    {
        // Se crea una instancia de la clase Persistence para manejar la conexión a la base de datos.
        Persistence objPer = new Persistence();

        // Método para mostrar los detalles de pedidos desde la base de datos.
        public DataSet showDetailsOrders()
        {
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();
            DataSet objData = new DataSet();
            MySqlCommand objSelectCmd = new MySqlCommand();


            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "spSelectDetailsOrders"; //nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(objData);

            objPer.closeConnection();

            return objData;
        }

        // Método para guardar un nuevo detalle de pedido
        public bool saveDetailsOrder(int _detCantidad, double _detPrecio, int _fkPedido, int _fkProducto)
        {
            bool executed = false;
            int row;

            MySqlCommand objInsertCmd = new MySqlCommand();
            objInsertCmd.Connection = objPer.openConnection();
            objInsertCmd.CommandText = "spInsertDetailsOrder"; //nombre del procedimiento almacenado
            objInsertCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan parámetros al comando para pasar los valores del detalle de pedido.
            objInsertCmd.Parameters.Add("p_det_cantidad", MySqlDbType.Int32).Value = _detCantidad;
            objInsertCmd.Parameters.Add("p_det_precio", MySqlDbType.Double).Value = _detPrecio;
            objInsertCmd.Parameters.Add("p_fk_pedido", MySqlDbType.Int32).Value = _fkPedido;
            objInsertCmd.Parameters.Add("p_fk_producto", MySqlDbType.Int32).Value = _fkProducto;

            try
            {
                row = objInsertCmd.ExecuteNonQuery();
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

        // Método para actualizar un detalle de pedido existente
        public bool updateDetailsOrder(int _detId, int _detCantidad, double _detPrecio, int _fkPedido, int _fkProducto)
        {
            bool executed = false;
            int row;

            MySqlCommand objUpdateCmd = new MySqlCommand();
            objUpdateCmd.Connection = objPer.openConnection();
            objUpdateCmd.CommandText = "spUpdateDetailsOrder"; //nombre del procedimiento almacenado
            objUpdateCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan parámetros al comando para pasar los valores del detalle de pedido.
            objUpdateCmd.Parameters.Add("p_det_id", MySqlDbType.Int32).Value = _detId;
            objUpdateCmd.Parameters.Add("p_det_cantidad", MySqlDbType.Int32).Value = _detCantidad;
            objUpdateCmd.Parameters.Add("p_det_precio", MySqlDbType.Double).Value = _detPrecio;
            objUpdateCmd.Parameters.Add("p_fk_pedido", MySqlDbType.Int32).Value = _fkPedido;
            objUpdateCmd.Parameters.Add("p_fk_producto", MySqlDbType.Int32).Value = _fkProducto;

            try
            {
                row = objUpdateCmd.ExecuteNonQuery();
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

        //Metodo para eliminar un detalle pedido
        public bool deleteDetailsOrder(int _detId)
        {
            // Se inicializa una variable para indicar si la operación se ejecutó correctamente.
            bool executed = false;
            int row; // Variable para almacenar el número de filas afectadas por la operación.

            // Se crea un comando MySQL para eliminar un detalle de pedido utilizando un procedimiento almacenado.
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "spDeleteDetailsOrder"; // nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agrega un parámetro al comando para pasar el ID del detalle del pedido que se desea eliminar.
            objSelectCmd.Parameters.Add("p_detId", MySqlDbType.Int32).Value = _detId;

            try
            {
                // Se ejecuta el comando y se obtiene el número de filas afectadas.
                row = objSelectCmd.ExecuteNonQuery();

                // Si se elimina una fila correctamente, se establece executed a true.
                if (row == 1)
                {
                    executed = true;
                }
            }
            catch (Exception e)
            {
                // Si ocurre un error durante la ejecución del comando, se muestra en la consola.
                Console.WriteLine("Error " + e.ToString());
            }
            objPer.closeConnection();
            // Se devuelve el valor de executed para indicar si la operación se ejecutó correctamente.
            return executed;
        }


    }
}
