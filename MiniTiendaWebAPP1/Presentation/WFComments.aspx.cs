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
    public partial class WFComments : System.Web.UI.Page
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

        private int _id, _fkClientes, _fkProductos;
        private string _comentario, _fecha;
        private double _calificacion;
        private bool executed = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            /* 
             * Se verifica si la página se está cargando por primera vez o 
             * si es una devolución de datos del servidor.
             */
            if (!Page.IsPostBack)
            {
                ShowComment();//Se invoca el metodo para mostrar todos los productos
                ShowClientsDDL();//Se invoca el metodo para mostrar los proveedores en el DDL
                ShowProductsDDL();
                // Se oculta el campo de texto TBId.
                //TBId.Visible = false;
            }
        }
        private void ShowClientsDDL()
        {
            // Se asigna el origen de datos al DropDownList,
            // utilizando el método showCategoriesDDL de la instancia objCat de la clase CategoryLog.
            DDLClients.DataSource = objCli.ShowClientsDDL();

            // Se especifica el campo que se utilizará como valor de cada elemento del DropDownList.
            DDLClients.DataValueField = "cli_id";

            // Se especifica el campo que se mostrará como texto para cada elemento del DropDownList.
            DDLClients.DataTextField = "nombre_completo";

            // Se enlaza el origen de datos con el DropDownList.
            DDLClients.DataBind();

            // Se agrega un elemento "Seleccione" al principio del DropDownList para indicar al usuario que elija una categoría.
            DDLClients.Items.Insert(0, "Seleccione");
        }
        //Metodo para mostrar los proveedores en el DDL
        private void ShowProductsDDL()
        {
            DDLProducts.DataSource = objPro.ShowProducts();
            DDLProducts.DataValueField = "pro_id";//Nombre de la llave primaria
            DDLProducts.DataTextField = "pro_nombre";
            //DDLProducts.DataTextField = "pro_descripcion";
            //DDLProducts.DataTextField = "pro_precio";
            //DDLProducts.DataTextField = "pro_stock";
            DDLProducts.DataBind();
            DDLProducts.Items.Insert(0, "Seleccione");
        }



        //Metodo para mostrar todos los productos
        private void ShowComment()
        {
            DataSet ds = new DataSet();
            ds = objComm.ShowComments();
            GVComments.DataSource = ds;
            GVComments.DataBind();
        }
        private void clear()
        {
            HFCommentId.Value = "";
            TBComment.Text = "";
            TBCalification.Text = "";
            TBFecha.Text = "";
            DDLProducts.SelectedIndex = 0;
            DDLClients.SelectedIndex = 0;
        }


        protected void BtnSave_Click(object sender, EventArgs e)
        {
            _comentario = TBComment.Text; //capturar el valor que se ingrese en el text box 
            _calificacion = Convert.ToDouble(TBCalification.Text) ;
            _fecha = TBFecha.Text;
            _fkProductos = Convert.ToInt32(DDLProducts.SelectedValue);
            _fkClientes = Convert.ToInt32(DDLClients.SelectedValue);

            executed = objComm.SaveComments(_id, _comentario, _calificacion, _fecha, _fkProductos, _fkClientes);

            if (executed)
            {
                LblMsj.Text = "El producto se guardo exitosamente!";
                clear(); // se invoca el metodo para limpiar los textbox y DDL
                ShowComment(); // se invoca el metodo para mostrar los productos
            }
            else
            {
                LblMsj.Text = "Error al guardar!";

            }
        }


        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(HFCommentId.Value); //lave primaria
            _comentario = TBComment.Text; //capturar el valor que se ingrese en el text box 
            _calificacion = Convert.ToDouble(TBCalification.Text);
            _fecha = TBFecha.Text;
            _fkProductos = Convert.ToInt32(DDLProducts.SelectedValue);
            _fkClientes = Convert.ToInt32(DDLClients.SelectedValue);

            executed = objComm.UpdateComments(_id, _comentario, _calificacion, _fecha, _fkProductos, _fkClientes);

            if (executed)
            {
                LblMsj.Text = "El comentario se actualizo exitosamente!";
                clear(); // se invoca el metodo para limpiar los textbox y DDL
                ShowComment(); // se invoca el metodo para mostrar los productos
            }
            else
            {
                LblMsj.Text = "Error al actualizar!";

            }
        }


        protected void GVComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFCommentId.Value = GVComments.SelectedRow.Cells[0].Text;
            TBComment.Text = GVComments.SelectedRow.Cells[1].Text;
            TBCalification.Text = GVComments.SelectedRow.Cells[2].Text;
            TBFecha.Text = GVComments.SelectedRow.Cells[3].Text;
            DDLProducts.SelectedValue = GVComments.SelectedRow.Cells[4].Text;
            DDLClients.SelectedValue = GVComments.SelectedRow.Cells[5].Text;
        }

    }
}