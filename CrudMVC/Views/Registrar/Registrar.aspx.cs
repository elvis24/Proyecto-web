using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudMVC.Views.Registrar
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnRegistrar.Click += BtnRegistrar_Click;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtNombre.Text)) stMensaje += "Ingrese nombre, ";
                if (string.IsNullOrEmpty(txtApellido.Text)) stMensaje += "Ingrese Apellido, ";
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "IngreseEmail, ";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += "Ingrese Password, ";
                if (string.IsNullOrEmpty(txtConfirmarPassword.Text)) stMensaje += "Confirme Password";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'error') </script>");
            }
        }
    }
}