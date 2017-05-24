using Aula2405_EF_MODELFIRST.Controllers;
using Aula2405_EF_MODELFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2405_EF_MODELFIRST.Views.Categorias
{
    public partial class cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void salvar_Click(object sender, EventArgs e)
        {
            if (!txtDesc.Text.Equals("") && !txtNome.Text.Equals(""))
            {
                var categoria = new Categoria();
                categoria.Nome = txtNome.Text;
                categoria.Descricao = txtDesc.Text;
                if ((CategoriaController.add(categoria)) == true)
                {
                    mensagemSucesso.Visible = true;
                }
                else
                {
                    mensagemErro.Visible = true;

                }
            }
        }
    }
}