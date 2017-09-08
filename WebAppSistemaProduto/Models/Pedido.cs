using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppSistemaProduto.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public int ClienteID { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime? DataEnvio { get; set; }
        public DateTime? DataEntrega { get; set; }
        public List <ItensdoPedidos> Itens { get; set; }
    }
}