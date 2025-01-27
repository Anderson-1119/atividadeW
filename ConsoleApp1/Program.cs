using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diasTrabalhados = 0;
            int dia;
            Console.WriteLine("Digite os dias trabalhados (0 para sair):");
            while (true)
            {
                dia = Convert.ToInt32(Console.ReadLine());
                if (dia == 0) break;

                diasTrabalhados++;
            }
        Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados})");
        }
    }
}
