using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDePedidos
{
    public class Pedido
    {
        public int numeroPedido;
        public Cliente cliente;
        public ItemPedido item;
        public double valorPedido;

    }

    public class ItemPedido
    {
        public int quantidade;
        public int numeroPedido;
        public Produto produto1;
        public Produto produto2;
        public Produto produto3;
    }

    public class Produto
    {
        public int codigoProduto;
        public string descricao;
        public double valorUnitario;
        public int quantidade;
    }  
}
