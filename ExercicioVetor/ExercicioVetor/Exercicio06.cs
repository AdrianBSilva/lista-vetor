using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioVetor
{
    class Exercicio06
    {
        public Exercicio06()
        {
            int[] idades = new int[9];
            int maioridade = 0;
            Console.Write("Digite uma idade: ");
            idades[0] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite uma idade: ");
            idades[1] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite uma idade: ");
            idades[2] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite uma idade: ");
            idades[3] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite uma idade: ");
            idades[4] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite uma idade: ");
            idades[5] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite uma idade: ");
            idades[6] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite uma idade: ");
            idades[7] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite uma idade: ");
            idades[8] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            if (idades[0] > maioridade)
            {
                maioridade = idades[0];
            }
            if (idades[1] > maioridade)
            {
                maioridade = idades[1];
            }
            if (idades[2] > maioridade)
            {
                maioridade = idades[2];
            }
            if (idades[3] > maioridade)
            {
                maioridade = idades[3];
            }
            if (idades[4] > maioridade)
            {
                maioridade = idades[4];
            }
            if (idades[5] > maioridade)
            {
                maioridade = idades[5];
            }
            if (idades[6] > maioridade)
            {
                maioridade = idades[6];
            }
            if (idades[7] > maioridade)
            {
                maioridade = idades[7];
            }
            if (idades[8] > maioridade)
            {
                maioridade = idades[8];
            }
            Console.WriteLine("Maior idade: " + maioridade);


        }
    }
}
