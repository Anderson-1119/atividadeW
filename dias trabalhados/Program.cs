using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dias_trabalhados
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int diasTrabalhados = 0;
            int dia;
            do
            {
                Console.WriteLine("Digite os dias trabalhados (0 para sair):");
                dia = Convert.ToInt32(Console.ReadLine());
                if (dia != 0) diasTrabalhados++;
            } while (dia != 0);
            Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados})");
        }
    }
}
