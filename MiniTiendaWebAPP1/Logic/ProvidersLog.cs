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

        public DataSet showProviders()
        {
            return objprov.showProviders();
        }

        public DataSet showProvidersDDL()
        {
            return objprov.showProvidersDDL();
        }

        public bool saveProvider(string _nombre, string _contacto, string _telefono, string _direccion)
        {
            return objprov.saveProvider(_nombre, _contacto, _telefono, _direccion);
        }

        public bool updateProvider(int _id, string _nombre, string _contacto, string _telefono, string _direccion)
        {
            return objprov.updateProvider(_id, _nombre, _contacto, _telefono, _direccion);
        }
        public bool deleteProvider(int _id)
        { 
            return objprov.deleteProvider(_id);
        }

        public DataSet ShowProviderDDL()
        {
            return objprov.ShowProviderDDL();
        }




        }
    }