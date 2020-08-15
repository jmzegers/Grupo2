using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace granja
{
    class granja
    {
        public int[,] mat;

        public void Cargar()
        {
            Console.Write("matrix de 30x20 para la granja");
            string linea;
            linea = Console.ReadLine();
            mat = new int[30,20];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Random rnd = new Random();
                    int lina = rnd.Next(4, 4);
                    mat[f, c] = lina;
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
            granja ma = new granja();
            ma.Cargar();
            ma.Imprimir();
            Console.ReadKey();
        }
    }
}