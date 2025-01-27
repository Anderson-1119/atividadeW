using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dias_trabalhados_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int  diasTrabalhados = 0;
            int dia;

            for (; ; )
            {
                Console.WriteLine("Digite os dias trabalhados (0 para sair):");
                dia = Convert.ToInt32(Console.ReadLine());
                if (dia == 0) break;
                diasTrabalhados++;
            }
            Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}");
        }
    }
}
