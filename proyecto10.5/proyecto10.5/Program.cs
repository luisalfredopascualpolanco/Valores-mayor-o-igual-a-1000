using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Cantidad de valores que vamos a analizar: ");
                int cantidad = int.Parse(Console.ReadLine());
                int mayorOigual100 = 0;
                int numero;

                for (int i = 0; i < cantidad; i++)
                {
                    Console.Write("Escribe el numero: ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero >= 1000)
                    {
                        mayorOigual100 = mayorOigual100 + 1;
                    }
                }
                Console.WriteLine("Hay "+mayorOigual100+" numeros mayor o igual a 1000.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un dato invalido.");                
            }
            Console.ReadKey();
        }
    }
}
