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
        ProvidersDat objpro = new ProvidersDat();

        public DataSet showProviders()
        {
            return objpro.showProviders();  
        }
        public DataSet showProvidersDDL()
        {

            return objpro.showProvidersDDL();
        }

        public bool saveProvider(string _nombre, string _contacto, string _telefono, string _direccion)
        {
            return objpro.saveProvider(_nombre, _contacto, _telefono, _direccion);
        }

        public bool updateProvider(int _idProvider, string _nombre, string _contacto, string _telefono, string _direccion)
        {
            return objpro.updateProvider(_idProvider, _nombre, _contacto, _telefono, _direccion);
        }

        public bool deleteProvider(int _idProvider)
        {
            return objpro.deleteProvider(_idProvider);
        }

    }
}