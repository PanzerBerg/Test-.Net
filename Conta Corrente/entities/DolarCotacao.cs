

using System;

namespace Conta_Corrente.entities
{
    public static class DolarCotacao
    {
        private static string Preco { get; set; }
        private static float PrecoConv { get; set; }

        public static void SetPreco(string _preco)
        {
            Preco = _preco;
        }

        public static float GetPreco()
        {
            return PrecoConv;
        }

        public static void Arredondar()
        {
            float preco = float.Parse(Preco);
            float rounded = (float)(Math.Round((double)preco, 2));
            PrecoConv = rounded;
        }

        public static string PrecoString()
        {
            return "R$ " + PrecoConv.ToString("0.00");
        }
    }
}
