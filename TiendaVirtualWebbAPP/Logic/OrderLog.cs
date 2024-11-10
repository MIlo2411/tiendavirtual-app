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

        public DataSet showOrders()
        {
            return objord.showOrders();
        }

        public bool saveOrders(int _id, string _fecha, string _estado, int _total, int _clientes_cli_id)
        {
            return objord.saveOrders(_id, _fecha, _estado, _total, _clientes_cli_id);
        }

        public bool updateOrders(int _id, DateTime _fecha, string _estado, int _total, int _clientes_cli_id)
        {
            return objord.updateOrders(_id, _fecha, _estado, _total, _clientes_cli_id);
        }
        public bool deleteOrders(int _id)
        {
            return objord.deleteOrder(_id);
        }
        public DataSet showOderDDL()
        {
            return objord.showOderDDL();
        }

        }
}