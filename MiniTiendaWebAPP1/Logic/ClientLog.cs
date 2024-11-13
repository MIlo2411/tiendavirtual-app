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

        public DataSet procShowClients()

        {
            return objcli.procShowClients();
        }

        public bool SaveClients(string _nombre, string _apellido, string _correo, string _contrasena, string _direccion_envio, int _telefono)
        {
            return objcli.SaveClients( _nombre, _apellido, _correo, _contrasena, _direccion_envio, _telefono);
        }

        public bool UpdateClients(int _id,string _nombre, string _apellido, string _correo, string _contrasena, string _direccion_envio, int _telefono)
        {
            return objcli.UpdateClients( _id,  _nombre,  _apellido,  _correo,  _contrasena,  _direccion_envio, _telefono);
        }

        public bool DeleteClients(int _id)
        {
            return objcli.DeleteClient(_id);
        }

        public DataSet ProcShowClientsDDL()
        {
            return objcli.ProcShowClientsDDL();
        }

        }

}