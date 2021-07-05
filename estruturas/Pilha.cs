using System;

namespace estruturasDeDados.estruturas
{
    public class Pilha
    {
        Posicao topo;

        public void empilha(int valor)
        {
            topo = new Posicao(valor, topo);
        }

        public void desempilha()
        {
            if (topo == null)
            {
                throw new InvalidOperationException("A pilha está vazia!");
            }
            topo = topo.proximo;
        }
        public void percorrePilha()
        {
            if (topo != null)
            {
                Posicao aux = topo;
                while (aux.proximo != null)
                {
                    Console.WriteLine(aux.valor);
                    aux = aux.proximo;
                }
                Console.WriteLine(aux.valor);
            }
            else
            {
                Console.WriteLine("lista vazia");
            }

        }
    }
}