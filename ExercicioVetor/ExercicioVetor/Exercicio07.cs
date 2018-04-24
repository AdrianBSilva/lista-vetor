using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioVetor
{
    class Exercicio07
    {
        public Exercicio07()
        {
            double[] alturas = new double[4];
            double menorAltura = int.MaxValue;
            Console.Write("Digite a altura do primeiro animal: ");
            alturas[0] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Digitea altura do segundo animal: ");
            alturas[1] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Digitea altura do terceiro animal: ");
            alturas[2] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.Write("Digitea altura do quarto animal: ");
            alturas[3] = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            if (alturas[0] < menorAltura)
            {
                menorAltura = alturas[0];
            }
            if (alturas[1] < menorAltura)
            {
                menorAltura = alturas[1];
            }
            if (alturas[2] < menorAltura)
            {
                menorAltura = alturas[2];
            }
            if (alturas[3] < menorAltura)
            {
                menorAltura = alturas[3];
            }

            Console.WriteLine("O animal com menor altura tem: " + menorAltura );
        }
    }
}
