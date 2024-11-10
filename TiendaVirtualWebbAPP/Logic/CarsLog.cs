using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class CarsLog
    {
        CarDat objcar = new CarDat();

        public DataSet showCars()
        {
            return objcar.showCars();
        }
        public bool public bool saveCars(int _cantidad, int _fkProduct, int _fkClient)
        {

            return objcar.save saveCars(int _cantidad, int _fkProduct, int _fkClient);
        }

        public bool updateCars(int _id, int _cantidad, int _fkProduct, int _fkClient)
        {
            return objcat.updateCars(int _id, int _cantidad, int _fkProduct, int _fkClient);
        }

        public bool deleteCar(int _idCar)
        {
            return objcar.deleteCar(int _idCar);
        }

        public DataSet showCar()
        {
            return objcar.showCar();
        }
    }
    }