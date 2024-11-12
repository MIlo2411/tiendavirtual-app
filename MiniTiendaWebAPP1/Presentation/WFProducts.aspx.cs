using Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFProducts : System.Web.UI.Page
    {

        ProductLog objProd = new ProductLog();
        ProvidersLog objProv = new ProvidersLog();
        CategoryLog objCat = new CategoryLog();


        private string _nombre, _descripcion, _imagen;
        private double _precio;
        private int _id, _stock, _proveedor_Id, _categoria_Id;

        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                ShowProducts();//Se invoca el metodo para mostrar todos los productos
                ShowProviderDDL();//Se invoca el metodo para mostrar los proveedores en el DDL
                ShowCategoriesDDL();
                // Se oculta el campo de texto TBId.
                //TBId.Visible = false;
            }
        
        
        }

        // Mostrar las categorias en el DDL


        //Metodo para mostrar las categorias en el DDL
        private void ShowCategoriesDDL()
        {
            // Se asigna el origen de datos al DropDownList,
            // utilizando el método showCategoriesDDL de la instancia objCat de la clase CategoryLog.
            DDLCategories.DataSource = objCat.ShowCategoryDDL();

            // Se especifica el campo que se utilizará como valor de cada elemento del DropDownList.
            DDLCategories.DataValueField = "cat_id";

            // Se especifica el campo que se mostrará como texto para cada elemento del DropDownList.
            DDLCategories.DataTextField = "nombre";

            // Se enlaza el origen de datos con el DropDownList.
            DDLCategories.DataBind();

            // Se agrega un elemento "Seleccione" al principio del DropDownList para indicar al usuario que elija una categoría.
            DDLCategories.Items.Insert(0, "Seleccione");
        }

        private void ShowProviderDDL()
        {
         DDLProviders.DataSource = objProv.ShowProviderDDL();    
        DDLProviders.DataValueField = "prov_id";//Nombre de la llave primaria
        DDLProviders.DataTextField = "prov_nombre";
        DDLProviders.DataBind();
        DDLProviders.Items.Insert(0, "Seleccione");
        DDLProviders.DataBind();

        }

        //Metodo para mostrar todos los productos
        private void ShowProducts()
        {
            DataSet ds = new DataSet();
            ds = objProd.ShowProducts();
            GVProducts.DataSource = ds;
            GVProducts.DataBind();
        }

    }
}