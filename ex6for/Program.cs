using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int votosA = 0;
            int votosB = 0;
            int voto;
            for (; ; )
            {
                Console.WriteLine("Digite os votos (1 para candidato A, 2 para candidato B, 0 para saiг):");
                voto = Convert.ToInt32(Console.ReadLine());
                if (voto == 0) break;
                if (voto == 1) votosA++;
                else if (voto == 2) votosB++;
            }
            Console.WriteLine($"Candidato A: {votosA} votos, Candidato B: {votosB} votos");
        }
    }
}
