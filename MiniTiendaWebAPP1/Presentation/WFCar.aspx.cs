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
    public partial class WFCar : System.Web.UI.Page
    {
        CarLog objCarrito = new CarLog();
        ClientLog objCust = new ClientLog();
        ProductLog objProd = new ProductLog();

        private int _id, _cantidad, _fkProduct, _fkClient;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                ShowCars();
                ShowClientsDDL();
                showProductsDDL();
            }
        }

        private void ShowClientsDDL()
        {
            DDLClientes.DataSource = objCust.ProcShowClientsDDL();
            DDLClientes.DataValueField = "cli_id";
            DDLClientes.DataTextField = "nombre_completo";
            DDLClientes.DataBind();
            DDLClientes.Items.Insert(0, "Seleccione");
        }

        private void showProductsDDL()
        {
            DDLProductos.DataSource = objProd.procShowProductsDDL();
            DDLProductos.DataValueField = "pro_id";
            DDLProductos.DataTextField = "pro_nombre";
            DDLProductos.DataBind();
            DDLProductos.Items.Insert(0, "Seleccione");
        }

        private void ShowCars()
        {
            DataSet ds = new DataSet();
            ds = objCarrito.ShowCars();
            GVCarrito.DataSource = ds;
            GVCarrito.DataBind();
        }

        
        private void clear()
        {
            HFCarId.Value = "";
            TBCantidad.Text = "";
            DDLProductos.SelectedIndex = 0;
            DDLClientes.SelectedIndex = 0;
        }

    

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            _cantidad = Convert.ToInt32(TBCantidad.Text);
            _fkProduct = Convert.ToInt32(DDLProductos.SelectedValue);
            _fkClient = Convert.ToInt32(DDLClientes.SelectedValue);

            bool executed = objCarrito.SaveCars(_cantidad, _fkProduct, _fkClient);

            if (executed)
            {
                LblMsj.Text = "¡El carrito se guardó exitosamente!";
                clear();
                ShowCars();
            }
            else
            {
                LblMsj.Text = "¡Error al guardar!";
            }


        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            
            _id = Convert.ToInt32(HFCarId.Value);
            _cantidad = Convert.ToInt32(TBCantidad.Text);
            _fkProduct = Convert.ToInt32(DDLProductos.SelectedValue);
            _fkClient = Convert.ToInt32(DDLClientes.SelectedValue);

            bool executed = objCarrito.UpdateCars(_id, _cantidad, _fkProduct, _fkClient);

            if (executed)
            {
                LblMsj.Text = "¡El carrito se actualizó exitosamente!";
                clear();
                ShowCars();
            }
            else
            {
                LblMsj.Text = "¡Error al actualizar!";
            }


        }
        protected void GVCarrito_SelectedIndexChanged1(object sender, EventArgs e)
        {
            HFCarId.Value = GVCarrito.SelectedRow.Cells[0].Text;
            TBCantidad.Text = GVCarrito.SelectedRow.Cells[1].Text;
            DDLProductos.SelectedValue = GVCarrito.SelectedRow.Cells[2].Text;
            DDLClientes.SelectedValue = GVCarrito.SelectedRow.Cells[3].Text;
        }
        protected void GVCarrito_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int _id = Convert.ToInt32(GVCarrito.DataKeys[e.RowIndex].Values[0]);
            bool executed = objCarrito.DeleteCar(_id);

            if (executed)
            {
                LblMsj.Text = "¡El carrito se eliminó exitosamente!";
                GVCarrito.EditIndex = -1;
                ShowCars();
            }
            else
            {
                LblMsj.Text = "¡Error al eliminar!";
            }
        }

    }
}