﻿using Aula2405_EF_MODELFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2405_EF_MODELFIRST.Views.Categorias
{
    public partial class Lista : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Categoria> categorias = contexto.Categorias.ToList();
        }
    }
}