using Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WPOrder : System.Web.UI.Page
    {
        OrderLog objord = new OrderLog();
        ClientLog objuse = new ClientLog();

        private int _id, _total, _clientes_cli_id;
        private string _fecha, _estado;
        private bool executed = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                ShowOrder();//Se invoca el metodo para mostrar todos los productos
                ShowClientDDL();//Se invoca el metodo para mostrar los proveedores en el DDL

                // Se oculta el campo de texto TBId.
                //TBId.Visible = false;
            }
        }

        

        private void ShowClientDDL()
            {
                DDLClients.DataSource = objuse.ProcShowClientsDDL();
                DDLClients.DataValueField = "cli_id";//Nombre de la llave primaria
                DDLClients.DataTextField = "nombre_completo";
                DDLClients.DataBind();
                DDLClients.Items.Insert(0, "Seleccione");

            }

        

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
           
            _fecha = TBFecha.Text;
            _estado = TBEstado.Text;
            _total = Convert.ToInt32(TBTotal.Text);
            _clientes_cli_id = Convert.ToInt32(DDLClients.Text);

            executed = objord.SaveOrders(_fecha, _estado, _total, _clientes_cli_id);


            if (executed)
            {
                LblMsj.Text = "¡El detalle de pedido se guardó exitosamente!";
                clear(); // Limpiar los TextBox después de guardar
                ShowOrder();// Mostrar los carritos actualizados
            }
            else
            {
                LblMsj.Text = "¡Error al guardar!";
            }


        }


        protected void BtnUpdate_Click(object sender, EventArgs e)
        {

            _id = Convert.ToInt32(HFOrderId.Value);
            _fecha = TBFecha.Text;
            _estado = TBEstado.Text;
            _total = Convert.ToInt32(TBTotal.Text);
            _clientes_cli_id = Convert.ToInt32(DDLClients.Text);

            executed = objord.UpdateOrders(_id, _fecha, _estado, _total, _clientes_cli_id);


            if (executed)
            {
                LblMsj.Text = "¡El detalle de pedido se actualiso exitosamente!";
                clear(); // Limpiar los TextBox después de guardar
                ShowOrder();// Mostrar los carritos actualizados
            }
            else
            {
                LblMsj.Text = "¡Error al actualizar!";
            }


        }

        protected void GVComments_SelectedIndexChanged(object sender, EventArgs e)
        {

            {
                HFOrderId.Value = GVOrders.SelectedRow.Cells[0].Text;
                TBFecha.Text = GVOrders.SelectedRow.Cells[1].Text;
                TBEstado.Text = GVOrders.SelectedRow.Cells[2].Text;
                TBTotal.Text = GVOrders.SelectedRow.Cells[3].Text;
                DDLClients.SelectedValue = GVOrders.SelectedRow.Cells[4].Text;
                
            }

        }


    }

}
