
namespace Conta_Corrente.entities
{
    static class SenhaController
    {
        private static int Id { get; set; }
        private static string Cpf { get; set; }
        private static int Senha { get; set; }

        public static int GetSenha()
        {
            return Senha;
        }

        public static void RecebeDados(int _id, string _cpf, int _senha)
        {
            Id = _id;
            Cpf = _cpf;
            Senha = _senha;
        }


    }
}
