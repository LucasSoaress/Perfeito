using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfeito
{
    class Program
    {
         public static int numeroEscolhido;
         public static int m;
         List<int> lista = new List<int>();

        static void Main(string[] args)
        {
            numeroEscolhido = int.Parse(Console.ReadLine());
            List<int> lista = new List<int>();


            for (int i = 1; numeroEscolhido > i; i++)
            {
                if (numeroEscolhido % i == 0)
                {
                    lista.Add(i);
                }
            }
          
            int n = lista.Count();

            for (int j = 0; j < n; j++)
            {
              // lista[j] = m;
                m += lista[j];
               Console.WriteLine(lista[j]);

            }
       
            Console.Write(m);
                Console.ReadKey();

        }
    }
}
