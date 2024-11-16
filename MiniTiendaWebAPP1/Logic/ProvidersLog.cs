using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ProvidersLog
    {
        ProvidersDat objprov = new ProvidersDat();

        public DataSet ShowSuppliers()
        {
            return objprov.ShowSuppliers();
        }

        public DataSet ShowSuppliersDDL()
        {
            return objprov.ShowSuppliersDDL();
        }

        public bool SaveSuppliers(string _nombre, string _contacto, string _telefono, string _direccion)
        {
            return objprov.SaveSuppliers(_nombre, _contacto, _telefono, _direccion);
        }

        public bool UpdateSuppliers(int _id, string _nombre, string _contacto, string _telefono, string _direccion)
        {
            return objprov.UpdateSuppliers(_id, _nombre, _contacto, _telefono, _direccion);
        }
        public bool deleteSuppliers(int _id)
        { 
            return objprov.DeleteSuppliers(_id);
        }



        }
    }