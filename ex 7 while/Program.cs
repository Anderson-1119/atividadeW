using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalchamadas = 0;
            int duracao;
            Console.WriteLine("Digite a duração das chamadas em minutos (0 para sair):");
            while (true)
            { 
                duracao = Convert.ToInt32(Console.ReadLine());
            if (duracao == 0) break; 
            totalchamadas += duracao;
        }
        Console.WriteLine($"Total de minutos atendidos: {totalchamadas} minutos"); 

        }
    }
}
