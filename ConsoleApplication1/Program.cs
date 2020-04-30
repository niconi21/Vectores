using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame una longitud");
            int n = int.Parse(Console.ReadLine());
            int[] vector = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Numero:");
                vector[i] = int.Parse(Console.ReadLine());
            }
            int[] lista = mostrarNumeros(vector);
            Console.WriteLine("\nLista");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i].ToString());
            }
            Console.ReadKey();


        }

        //Leer un arreglo de enteros
        //desplegar los numeros que se encuentren en la picision donde esté el mayor numero

        //public static int[] mostrarNumeros(int[] numeros)
        //{
        //    int aux = 0; //la pocision del mayor
        //    int mayor = 0; //cual es el mayor
        //    for (int i = 0; i < numeros.Length; i++)
        //    {
        //        if (numeros[i] > mayor)
        //        {
        //            mayor = numeros[i];
        //            aux = i;
        //        }
        //    }
        //    int[] lista = new int[numeros.Length - aux];
        //    int j = 0;
        //    for (int i = aux; i < numeros.Length; i++)
        //    {
        //        lista[j] = numeros[i];
        //        j++;
        //    }
        //    return lista;
        //}

        public static int[] mostrarNumeros(int[] numeros)
        {
            int aux = 0; //la pocision del mayor
            int mayor = 0; //cual es el mayor
            for (int i = 0; i < numeros.Length; i++)
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                    aux = i;
                }
            
            int[] lista = new int[numeros.Length - aux];
            int j = 0;
            
            for (int i = aux; i < numeros.Length; i++)
            {
                lista[j] = numeros[i];
                j++;
            }

            

            return lista;
        }
    }
}
