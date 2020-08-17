using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace terreno
{
    class juego
    {
        static void Main(string[] args)
        {
            terreno ma = new terreno();
            ma.Cargar();
            ma.Imprimir();
            granja ma1 = new granja();
            ma1.Cargar();
            ma1.Imprimir();
            rio ma2 = new rio();
            ma2.Cargar();
            ma2.Imprimir();
            rio1 ma3 = new rio1();
            ma3.Cargar();
            ma3.Imprimir();
            Lago ma4 = new Lago();
            ma4.Cargar();
            ma4.Imprimir();
            Console.ReadKey();
        }
    }
    class terreno
    {

        public int[,] mat;

        public void Cargar()
        {
            Console.Write("matrix de 100x100 para el terreno. \t");
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

    }
    class granja
    {
        public int[,] mat;

        public void Cargar()
        {
            //Console.Write("matrix de 30x20 para la granja");
            //string linea;
            //linea = Console.ReadLine();
            mat = new int[30, 20];
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

    }
    class rio
    {
        public int[,] mat;

        public void Cargar()
        {
            //Console.Write("matrix de 5x100 para el rio");
            //string linea;
            //linea = Console.ReadLine();
            mat = new int[5, 100];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Random rnd = new Random();
                    int lina = rnd.Next(8, 8);
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

    }
    class rio1
    {
        public int[,] mat;

        public void Cargar()
        {
            //Console.Write("matrix de 100x5 para el rio");
            //string linea;
            //linea = Console.ReadLine();
            mat = new int[100, 5];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Random rnd = new Random();
                    int lina = rnd.Next(8, 8);

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

    }
    class Lago
    {
        public int[,] mat;

        public void Cargar()
        {
            //Console.Write("matrix de 15x15 para el lago");
            //string linea;
            //linea = Console.ReadLine();
            mat = new int[14, 14];
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Random rnd = new Random();
                    int lina = rnd.Next(5, 5);
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

    }
}