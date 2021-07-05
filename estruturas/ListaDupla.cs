using System;

namespace estruturasDeDados.estruturas
{
    public class ListaDupla
    {
        Posicao cabeça;
        int tamanho = 0;

        private void checaLista(int posicao)
        {
            if (this.tamanho < posicao)
            {
                throw new InvalidOperationException("Posicao não disponivel para inserção");
            }
        }
        // percorre a lista até o elemento anterior a posição
        private Posicao percorreLista(int posicao)
        {
            Posicao aux = cabeça;
            for (int i = 0; i < posicao - 1; ++i)
            {
                aux = aux.proximo;
            }
            return aux;
        }

        public void adiciona(int valor, int posicao)
        {
            checaLista(posicao);
            Posicao no = new Posicao(valor, null, null);
            if (posicao == 0)
            {
                if (cabeça != null)
                {
                    cabeça.anterior = no;
                }
                no.proximo = cabeça;
                cabeça = no;
            }
            else
            {
                Posicao aux = percorreLista(posicao);
                no.proximo = aux.proximo;
                no.anterior = aux;
                aux.proximo = no;
                if (posicao < tamanho)
                {
                    no.proximo.anterior = no;
                }
            }
            ++tamanho;
        }
        public void removePos(int posicao)
        {
            checaLista(posicao);
            if (posicao == 0)
            {
                cabeça = cabeça.proximo;
                cabeça.anterior = null;
            }
            else
            {
                Posicao aux = percorreLista(posicao);
                aux.proximo = aux.proximo.proximo;
                aux.proximo.anterior = aux;
            }
            --tamanho;
        }
        public void percorreLista()
        {
            Posicao aux = cabeça;
            for (int i = 0; i < tamanho; ++i)
            {
                Console.WriteLine(aux.valor);
                aux = aux.proximo;
            }
        }
    }
}