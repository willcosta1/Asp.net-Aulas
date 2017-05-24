using Aula2405_EF_MODELFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula2405_EF_MODELFIRST.Controllers
{
    public class CategoriaController
    {
        public static bool add(Categoria C)
        {
            BaseDadosContainer contexto = new BaseDadosContainer();
            try
            {
                contexto.Categorias.Add(C);
                contexto.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}