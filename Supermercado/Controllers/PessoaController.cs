using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Supermercado.Models;

namespace Supermercado.Controllers
{
    public class PessoaController : Controller
    {
        public ActionResult Cadastro()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
            
        }
        [HttpPost]
        public ActionResult Cadastro(Pessoa pessoa)
        {
            if (ModelState.IsValid)
            {
                using (PessoaModel model = new PessoaModel())
                {
                    model.Create(pessoa);
                }
                return View("Resultado", pessoa);
               
            }

            return View(pessoa);
        }

        public ActionResult VerCadastros()
        {
            using (PessoaModel model = new PessoaModel())
            {
                List<Pessoa> lista = model.Read();

                return View(lista);
            }
        }

        public ActionResult Resultado(Pessoa pessoa)
        {
            return View(pessoa);
        }

        public ActionResult LoginUnico(string Login)
        {
            using (PessoaModel model = new PessoaModel())
            {
                List<Pessoa> pessoas = model.Read();
                return Json(pessoas.All(x => x.Login.ToLower() != Login.ToLower()), JsonRequestBehavior.AllowGet);

            }
            
        }
    }
}