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
    public partial class WFOrder : System.Web.UI.Page
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
        OrderLog objord = new OrderLog();
        PayLog objPay = new PayLog();
        UsersLog objUser = new UsersLog();
        DetailsOrdersLog objDet = new DetailsOrdersLog();

        private int _id, _total, _fkclients;
        private string _fecha, _estado;
        private bool executed = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            /* 
      * Se verifica si la página se está cargando por primera vez o 
      * si es una devolución de datos del servidor.
      */
            if (!Page.IsPostBack)
            {
                ShowOrder();//Se invoca el metodo para mostrar todos los productos
                ShowClientsDDL();//Se invoca el metodo para mostrar los proveedores en el DDL
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




        //Metodo para mostrar todos los productos
        private void ShowOrder()
        {
            DataSet ds = new DataSet();
            ds = objord.ShowOrders();
            GVOrders.DataSource = ds;
            GVOrders.DataBind();
        }
        private void clear()
        {
            HFOrderId.Value = "";
            TBFecha.Text = "";
            TBEstado.Text = "";
            TBTotal.Text = "";
            DDLClients.SelectedIndex = 0;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            _fecha = Convert.ToString(TBFecha.Text);
            _estado = Convert.ToString(TBEstado.Text);
            _total = Convert.ToInt32(TBTotal.Text);
            _fkclients = Convert.ToInt32(DDLClients.SelectedValue);

            executed = objord.SaveOrders(_id, _fecha, _estado, _total, _fkclients);

            if (executed)
            {
                LblMsj.Text = "La orden se guardo exitosamente!";
                clear(); // se invoca el metodo para limpiar los textbox y DDL
                ShowOrder(); // se invoca el metodo para mostrar los productos
            }
            else
            {
                LblMsj.Text = "Error al guardar!";

            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(HFOrderId.Value); //lave primaria
            _fecha = Convert.ToString(TBFecha.Text);
            _estado = Convert.ToString(TBEstado.Text);
            _total = Convert.ToInt32(TBTotal.Text);
            _fkclients = Convert.ToInt32(DDLClients.SelectedValue);

            executed = objord.UpdateOrders(_id, _fecha, _estado, _total, _fkclients);

            if (executed)
            {
                LblMsj.Text = "la orden se actualizo exitosamente!";
                clear(); // se invoca el metodo para limpiar los textbox y DDL
                ShowOrder(); // se invoca el metodo para mostrar los productos
            }
            else
            {
                LblMsj.Text = "Error al actualizar!";

            }
        }

        protected void GVComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFOrderId.Value = GVOrders.SelectedRow.Cells[0].Text;
            TBFecha.Text = GVOrders.SelectedRow.Cells[1].Text;
            TBEstado.Text = GVOrders.SelectedRow.Cells[2].Text;
            TBTotal.Text = GVOrders.SelectedRow.Cells[3].Text;
            DDLClients.SelectedValue = GVOrders.SelectedRow.Cells[4].Text;
        }
    }
}