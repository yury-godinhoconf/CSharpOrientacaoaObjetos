using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TotalClientes
{
    public class Cliente
    {
        private string nomeCliente;
        public static int TotalDeCliente { get; private set; }

        public Cliente(string Nome)
        {
            this.nomeCliente = Nome;
            TotalDeCliente++;
        }
    }
}
