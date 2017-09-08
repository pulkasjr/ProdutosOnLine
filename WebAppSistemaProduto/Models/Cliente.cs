using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSistemaProduto.Models
{
    public class Cliente
    {
            public int ClienteID { get; set; }
            public String Nome { get; set; }
            public int Idade { get; set; }
            public List <Pedido> Pedidos { get; set; }

    }
}