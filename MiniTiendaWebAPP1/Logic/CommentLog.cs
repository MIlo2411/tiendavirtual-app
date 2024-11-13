using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;

namespace Logic
{
    public class CommentLog
    {
        CommentDat objcom = new CommentDat();
        public bool SaveComments(int _id, string _comentario, double _calificacion, string _fecha, int _fkProductos, int _fkClientes)
        {
            return objcom.SaveComments(_id, _comentario, _calificacion, _fecha, _fkProductos, _fkClientes);

        }

        public bool UpdateComments(int _id, string _comentario, double _calificacion, string _fecha, int _fkProductos, int _fkClientes)
        {
            return objcom.UpdateComments(_id, _comentario, _calificacion, _fecha, _fkProductos, _fkClientes);
        }

        public bool DeleteComment(int _idComment)
        {
            return objcom.DeleteComment(_idComment);
        }

        public DataSet ShowComments()
        {
            return objcom.ShowComments();
        }

        public DataSet ShowCommentsDDL()
        {
            return objcom.ShowCommentsDDL();
        }

    }
}