using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double alunosAprovados = 0;
            double nota = 0;
            for (; ; )
            {
                Console.WriteLine("Digite as notas dos alunos (digite -1 para sair):");
                nota = Convert.ToDouble(Console.ReadLine());
                if (nota == -1) break;
                if (nota >= 6) alunosAprovados++;
            }
            Console.WriteLine($"Total de alunos aprovados: {alunosAprovados}");
        }
    }
}
