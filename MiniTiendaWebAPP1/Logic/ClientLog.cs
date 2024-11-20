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

        public bool SaveClients(string _nombre, string _apellido, string _correo, string _contrasena, string _direccion_envio, string _telefono, string _tarjeta_id, string _saldo)
        {
            return objcli.SaveClients(_nombre, _apellido, _correo, _contrasena, _direccion_envio, _telefono, _tarjeta_id,  _saldo);
        }

        public bool UpdateClients(int _id, string _nombre, string _apellido, string _correo, string _contrasena, string _direccion_envio, string _telefono, string _tarjeta_id, string _saldo)
        {
            return objcli.UpdateClients(_id, _nombre, _apellido, _correo, _contrasena, _direccion_envio, _telefono, _tarjeta_id,  _saldo);
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