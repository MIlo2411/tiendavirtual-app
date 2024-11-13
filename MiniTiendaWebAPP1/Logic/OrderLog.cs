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
    public class OrderLog
    {

        OrderDat objord = new OrderDat();

        public DataSet ShowOrders()
        {
            return objord.ShowOrders();
        }

        public bool SaveOrders(int _id, string _fecha, string _estado, int _total, int _fkclients)
        {
            return objord.SaveOrders(_id, _fecha, _estado, _total, _fkclients);
        }

        public bool DeleteOrders(int _id)
        {
            return objord.DeleteOrder(_id);
        }

        public bool UpdateOrders(int _id, string _fecha, string _estado, int _total, int _fkclients)
        {
            return objord.UpdateOrders(_id, _fecha, _estado, _total, _fkclients);
        }

        public DataSet ShowOderDDL()
        {

 TAL-61-Create-feature-sp-WFOrder
            return objord.ShowOderDDL();
        }
    }
}

        public DataSet ShowOrderDDL()
        {
            return objord.ShowOrderDDL();
        }

    }
    }
 develop
