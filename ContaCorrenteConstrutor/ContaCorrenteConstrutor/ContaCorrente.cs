using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrenteConstrutor
{
    public class ContaCorrente
    {
        public string nomeTitular;
        public string cpf;
        public int numeroAgencia;
        public string conta;

        public ContaCorrente(string Titular, string CPFTitular, int NumeroAgencia, string NumeroConta) 
        { 
            this.nomeTitular = Titular;
            this.cpf = CPFTitular;
            this.numeroAgencia = NumeroAgencia;
            this.conta = NumeroConta;
        }

    }
}
