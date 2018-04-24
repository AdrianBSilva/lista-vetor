using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioVetor
{
    class Exercicio04
    {
        public Exercicio04()
        {
            double[] notas = new double[4];

            Console.Write("Qual a matéria: ");
            string materia = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");
            notas[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            notas[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a terceira nota: ");
            notas[2] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quarta nota: ");
            notas[3] = Convert.ToDouble(Console.ReadLine());

            double media = (notas[0] + notas[1] + notas[2] + notas[3]) / 4;

            Console.WriteLine("Média: "+ media);
        }
    }
}
