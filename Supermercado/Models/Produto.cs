using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Supermercado.Models
{
    public class Produto
    {
        public string Nome { get; set; }
        public string Preco { get; set; }
        public int Codigo { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
    }
}