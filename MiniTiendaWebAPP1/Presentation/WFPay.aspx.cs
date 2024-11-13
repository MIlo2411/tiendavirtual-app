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
    public partial class WFPay : System.Web.UI.Page
    {
        OrderLog objord = new OrderLog();
        PayLog objPay = new PayLog();

        private int _id, _pedidos_ped_id;
        private double _monto;
        private string _fecha, _metodo_pago;

        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                showPay();//Se invoca el metodo para mostrar todos los productos
                ShowOderDDL();//Se invoca el metodo para mostrar los proveedores en el DDL

                // Se oculta el campo de texto TBId.
                //TBId.Visible = false;
            }


        }
        private void ShowOderDDL()
        {
            // Se asigna el origen de datos al DropDownList,
            // utilizando el método showCategoriesDDL de la instancia objCat de la clase CategoryLog.

            DDLPedidos.DataSource = objord.ShowOderDDL();

            // Se especifica el campo que se utilizará como valor de cada elemento del DropDownList.
            DDLPedidos.DataValueField = "ped_id";


            // Se especifica el campo que se mostrará como texto para cada elemento del DropDownList.
            DDLPedidos.DataTextField = "ped_fecha";

            // Se enlaza el origen de datos con el DropDownList.
            DDLPedidos.DataBind();

            // Se agrega un elemento "Seleccione" al principio del DropDownList para indicar al usuario que elija una categoría.
            DDLPedidos.Items.Insert(0, "Seleccione");
        }

        private void showPay()
        {
            DataSet ds = new DataSet();
            ds = objPay.showPay();
            GVPagos.DataSource = ds;
            GVPagos.DataBind();
        }

        private void clear()
        {
            HFPagos.Value = "";
            TBmonto.Text = "";
            TBfecha.Text = "";
            TBPago.Text = "";
            DDLPedidos.SelectedIndex = 0;

        }


        protected void BtnSave_Click(object sender, EventArgs e)
        {
            
            _monto = Convert.ToDouble(TBmonto.Text);
            _fecha = TBfecha.Text;
            _metodo_pago = TBPago.Text;
            _pedidos_ped_id = Convert.ToInt32(DDLPedidos.Text);

            executed = objPay.savePay( _monto, _fecha, _metodo_pago, _pedidos_ped_id);


            if (executed)
            {
                LblMsj.Text = "¡El Producto se guardó exitosamente!";
                clear(); // Limpiar los TextBox después de guardar
                showPay();// Mostrar los carritos actualizados
            }
            else
            {
                LblMsj.Text = "¡Error al guardar!";


            }
        }




    

    protected void BtnUpdate_Click(object sender, EventArgs e)
        {

            _id = Convert.ToInt32(HFPagos.Value);
            _monto = Convert.ToDouble(TBmonto.Text);
            _fecha = TBfecha.Text;
            _metodo_pago = TBPago.Text;
            _pedidos_ped_id = Convert.ToInt32(DDLPedidos.Text);

            executed = objPay.updatePay(_id, _monto, _fecha, _metodo_pago, _pedidos_ped_id);


            if (executed)
            {
                LblMsj.Text = "¡El Pago se actualizo exitosamente!";
                clear(); // Limpiar los TextBox después de guardar
                showPay();// Mostrar los carritos actualizados
            }
            else
            {
                LblMsj.Text = "¡Error al actualizar!";


            }


        }

        protected void GVPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Asignar el valor de la fila seleccionada a los controles
            HFPagos.Value = GVPagos.SelectedRow.Cells[0].Text;
            TBmonto.Text = GVPagos.SelectedRow.Cells[1].Text;
            TBfecha.Text = GVPagos.SelectedRow.Cells[2].Text;
            TBPago.Text = GVPagos.SelectedRow.Cells[3].Text;

            // Configuración de DDLProviders (proveedor) y DDLCategories (categoría)
            if (!string.IsNullOrEmpty(GVPagos.SelectedRow.Cells[4].Text))
            {
                DDLPedidos.SelectedValue = GVPagos.SelectedRow.Cells[4].Text;
            }

        }
    }
}