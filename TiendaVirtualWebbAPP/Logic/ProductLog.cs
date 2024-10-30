using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ProductLog
    {
        ProductDat objcar = new ProductDat();

        public DataSet ShowProducts()
        {
            return objcar.ShowProducts();
        }
        public bool public bool InsertProduct(string nombre, string descripcion, double precio, int stock, string imagen, int proveedorId, int categoriaId)
        {

            return objcar.InsertProduct(nombre, descripcion, precio, stock, imagen, proveedorId, categoriaId);
        }

        public bool UpdateProduct(int id, string nombre, string descripcion, double precio, int stock, string imagen)
        {
            return objcat.UpdateProduct(id, nombre, descripcion, precio, stock, imagen);


            public bool DeleteProduct(int id)
            {
                return objcar.DeleteProduct(id);
            }

            public DataSet procShowProductsDDL()
            {
                return objcar.procShowProductsDDL();
            }
        }
}