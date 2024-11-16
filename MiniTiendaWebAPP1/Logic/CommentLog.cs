using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class CommentLog
    {
        CommentDat objcom = new CommentDat();
        public bool SaveComments(int _id, string _comentario, double _calificacion, string _fecha, int _productos_pro_id, int _clientes_cli_id)
        {
            return objcom.SaveComments(_id, _comentario, _calificacion, _fecha, _productos_pro_id, _clientes_cli_id);

        }

        public bool UpdateComments(int _id, string _comentario, double _calificacion, string _fecha, int _productos_pro_id, int _clientes_cli_id)
        {
            return objcom.UpdateComments(_id, _comentario, _calificacion, _fecha, _productos_pro_id, _clientes_cli_id);
        }

        public bool DeleteComment(int _idComment)
        {
            return objcom.DeleteComment(_idComment);    
        }

        public DataSet ShowComment()
        {
            return objcom.ShowComment();
        }

        }
    }