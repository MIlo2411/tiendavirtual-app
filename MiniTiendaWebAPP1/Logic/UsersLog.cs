using Data;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class UsersLog
    {
        UsersDat objuser = new UsersDat();
        public bool SaveUsuario(string _nombre, string _apellido, string _correo, string _contrasena, string _direccion, string _telefono, string _registro)
        {
            return objuser.SaveUsuario(_nombre, _apellido, _correo, _contrasena, _direccion, _telefono, _registro);
        }

        public bool UpdateUsuario(int _id, string _nombre, string _apellido, string _correo, string _contrasena, string _direccion, string _telefono)
        {
            return objuser.UpdateUsuario(_id, _nombre, _apellido, _correo, _contrasena, _direccion, _telefono);
        }

        public DataSet ShowUsuarios()
        {

            return objuser.ShowUsuarios();
        }

        public bool DeleteUsuario(int _id)
        {
            return objuser.DeleteUsuario(_id);
        }

        }
    }