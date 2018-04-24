using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioVetor
{
    class Exercicio05
    { 
        public Exercicio05()
        {
            double[] pesos = new double[5];

            Console.Write("Digite um peso: ");
            pesos[0] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um peso: ");
            pesos[1] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um peso: ");
            pesos[2] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um peso: ");
            pesos[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um peso: ");
            pesos[4] = Convert.ToDouble(Console.ReadLine());

            double soma = pesos[0] + pesos[1] + pesos[2]
                + pesos[3] + pesos[4];

            double media = soma / 5;

            Console.WriteLine("Soma dos pesos: " + pesos);
            Console.WriteLine("Média dos pesos: " + media);
        }
    }
}
