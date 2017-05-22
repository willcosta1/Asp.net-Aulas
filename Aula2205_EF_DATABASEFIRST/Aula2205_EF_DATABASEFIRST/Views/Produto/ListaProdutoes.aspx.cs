using Aula2205_EF_DATABASEFIRST.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2205_EF_DATABASEFIRST.Views.Produto
{
    public partial class ListaProdutoes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            strConnLojaEntities contexto = new strConnLojaEntities();
            gvwProdutoes.DataSource = contexto.Produtoes.ToList();
            gvwProdutoes.DataBind();
        }
    }
}