using Conta_Corrente.entities.Db;

namespace Conta_Corrente.entities
{
    static class TransferController
    {
        private static int Id { get; set; }
        private static int Conta { get; set; }
        private static int Agencia { get; set; }
        private static int Digito { get; set; }
        private static string Nome { get; set; }
        private static string Cpf { get; set; }
        private static float Saldo { get; set; }
        private static float Saldo_Dolar { get; set; }

        public static string GetNome()
        {
            return Nome;
        }

        public static void RecebeDados (int _id, int _conta, int _agencia, int _digito, string _nome, string _cpf, float _saldo, float _dolar)
        {
            Id = _id;
            Conta = _conta;
            Agencia = _agencia;
            Digito = _digito;
            Nome = _nome;
            Cpf = _cpf;
            Saldo = _saldo;
            Saldo_Dolar = _dolar;
        }

        public static float TransferFirst(float valor)
        {
            float saldoAtualizado = ContaController.GetSaldo() - valor;
            ContaController.SaldoAtualizado(saldoAtualizado);
            TransferSecond(valor);
            return saldoAtualizado;
        }

        public static float TransferSecond(float valor)
        {
            float saldoAtualizado = Saldo + valor;
            Saldo = saldoAtualizado;
            return saldoAtualizado;
        }

        public static float TransferFirstDol(float valor)
        {
            float saldoAtualizado = ContaController.GetDolar() - valor;
            ContaController.SaldoDolAtualizado(saldoAtualizado);
            TransferSecondDol(valor);
            return saldoAtualizado;
        }

        public static float TransferSecondDol(float valor)
        {
            float saldoAtualizado = Saldo_Dolar + valor;
            Saldo_Dolar = saldoAtualizado;
            return saldoAtualizado;
        }

        public static void AtualizarDb(DbController dbController)
        {
            dbController.Atualizar(Id, Nome, Cpf, Conta, Agencia, Digito, Saldo, Saldo_Dolar);
        }

        public static string ContaString()
        {
            return Conta + " " + Agencia + " - " + Digito;
        }
    }
}
