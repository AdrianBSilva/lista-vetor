using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioVetor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            int[] numeros = new int[16];

            Console.Write("Digite um número: ");
            numeros[0] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[1] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[2] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[3] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[4] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[5] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[6] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[7] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[8] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[9] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[10] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[11] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[12] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[13] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[14] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.Write("Digite um número: ");
            numeros[15] = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            int soma = numeros[0] + numeros[1] + numeros[2]
                + numeros[3] + numeros[4] + numeros[5] + numeros[6]
                + numeros[10] + numeros[9] + numeros[8] + numeros[7]
                + numeros[11] + numeros[12] + numeros[13] + numeros[14]
                + numeros[15];

            Console.WriteLine("A soma dos números: " + soma );
        }
    }
}
