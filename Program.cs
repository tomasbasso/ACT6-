using System;

namespace ACT6_
{
    class Program
    {
         static void Main(string[] args)
        {
            int[] arreglonumeros = { 10, 20, 30, 4, 9, 8, 4, 6, 10, 20 };
            int valor;

            Console.WriteLine("Ingrese un numero: ");
            valor = Convert.ToInt32(Console.ReadLine());

            BuscarEnArreglo(arreglonumeros, valor);

        }
         static void BuscarEnArreglo(int[] arreglonumeros, int valor)
        {
            bool encontrado = false;
            for (int i = 0; i < arreglonumeros.Length; i++)
            {
                if (arreglonumeros[i] == valor)
                {
                    encontrado = true;
                }
            }
            if (encontrado == true)
            {
                Console.WriteLine("El valor fue hallado");
            }
            else
            {
                Console.WriteLine("El valor no fue hallado");
            }
        }
    }
}

