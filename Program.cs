﻿/*
 * Faça um método que leia 10 números inteiros e positivos, calcule e retorne a média aritmética dos mesmos.
 */

using System;

namespace Exercicio2
{
    class Program
    {
        // Metódo para calcular a media, onde: 
        // n = soma de todos os termos
        // q = numero de termos
        static double Media ()
        {
            double resultado = 0, valor;

            // Laço para ler 10 números e acumular seus valores em 'resultado'
            for (int i = 1; i <= 10; i++)
            {
                // Recebendo o valor do usuário
                Console.Clear(); // Limpa tela
                Console.WriteLine(); // Pula linha
                Console.Write("Entre com o valor do {0}º termo: ", i);
                valor = int.Parse(Console.ReadLine());

                // Testa se o número inserido é positivo
                if (valor >= 0)
                {
                    // Acumulando valor
                    resultado = resultado + valor;
                }
                else
                {
                    // Tratando erro de inserção de valor
                    i--;
                    Console.WriteLine(); // Pula linha
                    Console.WriteLine("O valor inserido não é válido, apenas números inteiros e positivos são aceitos.");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
            }

            // Calculando a média
            resultado = resultado / 10;

            return resultado;
        }

        static void Main(string[] args)
        {
            // Declaração de variáveis
            double resultado;

            // Chamando o método e guardando seu valor de retorno em 'resultado'
            resultado = Media();

            // Imprimindo resultado
            Console.WriteLine("O valor da média dos 10 termos inseridos é: " + resultado);
            Console.ReadKey();
        }
    }
}
