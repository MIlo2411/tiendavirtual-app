using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ProductLog
    {
        ProductDat objpro = new ProductDat();

        public bool InsertProduct(string _nombre, string _descripcion, double _precio, int _stock, string _imagen, int _proveedor_Id, int _categoria_Id)
        {
            return objpro.InsertProduct( _nombre, _descripcion, _precio, _stock, _imagen,  _proveedor_Id,  _categoria_Id);

        }


        public bool UpdateProduct(int _id, string _nombre, string _descripcion, double _precio, int _stock, string _imagen)
        {
            return objpro.UpdateProduct(_id,  _nombre,  _descripcion,  _precio,  _stock,  _imagen);
        }

        public bool DeleteProduct(int _id)
        {
            return objpro.DeleteProduct(_id);
        }
        public DataSet ShowProducts()
        {
            return objpro.ShowProducts();
        }

        public DataSet procShowProductsDDL()
        {
            return objpro.procShowProductsDDL();
        }
        }
    }