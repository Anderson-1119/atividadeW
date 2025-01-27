using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
          int  totalChamadas = 0;
            do
            {
                Console.WriteLine("Digite a duração das chamadas em minutos (0 para sair):");
              int  duracao = Convert.ToInt32(Console.ReadLine());
                if (duracao != 0) totalchamadas + duracao;
            } while (duracao != 0);
            Console.WriteLine($"Total de minutos atendidos: (totalChamadas) minutos");
        }
    }
}
