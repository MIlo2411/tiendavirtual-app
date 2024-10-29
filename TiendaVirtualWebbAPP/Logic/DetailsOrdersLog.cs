using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class DetailsOrdersLog
    {
        OrderDat objord = new OrderDat();

        public DataSet showDetailsOrders()
        {
            return objord.showDetailsOrders();
        }

        public bool saveDetailsOrder(int _detCantidad, double _detPrecio, int _fkPedido, int _fkProducto)
        {
            return objord.saveDetailsOrder( _detCantidad, _detPrecio, _fkPedido, _fkProducto);
        }

        public bool updateDetailsOrder(int _detId, int _detCantidad, double _detPrecio, int _fkPedido, int _fkProducto)
        {
            return objord.updateDetailsOrder( _detId, _detCantidad, _detPrecio, _fkPedido, _fkProducto);
        }
        public bool deleteDetailsOrder(int _detId)
        {
            return objord.deleteDetailsOrder(_detId);
        }
        public DataSet procShowDetallesPedidoDDL()
        {
            return objord.procShowDetallesPedidoDDL();
        }
    }
}