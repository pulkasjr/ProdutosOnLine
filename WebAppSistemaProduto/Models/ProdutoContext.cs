﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppSistemaProduto.Models
{
    public class ProdutoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProdutoContext() : base("name=ProdutoContext")
        {
        }

        public System.Data.Entity.DbSet<WebAppSistemaProduto.Models.Pedido> Pedidoes { get; set; }

        public System.Data.Entity.DbSet<WebAppSistemaProduto.Models.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<WebAppSistemaProduto.Models.Categoria> Categorias { get; set; }

        public System.Data.Entity.DbSet<WebAppSistemaProduto.Models.Produto> Produtoes { get; set; }
    }
}
