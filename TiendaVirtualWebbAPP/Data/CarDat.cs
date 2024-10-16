﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data
{
    public class CarDat
    {
        // Se crea una instancia de la clase Persistence para manejar la conexión a la base de datos.
        Persistence objPer = new Persistence();

        // Método para mostrar los carritos desde la base de datos.
        public DataSet showCars()
        {
            // Se crea un adaptador de datos para MySQL.
            MySqlDataAdapter objAdapter = new MySqlDataAdapter();

            // Se crea un DataSet para almacenar los resultados de la consulta.
            DataSet objData = new DataSet();

            // Se crea un comando MySQL para seleccionar los carritos utilizando un procedimiento almacenado.
            MySqlCommand objSelectCmd = new MySqlCommand();

            // Se establece la conexión del comando utilizando el método openConnection() de Persistence.
            objSelectCmd.Connection = objPer.openConnection();

            // Se especifica el nombre del procedimiento almacenado a ejecutar.
            objSelectCmd.CommandText = "spSelectCars";

            // Se indica que se trata de un procedimiento almacenado.
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se establece el comando de selección del adaptador de datos.
            objAdapter.SelectCommand = objSelectCmd;

            // Se llena el DataSet con los resultados de la consulta.
            objAdapter.Fill(objData);

            // Se cierra la conexión después de obtener los datos.
            objPer.closeConnection();

            // Se devuelve el DataSet que contiene los carritos.
            return objData;
        }

        // Método para guardar un nuevo carrito
        public bool saveCars(int _cantidad, int _fkProduct, int _fkClient)
        {
            // Se inicializa una variable para indicar si la operación se ejecutó correctamente.
            bool executed = false;
            int row;// Variable para almacenar el número de filas afectadas por la operación.

            // Se crea un comando MySQL para insertar un nuevo carrito utilizando un procedimiento almacenado.
            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "spInsertCars"; //nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan parámetros al comando para pasar los valores del carrito.
            objSelectCmd.Parameters.Add("p_cantidad", MySqlDbType.Int32).Value = _cantidad;
            objSelectCmd.Parameters.Add("p_fkProduct", MySqlDbType.Int32).Value = _fkProduct;
            objSelectCmd.Parameters.Add("p_fkClient", MySqlDbType.Int32).Value = _fkClient;

            try
            {
                // Se ejecuta el comando y se obtiene el número de filas afectadas.
                row = objSelectCmd.ExecuteNonQuery();

                // Si se inserta una fila correctamente, se establece executed a true.
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

        // Método para actualizar un carrito
        public bool updateCars(int _id, int _cantidad, int _fkProduct, int _fkClient)
        {
            bool executed = false;
            int row;

            MySqlCommand objSelectCmd = new MySqlCommand();
            objSelectCmd.Connection = objPer.openConnection();
            objSelectCmd.CommandText = "spUpdateCar"; //nombre del procedimiento almacenado
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            // Se agregan parámetros al comando para pasar los valores del carrito.
            objSelectCmd.Parameters.Add("p_id", MySqlDbType.Int32).Value = _id;
            objSelectCmd.Parameters.Add("p_cantidad", MySqlDbType.Int32).Value = _cantidad;
            objSelectCmd.Parameters.Add("p_fkProduct", MySqlDbType.Int32).Value = _fkProduct;
            objSelectCmd.Parameters.Add("p_fkClient", MySqlDbType.Int32).Value = _fkClient;

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
    
