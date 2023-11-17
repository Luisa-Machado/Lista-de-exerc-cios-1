/* 01) Escreva um algoritmo que armazene o valor 10 em uma variável A e o valor 20 em uma variável B. 
  A seguir (utilizando apenas atribuições entre variáveis) troque os seus conteúdos fazendo com que o 
  valor que está em A passe para B e vice-versa. Ao final, escrever os valores que ficaram armazenados 
  nas variáveis.*/

using System;

class Program
{
    static void Main()
    {
        // Inicialização das variáveis
        int A = 10;
        int B = 20;

        // Troca de valores entre A e B utilizando uma variável temporária (temp)
        int temp = A;
        A = B;
        B = temp;

        // Exibição dos valores após a troca
        Console.WriteLine("Valor em A: " + A);
        Console.WriteLine("Valor em B: " + B);
    }
}