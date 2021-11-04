using Arvore.Entidades;
using System;

namespace Arvore
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinariaBusca arvore = new ArvoreBinariaBusca();
            arvore.Inserir(53);
            arvore.Inserir(95);
            arvore.Inserir(99);
            arvore.Inserir(100);
            arvore.Inserir(97);
            arvore.Inserir(20);
            arvore.Inserir(25);


            Console.WriteLine("Hello World!");
        }
    }
}
