using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double somaidades = 0;
            int contador = 0;
int idade;
            Console.WriteLine("Digite as idades (0 para sair):");
            while (true)
            { idade = Convert.ToInt32(Console.ReadLine());
                if (idade == 0) break;
                somaidades += idade;
                contador++;
            } 
 double mediaidade = contador > 0 ? somaidades / contador: 0;
                Console.WriteLine($"média das idades: {mediaidade}");
        }
    }
}
