using Logic;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class WFCategory : System.Web.UI.Page
    {
        // Instancia de la clase CategoriesLog para interactuar con la lógica 
        CategoryLog objCat = new CategoryLog();

        private int _id;
        private string _nombre;
        private string _description;
        private bool executed = false;

        // Bandera para saber si la operación fue exitosa
        protected void Page_Load(object sender, EventArgs e)
        {
            // Solo se ejecuta cuando se carga la página por primera vez (no en postbacks)
            if (!Page.IsPostBack)
            {
                ShowCategories(); // Mostrar todas las categorías
            }
        }
        // Mostrar todas las categorías en el GridView
        private void ShowCategories()
        {
            DataSet objData = new DataSet();
            objData = objCat.ShowCategories();// Obtiene todas las categorías
            GVCategories.DataSource = objData;         // Asigna el DataSet al GridView
            GVCategories.DataBind();              // Enlaza los datos con el GridView
        }

        //Metodo para limpiar los TextBox y los DDL
        private void Clear()
        {
            HFCategoryId.Value = "";
            TBNombre.Text = "";  // Limpiar el
            TBDescripcion.Text = "";
          


        }
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            // Captura el nombre de la categoría
            _nombre = TBNombre.Text;
            _description = TBDescripcion.Text;
            // Llamada a la lógica  para guardar la categoría
            executed = objCat.SaveCategory(_nombre,_description);

            if (executed)
            {
                LblMsj.Text = "¡Categoría guardada exitosamente!";
                LblMsj.ForeColor = System.Drawing.Color.Green;
                Clear();  // Limpiar el TextBox después de guardar
                ShowCategories();       // Mostrar las categorías actualizadas
            }
            else
            {
                LblMsj.Text = "¡Error al guardar la categoría!";
                LblMsj.ForeColor = System.Drawing.Color.Red;
            }

        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _id = Convert.ToInt32(HFCategoryId.Value);  // Obtener el ID de la categoría seleccionada
            _nombre = TBNombre.Text;    // Obtener el nombre de la categoría

            // Llamada a la lógica de negocio para actualizar la categoría
            executed = objCat.UpdateCategory(_id, _nombre, _description);

            if (executed)
            {
                LblMsj.Text = "¡Categoría actualizada exitosamente!";
                LblMsj.ForeColor = System.Drawing.Color.Green;
                Clear();
                ShowCategories();        // Mostrar las categorías actualizadas
            }
            else
            {
                LblMsj.Text = "¡Error al actualizar la categoría!";
                LblMsj.ForeColor = System.Drawing.Color.Red;
            }
        }
        // Evento para seleccionar una fila en el GridView y cargar los datos en los controles
        protected void GVCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el ID de la categoría seleccionada
            HFCategoryId.Value = GVCategories.SelectedRow.Cells[0].Text;
            TBNombre.Text = GVCategories.SelectedRow.Cells[1].Text; // Cargar el nombre de la categoría
            TBDescripcion.Text = GVCategories.SelectedRow.Cells[2].Text;
        }

        // Evento para eliminar una categoría
        protected void GVCategories_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            int categoryId = Convert.ToInt32(GVCategories.DataKeys[e.RowIndex].Values[0]);
            executed = objCat.DeleteCategory(categoryId);

            if (executed)
            {
                LblMsj.Text = "La Categoria se elimino exitosamente";
                GVCategories.EditIndex = -1;
                ShowCategories();
            }
            else
            {
                LblMsj.Text = "Error al eliminar el producto";
            }

        }
    }
}