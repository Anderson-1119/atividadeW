using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ex4_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int somaidades = 0;
           int contador = 0;
            int idade;
            for (; ; )
            {
                Console.WriteLine("Digite as idades (0 para sair):");
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade==0) break;
            somaidades += idade;
            contador++;
        }
        double mediaIdade = contador > 0 ? somaidades / contador: 0;
Console.WriteLine($"Média das idades: {mediaIdade}");
        }
    }
}
