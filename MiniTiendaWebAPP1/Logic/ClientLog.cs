using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class ClientLog
    {
        ClientDat objcli = new ClientDat();

        public DataSet ShowClients()

        {
            return objcli.ShowClients();
        }

        public bool SaveClients(int _id, string _nombre, string _apellido, string _correo, string _contrasena, string _direccion_envio, string _telefono, DateTime _fecha_registro)
        {
            return objcli.SaveClients(_id, _nombre, _apellido, _correo, _contrasena, _direccion_envio, _telefono, _fecha_registro);
        }

        public bool UpdateClients(int _id, string _nombre, string _apellido, string _correo, string _contrasena, string _direccion_envio, string _telefono, DateTime _fecha_registro)
        {
            return objcli.UpdateClients(_id, _nombre, _apellido, _correo, _contrasena, _direccion_envio, _telefono, _fecha_registro);
        }

        public bool DeleteClients(int _id)
        {
            return objcli.DeleteClient(_id);
        }

        public DataSet ShowClientsDDL()
        {
            return objcli.ShowClientsDDL();
        }

    }

}