using System;

namespace AloGitHub
{
    class Program
    {
        static void EscreveNaTela()
        {
            Console.WriteLine("Primeiro Teste com o GitHub");
        }

        static void EscreveNaTela2(String txt)
        {
            EscreveNaTela(txt);
        }

        static void EscreveNaTela3(String txt)
        {
            EscreveNaTela2(txt);
        }

        static void Main(string[] args)
        {
            EscreveNaTela();
            Console.ReadKey();
        }
    }
}
