using System;

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace Ex6
{
        class Program
    {
        static void Main()
        {
            Filme meuFilme = new Filme();
            meuFilme.NomeFilme = "Todo Mundo em Panico 2";
            meuFilme.Categoria = "Comédia";

            Console.WriteLine(meuFilme.RetornarNomeCategoria());
            Console.ReadLine();
        }
    }

}
