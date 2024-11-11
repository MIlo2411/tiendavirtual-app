using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class CarLog
    {
        CarDat objcar = new CarDat();

        public DataSet ShowCars()
        {
            return objcar.ShowCars();
        }

        public bool SaveCars(int _cantidad, int _fkProduct, int _fkClient)
        {
            return objcar.SaveCars(_cantidad, _fkProduct, _fkClient);
        }

        public bool UpdateCars(int _id, int _cantidad, int _fkProduct, int _fkClient)
        {
            return objcar.UpdateCars(_id, _cantidad,  _fkProduct, _fkClient);
        }

        public bool DeleteCar(int _idCar)
        {
            return objcar.DeleteCar(_idCar);
        }
        public DataSet ShowCarDDL()
        {
            return objcar.ShowCarDDL();
        }

        }
    }