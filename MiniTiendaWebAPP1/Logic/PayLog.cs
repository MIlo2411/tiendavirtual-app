using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Logic
{
    public class PayLog
    {
        PayDat objpay = new PayDat();

        public DataSet showPay()
        {
            return objpay.showPay();
        }

        public bool savePay(double _monto, string _fecha, string _metodo_pago, int _pedidos_ped_id)
        {
            return objpay.savePay( _monto,  _fecha,  _metodo_pago,  _pedidos_ped_id);

        }

        public bool updatePay(int _id, double _monto, string _fecha, string _metodo_pago, int _pedidos_ped_id)
        {
            return objpay.updatePay(_id, _monto, _fecha, _metodo_pago, _pedidos_ped_id);
        }

        public bool deletePay(int _id)
        {
            return objpay.deletePay(_id);
        }

        public DataSet procShowPayDDL()
        {
            return objpay.procShowPayDDL();

        }



        }
    }