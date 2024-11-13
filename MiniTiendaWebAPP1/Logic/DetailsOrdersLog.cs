using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class DetailsOrdersLog
    {
        DetailsOrdersDat objdet = new DetailsOrdersDat();

        public DataSet ShowDetailsOrders()
        {
            return objdet.ShowDetailsOrders();
        }

        public bool SaveDetailsOrder(int _detCantidad, double _detPrecio, int _fkPedido, int _fkProducto)
        {
            return objdet.SaveDetailsOrder(_detCantidad, _detPrecio, _fkPedido, _fkProducto);
        }

        public bool UpdateDetailsOrder(int _detId, int _detCantidad, double _detPrecio, int _fkPedido, int _fkProducto)
        {
            return objdet.UpdateDetailsOrder(_detId, _detCantidad, _detPrecio, _fkPedido, _fkProducto);
        }
        public bool DeleteDetailsOrder(int _detId)
        {
            return objdet.DeleteDetailsOrder(_detId);
        }
        public DataSet ShowDetallesPedidoDDL()
        {
            return objdet.ShowDetallesPedidoDDL();  
        }


        }
    }