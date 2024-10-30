using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class PayLog
    {
        payDat objcar = new PayDat();

        public DataSet showPay()
        {
            return objcar.showCars();
        }
        public bool public bool savePay(int _id, double _monto, DateTime _fecha, string _metodo_pago, int _pedidos_ped_id)
        {

            return objcar.save savePay(_id, _monto, _fecha, _metodo_pago, _pedidos_ped_id);
        }

        public bool updatePago(int _id, double _monto, DateTime _fecha, string _metodo_pago, int _pedidos_ped_id)
        {
            return objcat.updatePago(_id, _monto, _fecha, _metodo_pago, _pedidos_ped_id);
        }

        public bool deletePayment(_idPayment)
        {
            return objcar.deletePayment(_idPayment);
        }

        public DataSet procShowPagosDDL()
        {
            return objcar.procShowPagosDDL();
        }
    }
}