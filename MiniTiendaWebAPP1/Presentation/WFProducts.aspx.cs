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
<<<<<<< HEAD
            DDLProviders.DataSource = objProv.ShowProviderDDL();    
            DDLProviders.DataValueField = "prov_id";//Nombre de la llave primaria
            DDLProviders.DataTextField = "prov_nombre";
            DDLProviders.DataBind();
            DDLProviders.Items.Insert(0, "Seleccione");
=======
         DDLProviders.DataSource = objProv.ShowProviderDDL();    
        DDLProviders.DataValueField = "prov_id";//Nombre de la llave primaria
        DDLProviders.DataTextField = "prov_nombre";
        DDLProviders.DataBind();
        DDLProviders.Items.Insert(0, "Seleccione");
        DDLProviders.DataBind();
>>>>>>> 880f6094283c914010a7e901a161ca49b51b3778

        }

        //Metodo para mostrar todos los productos
        private void ShowProducts()
        {
            DataSet ds = new DataSet();
            ds = objProd.ShowProducts();
            GVProducts.DataSource = ds;
            GVProducts.DataBind();
        }


        private void clear()
        {
            HFProductId.Value = "";
            TBNombre.Text = "";
            TBDescription.Text = "";
            TBPrice.Text = "";
            TBStock.Text = "";
            DDLProviders.SelectedIndex = 0;
            DDLCategories.SelectedIndex = 0;
        }

        //Evento para guardar cuando uno le de click
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            
            _nombre = TBNombre.Text;
            _descripcion = TBDescription.Text;
            _precio = Convert.ToInt32(TBPrice.Text);
            _stock = Convert.ToInt32(TBStock.Text);
            _imagen = TBtImg.Text;
            _proveedor_Id = Convert.ToInt32(DDLProviders.Text);
            _categoria_Id = Convert.ToInt32(DDLCategories.Text);

            executed = objProd.InsertProduct(_nombre, _descripcion, _precio, _stock, _imagen, _proveedor_Id, _categoria_Id);
            

            if (executed)
            {
                LblMsj.Text = "¡El Producto se guardó exitosamente!";
                clear(); // Limpiar los TextBox después de guardar
                ShowProducts();// Mostrar los carritos actualizados
            }
            else
            {
                LblMsj.Text = "¡Error al guardar!";
            }

        }

        //Evento para actualizar cuando uno le de click
        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(HFProductId.Value);
            _nombre = TBNombre.Text;
            _descripcion = TBDescription.Text;
            _precio = Convert.ToDouble(TBPrice.Text);
            _stock = Convert.ToInt32(TBStock.Text);
            _imagen = TBtImg.Text;
           

            executed = objProd.UpdateProduct(_id, _nombre, _descripcion, _precio, _stock, _imagen);


            if (executed)
            {
                LblMsj.Text = "¡El Producto se actualizo exitosamente!";
                clear(); // Limpiar los TextBox después de guardar
                ShowProducts();// Mostrar los carritos actualizados
            }
            else
            {
                LblMsj.Text = "¡Error al actualizar!";
            }



        }

        protected void GVProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Asignar el valor de la fila seleccionada a los controles
            HFProductId.Value = GVProducts.SelectedRow.Cells[0].Text;
            TBNombre.Text = GVProducts.SelectedRow.Cells[1].Text;
            TBDescription.Text = GVProducts.SelectedRow.Cells[2].Text;
            TBPrice.Text = GVProducts.SelectedRow.Cells[3].Text;
            TBStock.Text = GVProducts.SelectedRow.Cells[4].Text;
            TBtImg.Text = GVProducts.SelectedRow.Cells[5].Text;

            // Configuración de DDLProviders (proveedor) y DDLCategories (categoría)
            if (!string.IsNullOrEmpty(GVProducts.SelectedRow.Cells[6].Text))
            {
                DDLProviders.SelectedValue = GVProducts.SelectedRow.Cells[6].Text;
            }

            if (!string.IsNullOrEmpty(GVProducts.SelectedRow.Cells[7].Text))
            {
                DDLCategories.SelectedValue = GVProducts.SelectedRow.Cells[7].Text;
            }
            

        }

        

    }


}