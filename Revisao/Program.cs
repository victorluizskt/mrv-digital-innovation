using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            init();
        }

        private static void init()
        {
            Aluno[] alunos = new Aluno[5];
            int indice = 0;
            string value = OptionUser();
            while(value.ToUpper() != "X")
            {
                switch(value)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Name = Console.ReadLine();
                        Console.WriteLine("Informe a nota do aluno: "); 
                        
                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Note = nota;
                        }
                        else 
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }
                        alunos[indice] = aluno;
                        indice++;
                        Console.WriteLine("Aluno inserido com sucesso.");
                        break;
                    case "2":
                        // TODO: Listar alunos
                        foreach(var a in alunos){
                            if(!string.IsNullOrEmpty(a.Name))
                            {
                                Console.WriteLine($"Aluno: {a.Name} - Nota {a.Note}");
                            }
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var nrAlunos = 0;
                        for(int i = 0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Name))
                            {
                                notaTotal += alunos[i].Note;
                                nrAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal/nrAlunos;
                        Conceito conceitoGeral;
                        if(mediaGeral < 6)
                        {
                            conceitoGeral = Conceito.E;
                            Console.WriteLine($"Media - {mediaGeral}  Conceito - {conceitoGeral}");
                        } 
                        else if(mediaGeral >= 6 && mediaGeral < 7)
                        {
                            conceitoGeral = Conceito.D;
                            Console.WriteLine($"Media - {mediaGeral}  Conceito - {conceitoGeral}");
                        }
                        else if(mediaGeral >= 7 && mediaGeral < 8)
                        {
                            conceitoGeral = Conceito.C;
                            Console.WriteLine($"Media - {mediaGeral}  Conceito - {conceitoGeral}");
                        }
                        else if(mediaGeral >= 8 && mediaGeral < 9)
                        {
                            conceitoGeral = Conceito.B;
                            Console.WriteLine($"Media - {mediaGeral}  Conceito - {conceitoGeral}");
                        }
                        else if(mediaGeral >= 9)
                        {
                            conceitoGeral = Conceito.A;
                            Console.WriteLine($"Media - {mediaGeral}  Conceito - {conceitoGeral}");
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                value = OptionUser();
            }
        }

        private static string OptionUser()
        {
            Console.WriteLine("");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine("");
            String optionUser = Console.ReadLine();

            return optionUser;
        }
    }
}
