//obs: Utilizando estrutura Para:
//Problema "dentro_fora" (adaptado de URI 1072)
//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
//Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo.

using System.ComponentModel;

namespace IntervaloDentroEFora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, x, contDentro, contFora;

            contDentro = 0;
            contFora = 0;

            Console.Write("Quantos numeros serão digitados? ");
            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    contDentro++;
                }
                else
                {
                    contFora++;
                }
            }

            Console.WriteLine($"{contDentro} DENTRO");
            Console.WriteLine($"{contFora} FORA ");
        }
    }
}
