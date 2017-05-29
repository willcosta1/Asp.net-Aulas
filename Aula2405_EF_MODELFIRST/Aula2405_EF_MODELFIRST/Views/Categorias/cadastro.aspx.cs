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
        
        protected void btnSalvar_Click1(object sender, EventArgs e)
        {
            /* Primeira aula
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
            }*/
            Categoria cat = new Categoria();
            cat.Descricao = txtDesc.Text;
            cat.Nome = txtNome.Text;
            cat.Ativo = true;

            /*Com static, lembrando que static fica na memoria(Warning)
            CategoriaController.Adicionar(cat);
            
            */
            CategoriaController ctrl = new CategoriaController();
            ctrl.Adicionar(cat);

        }
    }
}