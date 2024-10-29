using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Logic
{
    public class CategoryLog
    {
        OrderDat objord = new OrderDat();

        public DataSet showCategories()
        {
            return objord.showCategories();
        }

        public bool saveCategory(string nombre, string descripcion)
        {
            return objord.saveCategory(_id, _fecha, _estado, _total, _clientes_cli_id);
        }

        public bool updateCategory(int id, string nombre, string descripcion)
        {
            return objord.updateCategory( id, nombre, descripcion);
        }
        public bool deleteCategory(int _id)
        {
            return objord.deleteCategory(_id);
        }
        public DataSet procShowCategoryDDL()
        {
            return objord.procShowCategoryDDL();
        }

    }
}
}