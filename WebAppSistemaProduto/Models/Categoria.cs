using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSistemaProduto.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public String Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}