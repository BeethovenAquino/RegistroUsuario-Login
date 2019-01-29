using BLL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registro.Consultar
{
    public partial class ConsultarUsuario : System.Web.UI.Page
    {
        public static List<Usuarios> Lista { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FechaunoTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                FechadosTextBox.Text = DateTime.Now.ToString("yyyy-MM-dd");
                
                UsuarioGridView.DataBind();
            }
        }
    

        protected void ButtonBuscar_Click1(object sender, EventArgs e)
        {
            Expression<Func<Usuarios, bool>> filtro = x => true;
            Repositorio<Usuarios> repositorio = new Repositorio<Usuarios>();

            DateTime desde = Convert.ToDateTime(FechaunoTextBox.Text); 
            DateTime hasta = Convert.ToDateTime(FechadosTextBox.Text); 


            int id;
            switch (TipodeFiltro.SelectedIndex)
            {
                case 0://ID
                    id = Convert.ToInt32(TextCriterio.Text);
                    filtro = c => c.UsuarioId == id;
                    break;
                case 1:// nombre
                    filtro = c => c.Nombre.Contains(TextCriterio.Text);
                    break;

                case 2:// Usuario
                    filtro = c => c.NombreUsuario.Contains(TextCriterio.Text);
                    break;

                case 3:// Telefono
                    filtro = c => c.Telefono.Contains(TextCriterio.Text);
                    break;

                   

                case 4:// Celular
                    filtro = c => c.celular.Contains(TextCriterio.Text);
                    break;

                case 5:
                

                    filtro = p => p.Fecha >= desde.Date && p.Fecha <= hasta.Date;

                    UsuarioGridView.DataSource = filtro;
                    UsuarioGridView.DataBind();

                    break;

            }

            UsuarioGridView.DataSource = repositorio.GetList(filtro);
            UsuarioGridView.DataBind();
        }
    }
    }
