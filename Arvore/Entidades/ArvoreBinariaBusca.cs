using Arvore.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Arvore.Entidades
{
    public class ArvoreBinariaBusca : IArvore<int>
    {
        public No NoRaiz { get; private set; }

        public ArvoreBinariaBusca()
        {
            //Profundidade = 0;
            NoRaiz = null;
        }

        public bool Inserir(int valor)
        {
            No novoNovo = new No(valor);

            if (NoRaiz == null)
            {
                NoRaiz = novoNovo;
                NoRaiz.AtribuirProfundidade(1);
                return true;
            }

            No auxilarBusca = NoRaiz;

            while (auxilarBusca != null)
            {
                if (auxilarBusca.Valor < valor)
                { //vai para direita
                    if (auxilarBusca.NoDireita == null)
                    {
                        novoNovo.AtribuirProfundidade(auxilarBusca.Profundidade + 1);
                        auxilarBusca.AtribuirNoDireita(novoNovo );                       
                        return true;
                    }
                    else
                    {
                        auxilarBusca = auxilarBusca.NoDireita;
                    }
                }
                else
                {//vai para esquerda
                    if (auxilarBusca.NoEsquerda == null)
                    {
                        novoNovo.AtribuirProfundidade(auxilarBusca.Profundidade + 1);
                        auxilarBusca.AtribuirNoEsquerda(novoNovo);                   
                        return true;
                    }
                    else
                    {
                        auxilarBusca = auxilarBusca.NoEsquerda;
                    }
                }

            }
            return false;

        }     

        public int Buscar(int valor)
        {
            throw new NotImplementedException();
        }


        public void Remover(int valor)
        {
            throw new NotImplementedException();
        }
    }
}
