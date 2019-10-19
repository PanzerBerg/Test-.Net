using Conta_Corrente.entities.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Conta_Corrente.entities
{
    static class ContaController
    {
        private static int Id { get; set; }
        private static int Conta { get; set; }
        private static int Agencia { get; set; }
        private static int Digito { get; set; }
        private static string Nome { get; set; }
        private static string Cpf { get; set; }
        private static float Saldo { get; set; }

        public static void RecebeDados(int _id, string _nome, string _cpf, float _saldo)
        {
            Id = _id;
            Nome = _nome;
            Cpf = _cpf;
            Saldo = _saldo;
        }

        public static void PassaDados(int _conta, int _agencia, int _digito)
        {
            Conta = _conta;
            Agencia = _agencia;
            Digito = _digito;
        }

        public static string ContaString()
        {
            return Conta + " " + Agencia + " - " + Digito;
        }

        public static string NomeString()
        {
            return Nome;
        }

        public static string CpfString()
        {
            return Cpf;
        }

        public static string SaldoString()
        {
            string saldo = "R$ " + Saldo.ToString("0.00");
            Console.WriteLine(saldo);
            return saldo;
        }
    }
}
