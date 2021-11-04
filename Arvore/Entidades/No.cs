using System;
using System.Collections.Generic;
using System.Text;

namespace Arvore.Entidades
{
    public class No
    {
        public No NoEsquerda { get; private set; }
        public No NoDireita { get; private set; }
        public int Valor { get; private set; }
        public int Profundidade { get; private set; }
        public No(int valor)
        {
            Valor = valor;
            Profundidade = -1;
        }

        public void AtribuirNoDireita(No no )
        {
            NoDireita = no;
            
        }

        public void AtribuirNoEsquerda(No no)
        {
            NoEsquerda = no;          
        }

        public void AtribuirProfundidade(int profundidade)
        {
            Profundidade = profundidade;
        }

    }
}
