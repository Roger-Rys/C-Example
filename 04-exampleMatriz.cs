using System;

namespace myfirstapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            int F = 0; int C = 0; int N = 0;
            int SumP = 0;
            int SumS = 0;
        
            Console.WriteLine("Ingresar tamaño de matriz");
            line = Console.ReadLine();
            N = int.Parse(line);

            Console.WriteLine();

            Random rnd = new Random();
            

            int[,] mat = new int [N+1, N+1];
            for(F=1; F<=N; F++){
                for(C=1; C<=N; C++){
                    mat[F,C] = rnd.Next(0,9);
                    Console.SetCursorPosition(C*4,F+1);
                    Console.Write(mat[F,C]);
                }
                Console.WriteLine();
            }
            
            //Suma primara de matrz
            for(F=1; F<=N; F++){
                SumP = SumP + mat[F,F];
            }
            Console.WriteLine($"\n Suma Primaria es {SumP}");

            //Suma secundaria de matrz
            C = N;
            for(F=1; F<=N; F++){
                SumS = SumS + mat[F,C];
                C = C-1;
                              
            }
            Console.WriteLine($"\n Suma Secundaria es {SumS}");
            Console.ReadLine();
        }
    }
}