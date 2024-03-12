using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome;

            Console.WriteLine("Digite o nome do(a) aluno(a):");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a média do(a) " + nome + ":");
            double media = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a frequencia do(a) " + nome + " em %:");
            double frequencia = double.Parse(Console.ReadLine());

            if (media >= 7 && frequencia >= 75)
            {
                Console.WriteLine("O(a) " + nome + " está aprovado(a)");
            }
            else if (media < 7 && media >= 4 && frequencia >= 75)
            {
                Console.WriteLine("O(a) " + nome + " está de recuperação");
            }
            else if (media >= 7 && frequencia < 75)
            {
                Console.WriteLine("O(a) " + nome + " está de recuperação");
            }
            else if (media < 7 && media >= 4 && frequencia > 75)
            {
                Console.WriteLine("O(a) " + nome + " está reprovado(a)");
            }
            if (media < 4)
            {
                Console.WriteLine("O(a) " + nome + " está reprovado(a)");
            }

            Console.ReadKey();
        }
    }
}
