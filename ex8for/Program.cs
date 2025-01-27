using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8for
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int totalChamadas = 0;
            for (; ; )
            { 
                Console.WriteLine("Digite a duração das chamadas em minutos (0 para sair):");
            int duracao = Convert.ToInt32(Console.ReadLine());
            if (duracao == 0) break;
            totalChamadas += duracao;
        }
            Console.WriteLine($"total de minutos atendidos: {totalChamadas} minutos");
        }
    }
}
