using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CrudMVC.Views.login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnIngresar.Click += BtnIngresar_Click;
            //if(!IsPostBack)
            //ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Buen trabajo!', 'Se grabo con exito!', 'success') </script>");
            
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje+= "Ingrese email,";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += "Ingrese Password,";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script> swal('Error!', '" + ex.Message + "!', 'error') </script>");
            }
        }
    }
}