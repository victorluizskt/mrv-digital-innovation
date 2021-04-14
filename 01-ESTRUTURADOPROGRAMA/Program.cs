using System; // Qual pacote eu estou utilizando - System é um próprio pacote do dotnet.
using DigitalInnovationOne.Exemplos; // Utilizando o pacote

namespace DigitalInnovationOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var pilha = new Pilha();
            pilha.Empilha(1);
            pilha.Empilha(10);
            pilha.Empilha(100);
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
            Console.WriteLine(pilha.Desempilha());
        }
        public static void soma (int i, int c) {
            Console.WriteLine(i + c);
            for(int j = 0; j < c; j++){
                Console.WriteLine($"Welcome to course of .NET {j}");
            }
        }
    }
}
