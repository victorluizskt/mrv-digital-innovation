using System;

namespace DigitalInnovationOne.Exemplos // Novo namespace para meu programa -> como se fosse o pacote
{
    public class Pilha
    {
        Posicao primeiro;
        public void Empilha<T>(T item)
        {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha()
        {
            if(primeiro == null)
            {
                throw new InvalidOperationException("você bugou tudo cara F");
            }

            object result = primeiro.item;
            primeiro = primeiro.proximo;
            return result;
        }

        class Posicao  // Classe aninhada!
        {
            public Posicao proximo;
            public object item;
            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
   
}