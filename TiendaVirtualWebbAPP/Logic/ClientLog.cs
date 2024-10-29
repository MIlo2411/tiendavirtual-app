using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ClientLog
    {
        ClientDat objord = new ClientDat();

        public DataSet showClients()
        {
            return objord.showDetailsOrders();
        }

        public bool saveClients(int _id, string _nombre, string _apellido, string _correo, string _contrasena, string _direccion_envio, int _telefono, DateTime _fecha_registro)
        {
            return objord.saveClients( _id,  _nombre, _apellido,  _correo,  _contrasena,  _direccion_envio,  _telefono,  _fecha_registro);
        }

        public bool updateClients(int _id, string _nombre, string _apellido, string _correo, string _contrasena, string _direccion_envio, int _telefono, DateTime _fecha_registro)
        {
            return objord.updateClients( _id,  _nombre,  _apellido,  _correo,  _contrasena,  _direccion_envio,  _telefono,  _fecha_registro));
        }
        public bool DeleteClient(int id)
        {
            return objord.DeleteClient( id);
        }
        public DataSet procShowClientsDDL()
        {
            return objord.procShowClientsDDL();
        }
    }
}