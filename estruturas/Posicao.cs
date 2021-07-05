namespace estruturasDeDados.estruturas
{
    public class Posicao
    {
        public Posicao proximo;
        public Posicao anterior;
        public int valor;

        public Posicao(int valor, Posicao proximo, Posicao anterior)
        {
            this.valor = valor;
            this.proximo = proximo;
            this.anterior = anterior;
        }



    }
}