using Aula2405_EF_MODELFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula2405_EF_MODELFIRST.Views
{
    public class BasePage : System.Web.UI.Page
    {
        protected BaseDadosContainer contexto = new BaseDadosContainer();

    }
}