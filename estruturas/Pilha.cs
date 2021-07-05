using System;

namespace estruturasDeDados.estruturas
{
    public class Pilha
    {
        Posicao topo;

        // Lanca uma exceção caso a pilha esteja vazia
        private void checaPilha()
        {
            if (topo == null)
            {
                throw new InvalidOperationException("A pilha está vazia!");
            }
        }
        public void adiciona(int valor)
        {
            topo = new Posicao(valor, topo, null);
        }

        public void remove()
        {
            checaPilha();
            topo = topo.proximo;
        }
        public void percorrePilha()
        {
            checaPilha();
            Posicao aux = topo;
            while (aux.proximo != null)
            {
                Console.WriteLine(aux.valor);
                aux = aux.proximo;
            }
            Console.WriteLine(aux.valor);
        }
    }
}