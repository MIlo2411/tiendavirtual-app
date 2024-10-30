using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class CommentsLog
    {
        CommentDat objcar = new CommentDat();

        public DataSet showComments()
        {
            return objcar.showComments();
        }
        public bool saveComments(int _id, string _comentario, double _calificacion, DateTime _fecha, int _productos_pro_id, int _clientes_cli_id)
        {

            return objcar.saveComments(_id, _comentario, _calificacion, _fecha, _productos_pro_id, _clientes_cli_id);
        }

        public bool updateComments(int _id, string _comentario, double _calificacion, DateTime _fecha, int _productos_pro_id, int _clientes_cli_id)
        {
            return objcat.updateComments(_id, _comentario, _calificacion, _fecha, _productos_pro_id, _clientes_cli_id);


            public bool deleteComment(int _idComment)
            {
                return objcar.deleteComment(_idComment);
            }

            public DataSet procShowCommentsDDL()
            {
                return objcar.procShowCommentsDDL();
            }
        }
}