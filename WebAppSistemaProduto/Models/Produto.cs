using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSistemaProduto.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
        public String Descricao { get; set; }
        public decimal Valor { get; set; }
        public List <Pedido> Pedidos  { get; set; }
    }
}