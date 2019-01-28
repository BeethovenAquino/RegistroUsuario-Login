using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using BLL;
using System.Web.UI.WebControls;

namespace Registro
{
    public partial class Login1 : System.Web.UI.Page
    {
        private Repositorio<Usuarios> BLL = new Repositorio<Usuarios>();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtrar = x => true;
            Usuarios usuarios = new Usuarios();
            filtrar = t => t.Nombre.Equals(UsuarioTexbox.Text) && t.Clave.Equals(ContraseñaTextBox.Text);

            if (BLL.GetList(filtrar).Count() != 0)
                FormsAuthentication.RedirectFromLoginPage(usuarios.Nombre, true);
            else
                ScriptManager.RegisterStartupScript(this, typeof(Page), "toastr_message", script: "toastr['error']('usuario o contraseña Incorrecto');", addScriptTags: true);
        }
    }
    
}