using System;

namespace Instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }
        static void Switch(string[] args)
        {   
            int nArguments = args.Length;
           switch(nArguments)
           {
                case 0:
                    Console.WriteLine("Not arguments");
                    break;
                case 1:
                    Console.WriteLine("One arguments");
                    break;
                default:
                    Console.WriteLine($"{nArguments} arguments");
                    break;
           }
        }

        static void If(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Not arguments");
            }
            else if(args.Length == 1) 
            {
                Console.WriteLine("One arguments");
            }
            else 
            {
                Console.WriteLine($"{args.Length} arguments");
            }
        } 

        static void While(string[] args)
        {
            int i = 0;
            while(i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void doWhile(string[] args) 
        {
            string text;
            do 
            {
                text = Console.ReadLine();
                Console.WriteLine(text);
            } while(text != null); // or string.IsNullOrEmpty(text);
        }

        static void forE(string[] args)
        {
            for(int i = 0; i < args.Length; i++){
                Console.WriteLine(args[i]);
            }
        }

        static void forEachH(string[] args) 
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        static void breaKK(string[] args) 
        {
            for(int i = 0; i < args.Length; i++)
            {
                if(args[i].Equals("S"))
                {
                    Console.WriteLine("achei");
                    break;
                }
            }
        }

        static void continueE(string[] args)
        {
            for(int i = 0; i < args.Length; i++){
                if(args[i].StartsWith("/")) 
                {
                    continue;
                }

                Console.WriteLine(args[i]);
            }
        }

        static void returnN(string[] args) 
        {
            int Somar(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Somar(1, 2));
            return;
        }

        static void TryCatchFinally(string[] args)
        {
            double Dividir(double x, double y)
            {
                if(y == 0)
                {
                    throw new DivideByZeroException();
                }

                return x / y;
            }
            try 
            {
                if(args.Length != 2)
                {
                    throw new InvalidOperationException("Inform two numbers");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Dividir(x, y));
            } 
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Err generic: {e.Message}");
            } 
            finally 
            {
                Console.WriteLine("Bye bye!");
            }
            
        }

        static void Using(string[] args)
        {
            int[] a = new int[10];
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("x");
                w.WriteLine("y");
            }
        }
    }
}
