using Logic;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFProviders : System.Web.UI.Page
    {

        ProvidersLog objProv = new ProvidersLog();

        private int _id; 
        private string _nombre, _contacto, _telefono, _direccion;

        private bool executed = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                showProviders();//Se invoca el metodo para mostrar todos los productos
                // Se oculta el campo de texto TBId.
                //TBId.Visible = false;
            }

            



        }
        private void showProviders()
        {
            DataSet ds = new DataSet();
            ds = objProv.showProviders();
            GVProvedores.DataSource = ds;
            GVProvedores.DataBind();
        }

        

        private void clear()
        {
            HFProvedores.Value = "";
            TBNombre.Text = "";
            TBDContacto.Text = "";
            TBTelefono.Text = "";
            TBDireccion.Text = "";
            }
        protected void BtnSave_Click(object sender, EventArgs e)
        {

            _nombre = TBNombre.Text;
            _contacto = TBDContacto.Text;
            _telefono= TBTelefono.Text;
            _direccion = TBDireccion.Text;

            executed = objProv.saveProvider(_nombre, _contacto, _telefono, _direccion);


            if (executed)
            {
                LblMsj.Text = "¡El Producto se guardó exitosamente!";
                clear(); // Limpiar los TextBox después de guardar
                showProviders();// Mostrar los carritos actualizados
            }
            else
            {
                LblMsj.Text = "¡Error al guardar!";
            }


        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(HFProvedores.Value);
            _nombre = TBNombre.Text;
            _contacto = TBDContacto.Text;
            _telefono = TBTelefono.Text;
            _direccion = TBDireccion.Text;

            executed = objProv.updateProvider(_id, _nombre, _contacto, _telefono, _direccion);


            if (executed)
            {
                LblMsj.Text = "¡El Producto se guardó exitosamente!";
                clear(); // Limpiar los TextBox después de guardar
                showProviders();// Mostrar los carritos actualizados
            }
            else
            {
                LblMsj.Text = "¡Error al guardar!";
            }


        }

        protected void GVProvedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            HFProvedores.Value = GVProvedores.SelectedRow.Cells[0].Text;
            TBNombre.Text = GVProvedores.SelectedRow.Cells[1].Text;
            TBDContacto.Text = GVProvedores.SelectedRow.Cells[2].Text;
            TBTelefono.Text = GVProvedores.SelectedRow.Cells[3].Text;
            TBDireccion.Text = GVProvedores.SelectedRow.Cells[4].Text;
            

        }


    }
}