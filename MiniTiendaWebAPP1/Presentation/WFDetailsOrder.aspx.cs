using Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Presentation
{
    public partial class WFDetailsOrder : System.Web.UI.Page
    {
        /* 
       * Se crean instancias de las clases CategoryLog, ProvidersLog
       * y ProductsLog para interactuar con la lógica de negocio.
       */
        CommentLog objComm = new CommentLog();
        ProductLog objPro = new ProductLog();
        ProvidersLog objProv = new ProvidersLog();
        CategoryLog objCat = new CategoryLog();
        ClientLog objCli = new ClientLog();
        CarLog objCar = new CarLog();
        OrderLog objOrd = new OrderLog();
        PayLog objPay = new PayLog();
        UsersLog objUser = new UsersLog();
        DetailsOrdersLog objDet = new DetailsOrdersLog();

        private int _detId, _detCantidad,  _fkPedido, _fkProducto;
        private double _detPrecio;
        private bool executed = false;
        
        protected void Page_Load(object sender, EventArgs e)
        {
                /* 
                 * Se verifica si la página se está cargando por primera vez o 
                 * si es una devolución de datos del servidor.
                 */
                if (!Page.IsPostBack)
                {
                    ShowDetailsOrders();//Se invoca el metodo para mostrar todos los productos
                    ShowOrdersDDL();//Se invoca el metodo para mostrar los proveedores en el DDL
                    ShowProductsDDL();
                    // Se oculta el campo de texto TBId.
                    //TBId.Visible = false;
                }
        }

        private void ShowOrdersDDL()
        {
            // Se asigna el origen de datos al DropDownList,
            // utilizando el método showCategoriesDDL de la instancia objCat de la clase CategoryLog.
            DDLOrders.DataSource = objOrd.ShowOrderDDL();

            // Se especifica el campo que se utilizará como valor de cada elemento del DropDownList.
            DDLOrders.DataValueField = "ped_id";

            // Se especifica el campo que se mostrará como texto para cada elemento del DropDownList.
            DDLOrders.DataTextField = "ped_total";

            // Se enlaza el origen de datos con el DropDownList.
            DDLOrders.DataBind();

            // Se agrega un elemento "Seleccione" al principio del DropDownList para indicar al usuario que elija una categoría.
            DDLOrders.Items.Insert(0, "Seleccione");
        }
        //Metodo para mostrar los proveedores en el DDL
        private void ShowProductsDDL()
        {
            DDLProducts.DataSource = objPro.ShowProducts();
            DDLProducts.DataValueField = "pro_id";//Nombre de la llave primaria
            DDLProducts.DataTextField = "pro_nombre";
            DDLProducts.DataBind();
            DDLProducts.Items.Insert(0, "Seleccione");
        }

        //Metodo para mostrar todos los productos
        private void ShowDetailsOrders()
        {
            DataSet ds = new DataSet();
            ds = objDet.ShowDetailsOrders();
            GVDetailsOrders.DataSource = ds;
            GVDetailsOrders.DataBind();
        }
        private void clear()
        {
            HFDetailsOrdersID.Value = "";
            TBQuantity.Text = "";
            TBPrice.Text = "";
            DDLProducts.SelectedIndex = 0;
            DDLOrders.SelectedIndex = 0;
        }


        protected void BtnSave_Click(object sender, EventArgs e)
        {
            _detCantidad = Convert.ToInt32(TBQuantity.Text); //capturar el valor que se ingrese en el text box 
            _detPrecio = Convert.ToDouble(TBQuantity.Text);
            _fkPedido = Convert.ToInt32(DDLOrders.SelectedValue);
            _fkProducto = Convert.ToInt32(DDLProducts.SelectedValue);

            executed = objDet.SaveDetailsOrder( _detCantidad, _detPrecio, _fkPedido, _fkProducto);

            if (executed)
            {
                LblMsj.Text = "El producto se guardo exitosamente!";
                clear(); // se invoca el metodo para limpiar los textbox y DDL
                ShowDetailsOrders(); // se invoca el metodo para mostrar los productos
            }
            else
            {
                LblMsj.Text = "Error al guardar!";

            }
        }



        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _detId = Convert.ToInt32(HFDetailsOrdersID.Value);
            _detCantidad = Convert.ToInt32(TBQuantity.Text); //capturar el valor que se ingrese en el text box 
            _detPrecio = Convert.ToDouble(TBQuantity.Text);
            _fkPedido = Convert.ToInt32(DDLOrders.SelectedValue);
            _fkProducto = Convert.ToInt32(DDLProducts.SelectedValue);

            executed = objDet.UpdateDetailsOrder(_detId, _detCantidad, _detPrecio, _fkPedido, _fkProducto);

            if (executed)
            {
                LblMsj.Text = "El pedido se actualizo exitosamente!";
                clear(); // se invoca el metodo para limpiar los textbox y DDL
                ShowDetailsOrders(); // se invoca el metodo para mostrar los productos
            }
            else
            {
                LblMsj.Text = "Error al actualizar!";

            }
        }



        protected void GVDetailsOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFDetailsOrdersID.Value = GVDetailsOrders.SelectedRow.Cells[0].Text;
            TBQuantity.Text = GVDetailsOrders.SelectedRow.Cells[1].Text;
            TBPrice.Text = GVDetailsOrders.SelectedRow.Cells[2].Text;
            DDLOrders.SelectedValue = GVDetailsOrders.SelectedRow.Cells[3].Text;
            DDLProducts.SelectedValue = GVDetailsOrders.SelectedRow.Cells[4].Text;
        }




    }
}