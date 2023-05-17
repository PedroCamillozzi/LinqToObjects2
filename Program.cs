using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;

namespace LinqToObjects2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            string num;

            Console.WriteLine("Ingrese una lista de numeros separados por ,");
            num = Console.ReadLine();

            string[] strnum = num.Split(',');
            foreach (string strn in strnum)
            {
                if (int.TryParse(strn, out int nume))
                {
                    numeros.Add(nume);
                }
            }
          

            var numerosMayoresA20 = numeros.Where(n => n > 20).Select(n => n);

            if (numerosMayoresA20.Count() != 0)
            {
                Console.WriteLine("Los numeros mayores a 20 son: ");
                foreach (int n in numerosMayoresA20)
                {
                    Console.WriteLine(n);
                }
            }
            else
            {
                Console.WriteLine("No hay nomeros mayores a 20");
            }
           
        }
    }
}
