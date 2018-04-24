using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioVetor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            string[] produtos = new string[7];
            int[] precos = new int[7]; 

            Console.Write("Digite o nome do produto: ");
            produtos[0] = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Preço do produto: ");
            precos[0] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o nome do produto: ");
            produtos[1] = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Preço do produto: ");
            precos[1] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o nome do produto: ");
            produtos[2] = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Preço do produto: ");
            precos[2] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o nome do produto: ");
            produtos[3] = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Preço do produto: ");
            precos[3] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o nome do produto: ");
            produtos[4] = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Preço do produto: ");
            precos[4] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o nome do produto: ");
            produtos[5] = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Preço do produto: ");
            precos[5] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite o nome do produto: ");
            produtos[6] = (Console.ReadLine());
            Console.WriteLine();
            Console.Write("Preço do produto: ");
            precos[6] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Produto: " + produtos[0] + "    Preço: " + precos[0] + "\n" );

            Console.WriteLine("Produto: " + produtos[1] + "    Preço: " + precos[1] + "\n");

            Console.WriteLine("Produto: " + produtos[2] + "    Preço: " + precos[2] + "\n");

            Console.WriteLine("Produto: " + produtos[3] + "    Preço: " + precos[3] + "\n");

            Console.WriteLine("Produto: " + produtos[4] + "    Preço: " + precos[4] + "\n");

            Console.WriteLine("Produto: " + produtos[5] + "    Preço: " + precos[5] + "\n");

            Console.WriteLine("Produto: " + produtos[6] + "    Preço: " + precos[6] + "\n");

            
        }
    }
}
