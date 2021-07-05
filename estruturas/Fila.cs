using System;

namespace estruturasDeDados.estruturas
{
    public class Fila
    {
        Posicao primeiro;
        Posicao ultimo;

        // Lanca uma exceção caso a fila esteja vazia
        private void checaFila()
        {
            if (primeiro == null)
            {
                throw new InvalidOperationException("A fila está vazia!");
            }
        }
        public void adiciona(int valor)
        {

            if (primeiro == null)
            {
                Posicao aux = new Posicao(valor, null, null);
                primeiro = aux;
                ultimo = aux;
            }
            else
            {
                Posicao aux = new Posicao(valor, ultimo, null);
                ultimo = aux;
            }
        }
        public void remove()
        {
            checaFila();
            Posicao aux = ultimo;
            while (aux.proximo != primeiro)
            {
                aux = aux.proximo;
            }
            this.primeiro = aux;
        }
        public void percorreFila()
        {
            checaFila();
            Posicao aux = ultimo;
            Posicao aux2 = primeiro;
            while (aux != aux2)
            {
                while (aux.proximo != aux2)
                {
                    aux = aux.proximo;
                }
                Console.WriteLine(aux2.valor);
                aux2 = aux;
                aux = ultimo;
            }
            Console.WriteLine(aux.valor);
        }
    }
}