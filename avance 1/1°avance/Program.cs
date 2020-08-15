using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terreno
{
    class terreno
    {
        public int[,] mat;

        public void Cargar()
        {
            Console.Write("matrix de 100x100 para el terreno. \t");
            string linea;
            string pregunta1 = "¿desea agregar un rio (si(0), no(1))?";
            string pregunta2 = "¿desea agregar un lago (si(0), no(1))?";
            Console.WriteLine(pregunta1);
            int number1 = Int32.Parse(Console.ReadLine()); 
            Console.WriteLine(pregunta2);
            int number2 = Int32.Parse(Console.ReadLine());
            mat = new int[100, 100];
            if (number1 == 1 & number2 == 1)
            if (number1 == 0 & number2 == 1)
            if (number1 == 1 & number2 == 0)
            if (number1 == 0 & number2 == 0)
            {
                for (int f = 0; f < mat.GetLength(0); f++)
                {
                    for (int c = 0; c < mat.GetLength(1); c++)
                    {
                        Random rnd = new Random();
                        int lina = rnd.Next(0);
                        mat[f, c] = lina;
                    }
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + "");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            terreno ma = new terreno();
            ma.Cargar();
            ma.Imprimir();
            Console.ReadKey();
        }
    }
}
