using Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Logic
{
    public class CategoryLog
    {
        CategoryDat objcat = new CategoryDat();

        public bool SaveCategory(string _nombre, string _descripcion)
        {
            return objcat.SaveCategory(_nombre, _descripcion);
        }

        public bool UpdateCategory(int _id, string _nombre, string _descripcion)
        {
            return objcat.UpdateCategory(_id,  _nombre,  _descripcion);
        }

        public bool DeleteCategory(int _id) 
        { 
            return objcat.DeleteCategory(_id);
        }

        public DataSet ShowCategories()
        {
            return objcat.ShowCategories();
        }
        public DataSet ShowCategoryDDL()
        {
            return objcat.ShowCategoryDDL();
        }
        }
    }