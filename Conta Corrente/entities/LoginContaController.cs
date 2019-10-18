using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Corrente.entities
{
    class LoginContaController
    {
        private int conta;
        private int agencia;
        private int digito;
        private String nome;

        public int Conta { get => conta; set => conta = value; }
        public int Agencia { get => agencia; set => agencia = value; }
        public int Digito { get => digito; set => digito = value; }
        public string Nome { get => nome; set => nome = value; }


    }
}
