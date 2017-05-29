using Aula2405_EF_MODELFIRST.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aula2405_EF_MODELFIRST.Controllers
{
    public class CategoriaController
    {
        BaseDadosContainer contextoc = new BaseDadosContainer();
        public static bool add(Categoria C)
        {
            BaseDadosContainer contextoc = new BaseDadosContainer();
            try
            {
                contextoc.Categorias.Add(C);
                contextoc.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }//Em casa

        //Na aula
        protected BaseDadosContainer contexto = new BaseDadosContainer();

        public void Adicionar(Categoria categoria)
        {
            if(categoria != null)
            {
                contexto.Categorias.Add(categoria);
                contexto.SaveChanges();
            }
        }
        public List<Categoria> Listar()
        {
            return 
                contexto.Categorias.ToList()
                .Where(c=>c.Ativo==true)
                .ToList();
        }
        public List<Categoria> ListarInativos()
        {
            return
                contexto.Categorias
                .Where(c => c.Ativo == false)
                .ToList();
        }
        public Categoria BuscarCategoriaPorID(int id)
        {
            return contexto.Categorias.Find(id);
        }
        /*public void Excluir(Categoria categoria)
        {
            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Deleted;
            contexto.SaveChanges();
        }Exclusão fisica, gera delete*/

        //Exclusão lógica, gera um update
        public void Excluir(Categoria categoria)
        {
            categoria.Ativo = false;
            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
        public void Editar(Categoria categoria)
        {
            contexto.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }
    }
}