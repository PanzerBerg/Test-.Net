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
        private static float Saldo_Dolar { get; set; }

        public static void RecebeDados(int _id, string _nome, string _cpf, float _saldo, float _dolar)
        {
            Id = _id;
            Nome = _nome;
            Cpf = _cpf;
            Saldo = _saldo;
            Saldo_Dolar = _dolar;
        }

        public static void PassaDados(int _conta, int _agencia, int _digito)
        {
            Conta = _conta;
            Agencia = _agencia;
            Digito = _digito;
        }

        public static void SaldoAtualizado(float _saldo)
        {
            Saldo = _saldo;
        }

        public static void AtualizarDb(DbController dbController)
        {
            dbController.Atualizar(Id, Nome, Cpf, Conta, Agencia, Digito, Saldo, Saldo_Dolar);
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

        public static float GetSaldo()
        {
            return Saldo;
        }
        
        public static float GetDolar()
        {
            return Saldo_Dolar;
        }

        public static int GetConta()
        {
            return Conta;
        }

        public static int GetAgencia()
        {
            return Agencia;
        }

        public static int GetDigito()
        {
            return Digito;
        }

        public static string SaldoString()
        {
            string saldo = "R$ " + Saldo.ToString("0.00");
            return saldo;
        }

        public static string DolarSaldoString()
        {
            string saldo = "$ " + Saldo_Dolar.ToString("0.00");
            return saldo;
        }
    }
}
