using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Supermercado.Models;

namespace Supermercado.Controllers
{
    public class ProdutosController : Controller
    {
        public ActionResult Index()
        {
            using (ProdutoModel model = new ProdutoModel())
            {
                List<Produto> lista = model.Read();
                var maisComprados = lista.Take(3);
                var todasAsCategorias = lista.Select(x => x.Categoria).Distinct().ToList();
                ViewBag.Categorias = todasAsCategorias;
                return View(maisComprados);

            }
           
        }

        public ActionResult TodosOsProdutos()
        {
            using (ProdutoModel model = new ProdutoModel())
            {
                List<Produto> lista = model.Read();
              
                return View(lista);
            }
        }

        public ActionResult MostraProduto(int codigo, string nome, string categoria)
        {
            using (ProdutoModel model = new ProdutoModel())
            {
                List<Produto> lista = model.Read();
                return View(lista.FirstOrDefault(x => x.Codigo == codigo));

            }
        }

        public ActionResult MostraCategoria(string categoria)
        {
            using (ProdutoModel model = new ProdutoModel())
            {
                List<Produto> lista = model.Read();
                var categoriaEspecifica = lista.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
                ViewBag.Categoria = categoria;
                return View(categoriaEspecifica);

            }

        }

    }
}