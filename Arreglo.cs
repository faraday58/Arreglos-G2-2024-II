using System;


namespace Arreglos_G2_2024_II
{
    internal class Arreglo
    {
        public int[] arregloInt;


        public Arreglo(int N)
        {
            arregloInt = new int[N];
        }
        /// <summary>
        /// Método estático que no depende del constructor
        /// </summary>
        public static void Imprime()
        {
            //   string [] arreglo = { "a", "b", "c", "d" };
            int[] arreglo = { 20, 1, -10, 9, 5, 100, 3 };
            Console.WriteLine("Imprimiendo de manera original");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(" {0} ", arreglo[i]);

            }
            Array.Sort(arreglo);
            //Imprimiendo de manera Ordenada
            
            Console.WriteLine("\n Imprime de manea Ordenada");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(" {0} ", arreglo[i]);

            }

        }
        public void Leer()
        {
            Console.WriteLine("Ingresa los elementos del Arreglo");
            for( int i =0; i < arregloInt.Length; i++)
            {
                Console.WriteLine("Ingresa elemento Arreglo[{0}] = ", i);
                arregloInt[i] = int.Parse( Console.ReadLine());
            }
        }



    }
}
