using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registro.Registro_Usuario
{
    public partial class Usuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Usuarios LlenaClase(Usuarios usuarios)
        {
            int id;
            bool result = int.TryParse(usuarioid.Text, out id);
            if(result ==true)
            {
                usuarios.UsuarioId = id;
            }
            else
            {
                usuarios.UsuarioId = 0;
            }
              
            usuarios.Nombre = nombreTextbox.Text;
           usuarios.NombreUsuario = NombreUsuarioTextBox.Text;
           usuarios.Clave = ClaveTextbox.Text;
            //usuario.Fecha = FechadateTime;
            usuarios.Email = EmailTextbox.Text;
           usuarios.Telefono = TelefonoTextbox.Text;
            usuarios.celular = CelularTextbox.Text;
            return usuarios;
        } 

        private void LlenaCampos(Usuarios usuarios)
        {
            usuarioid.Text = usuarios.UsuarioId.ToString();
            nombreTextbox.Text = usuarios.Nombre;
            NombreUsuarioTextBox.Text = usuarios.NombreUsuario;
            ClaveTextbox.Text = usuarios.Clave;
            //FechadateTime.Text = usuarios.Fecha;
            EmailTextbox.Text = usuarios.Email;
            TelefonoTextbox.Text = usuarios.Telefono;
            CelularTextbox.Text = usuarios.celular;

        }

        private void Limpiar()
        {
            usuarioid.Text = "";
            nombreTextbox.Text = "";
            NombreUsuarioTextBox.Text = "";
            ClaveTextbox.Text = "";
            FechadateTime.Text = "";
            EmailTextbox.Text = "";
            TelefonoTextbox.Text = "";
            CelularTextbox.Text = "";
        }


        void MostrarMensaje(TiposMensajes tipo, string mensaje)

        {

            ErrorLabel.Text = mensaje;
            
            if (tipo == TiposMensajes.Success)

                ErrorLabel.CssClass = "alert-success";

            else

                ErrorLabel.CssClass = "alert-danger";

        }

        


        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            Usuarios usuario = repositorio.Buscar(Convert.ToInt32(usuarioid.Text));
            if (usuario != null)
            {
                LlenaCampos(usuario);
            }
            else
            {
                Response.Write("<script>alert('Usuario no encontrado');</script>");

            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();

            int id = Convert.ToInt32(usuarioid.Text);



            var usuario = repositorio.Buscar(id);



            if (usuario == null)

                MostrarMensaje(TiposMensajes.Error, "Registro no encontrado");

            else

                repositorio.Eliminar(id);
        }

         //Boton Guardar
        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();
            Usuarios usuarios = new Usuarios();
            bool paso = false;

            LlenaClase(usuarios);
            //Validacion
            if (usuarios.UsuarioId == 0)

                paso = repositorio.Guardar(usuarios);
            else
                paso = repositorio.Modificar(usuarios);
            if (paso)

            {
                MostrarMensaje(TiposMensajes.Success, "Registro Exitoso!");
                Limpiar();
                
            }
            else
                MostrarMensaje(TiposMensajes.Error, "No fue posible Guardar el Registro");

            Limpiar();
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}