using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class OrderLog
    {

        OrderDat objord = new OrderDat();

        public DataSet ShowOrders()
        {
            return objord.ShowOrders();
        }

        public bool SaveOrders( string _fecha, string _estado, int _total, int _clientes_cli_id)
        {
            return objord.SaveOrders( _fecha, _estado, _total,  _clientes_cli_id);
        }

        public bool DeleteOrders(int _id)
        {
            return objord.DeleteOrder(_id);
        }

        public bool UpdateOrders(int _id, string _fecha, string _estado, int _total, int _clientes_cli_id)
        {
            return objord.UpdateOrders(_id, _fecha, _estado, _total, _clientes_cli_id);
        }
        public DataSet ShowOderDDL()
        {
            return objord.ShowOderDDL();
        }


        }
    }