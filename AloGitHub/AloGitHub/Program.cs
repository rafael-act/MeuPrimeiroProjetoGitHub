using System;

namespace AloGitHub
{
    class Program
    {
        static void EscreveNaTela(String txt)
        {
            Console.WriteLine(txt);
        }

        static void EscreveNaTela2(String txt)
        {
            EscreveNaTela(txt);
        }

        static void EscreveNaTela3(String txt)
        {
            EscreveNaTela2(txt);
        }

        static void EscreveNaTela4(String txt)
        {
            EscreveNaTela3(txt);
        }

        static void Main(string[] args)
        {
            EscreveNaTela("Primeiro Teste com o GitHub");
            Console.ReadKey();
        }
    }
}
