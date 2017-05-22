using Aula2205_EF_DATABASEFIRST.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2205_EF_DATABASEFIRST.Views.Categoria
{
    public partial class ListaCategorias : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Contexto (Referencia para o banco)
            strConnLojaEntities contexto = new strConnLojaEntities();

            gvwCategorias.DataSource = contexto.Categorias.ToList();
            gvwCategorias.DataBind();


        }
    }
}