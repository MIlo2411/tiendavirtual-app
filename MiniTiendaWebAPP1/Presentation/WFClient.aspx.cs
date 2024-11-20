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
    public partial class WFClient : System.Web.UI.Page
    {
        // Instancia de la clase CustomersLog para interactuar con la lógica
        ClientLog objClient = new ClientLog();

        private int _id;
        private string _nombre;
        private string _apellido;
        private string _correo;
        private string _contrasena;
        private string _direccion_envio;
        private string _telefono;
        private string _tarjeta_id, _saldo;

        // Bandera para saber si la operación fue exitosa
        private bool executed = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Solo se ejecuta cuando se carga la página por primera vez (no en postbacks)
            if (!Page.IsPostBack)
            {
                procShowClients(); // Mostrar todos los clientes

            }
        }
        private void procShowClients()
        {
            DataSet objData = new DataSet();
            objData = objClient.procShowClients(); // Obtiene todos los clientes
            GVClientes.DataSource = objData; // Asigna el DataSet al GridView
            GVClientes.DataBind(); // Enlaza los datos con el GridView
        }
        private void Clear()
        {
           
            TBNombre.Text = "";
            TBApellido.Text = "";
            TBCorreo.Text = "";
            TBContrasena.Text = "";
            TBDireccion.Text = "";
            TBTelefono.Text = "";
            TBtarjeta.Text = "";
            TBsaldo.Text = "";
        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            // Capturar los datos del cliente

            _nombre = TBNombre.Text;
            _apellido = TBApellido.Text;
            _correo = TBCorreo.Text;
            _contrasena = TBContrasena.Text;
            _direccion_envio = TBDireccion.Text;
            _telefono = Convert.ToString(TBTelefono.Text);
            _tarjeta_id = TBtarjeta.Text;
            _saldo = TBsaldo.Text;  
            // Llamada a la lógica para guardar el cliente

            executed = objClient.SaveClients(_nombre, _apellido, _correo, _contrasena, _direccion_envio, _telefono, _tarjeta_id, _saldo);

            if (executed)
            {
                LblMsj.Text = "¡Cliente guardado exitosamente!";
                LblMsj.ForeColor = System.Drawing.Color.Green;
                Clear(); // Limpiar los TextBox después de guardar
                procShowClients(); // Mostrar los clientes actualizados
            }
            else
            {
                LblMsj.Text = "¡Error al guardar el cliente!";
                LblMsj.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Obtener los datos del cliente
            _id = Convert.ToInt32(HFClienteId.Value);
            _nombre = TBNombre.Text;
            _apellido = TBApellido.Text;
            _correo = TBCorreo.Text;
            _contrasena = TBContrasena.Text;
            _direccion_envio = TBDireccion.Text;
            _telefono = Convert.ToString(TBTelefono.Text);
            _tarjeta_id = TBtarjeta.Text;
            _saldo = TBsaldo.Text;


            // Llamada a la lógica de negocio para actualizar el cliente
            executed = objClient.UpdateClients(_id, _nombre, _apellido, _correo, _contrasena, _direccion_envio, _telefono, _tarjeta_id, _saldo);

            if (executed)
            {
                LblMsj.Text = "¡Cliente actualizado exitosamente!";
                LblMsj.ForeColor = System.Drawing.Color.Green;
                Clear();
                procShowClients(); // Mostrar los clientes actualizados
            }
            else
            {
                LblMsj.Text = "¡Error al actualizar el cliente!";
                LblMsj.ForeColor = System.Drawing.Color.Red;
            }
        }
        // Evento para seleccionar una fila en el GridView y cargar los datos en los controles
        protected void GVClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID del cliente seleccionado
            HFClienteId.Value = GVClientes.SelectedRow.Cells[0].Text;
            TBNombre.Text = GVClientes.SelectedRow.Cells[1].Text;
            TBApellido.Text = GVClientes.SelectedRow.Cells[2].Text;
            TBCorreo.Text = GVClientes.SelectedRow.Cells[3].Text;
            TBContrasena.Text = GVClientes.SelectedRow.Cells[4].Text;
            TBDireccion.Text = GVClientes.SelectedRow.Cells[5].Text;
            TBTelefono.Text = GVClientes.SelectedRow.Cells[6].Text;
            TBtarjeta.Text = GVClientes.SelectedRow.Cells[7].Text;
            TBsaldo.Text = GVClientes.SelectedRow.Cells[8].Text;
        }

        // Evento para eliminar un cliente
        protected void GVClientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int clienteId = Convert.ToInt32(GVClientes.DataKeys[e.RowIndex].Values[0]);
            executed = objClient.DeleteClients(clienteId);

            if (executed)
            {
                LblMsj.Text = "El cliente se eliminó exitosamente";
                GVClientes.EditIndex = -1;
                procShowClients();
            }
            else
            {
                LblMsj.Text = "Error al eliminar el cliente";
            }
        }
    }
}