/* 
 * Escreva um programa para ler 5 pares de valores positivos. Para cada par lido deve ser impresso o valor do maior 
 * elemento do par ou a frase "Eles são iguais" se os valores do par forem iguais. Para obter o maior elemento do 
 * par utilize o método MaiorNumero.
 * 
 * Nome: MaiorNumero 
 * Descrição: Retorna o maior elemento entre 2 valores positivos. Se eles forem iguais deve ser retornado o valor -1. 
 * Entrada: (int) Dois valores positivos. 
 * Saída: (int) O maior deles ou -1 se eles forem iguais. 
 * Observação: Teste se os valores de entrada são positivos.
 */

using System;

namespace Exercicio3
{
    class Program
    {
        // Compara os valores de 'a' e 'b' e retorna o maior deles (ou -1 caso sejam iguais)
        static int MaiorNumero(ref int a, ref int b)
        {
            int resultado;

            // Comparando valores
            if (a > b)
            {
                resultado = a;
            }
            else if (a == b)
            {
                resultado = -1;
            }
            else
            {
                resultado = b;
            }

            return resultado;
        }

        static void Main(string[] args)
        {
            // Declaração de variáveis
            int a, b, resultado;

            // Laço para efetuar a comparação de um par de inteiros 5 vezes
            for (int i = 1; i <= 5; i++)
            {
                // Recebe o valor e testa se é um inteiro positivo
                do
                {
                    Console.Clear(); // Limpa tela
                    Console.WriteLine(); // Pula linha
                    Console.Write("Entre com o valor do 1º termo a ser comparado: ");
                    a = int.Parse(Console.ReadLine());

                    if(a < 0)
                    {
                        Console.WriteLine(); // Pula linha
                        Console.WriteLine("O valor inserido não é válido, apenas números inteiros e positivos são aceitos.");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                } while (a < 0);

                // Recebe o valor e testa se é um inteiro positivo
                do
                {
                    Console.Clear(); // Limpa tela
                    Console.WriteLine(); // Pula linha
                    Console.Write("Entre com o valor do 2º termo a ser comparado: ");
                    b = int.Parse(Console.ReadLine());

                    if (b < 0)
                    {
                        Console.WriteLine(); // Pula linha
                        Console.WriteLine("O valor inserido não é válido, apenas números inteiros e positivos são aceitos.");
                        Console.WriteLine("Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                    }
                } while (b < 0);

                // Chamando o método para comparar dois valores e retornar o maior entre eles
                resultado = MaiorNumero(ref a, ref b);

                // Mostra o resultado, e informa ao usuário caso os números sejam iguais
                if (resultado != -1)
                {
                    Console.Clear(); // Limpa tela
                    Console.WriteLine(); // Pula linha
                    Console.WriteLine("O maior valor entre {0} e {1} é: {2}", a, b, resultado);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear(); // Limpa tela
                    Console.WriteLine(); // Pula linha
                    Console.WriteLine("Os números {0} e {1} são iguais.", a, b);
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }

        }
    }
}
