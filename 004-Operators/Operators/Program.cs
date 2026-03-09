using System;

namespace Program
{
   class Program
   {
       static void Main(string[] args)
       {
           int Num1, Num2, result;
           char option;

           Console.Write("Escreva o primeiro numero: ");
           Num1 = Convert.ToInt32(Console.ReadLine());
           Console.Write("Escreva o segundo numero: ");
           Num2 = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Tabela");
           Console.WriteLine("1. Adição");
           Console.WriteLine("2. Subtração");
           Console.WriteLine("3. Multiplicação");
           Console.WriteLine("4. Divisão");
           Console.WriteLine("5. Resto da divisão");
           Console.WriteLine("6. Incremento e decremento");
           Console.WriteLine("7. Operadores logicos");
           Console.WriteLine("8. Operadors de comparação");
           Console.Write("Escolha o operador: ");
           option = Convert.ToChar(Console.ReadLine());

            switch (option)
            {
                case '1':
                    result = Num1 + Num2;
                    Console.WriteLine("O resultado da Adição é: {0}", result);
                    break;
                case '2':
                    result = Num1 - Num2;
                    Console.WriteLine("O resultado da Subtração é: {0}", result);
                    break;
                case '3':
                    result = Num1 * Num2;
                    Console.WriteLine("O resultado da Multiplicação é: {0}", result);
                    break;
                case '4':
                    if (Num2 == 0)
                    {
                        Console.WriteLine("Erro: Divisão por zero");
                    }
                    else
                    {
                        result = Num1 / Num2;
                        Console.WriteLine("O resultado da Divisão é: {0}", result);
                    }
                    break;
                case '5':
                    result = Num1 % Num2;
                    Console.WriteLine("O resto da Divisão (Módulo) é: {0}", result);
                    break;
                case '6':
                    Console.WriteLine("Incrementando Num1 em 1: {0}", ++Num1);  // Pre-increment
                    Console.WriteLine("Decrementando Num2 em 1: {0}", Num2--);  // Post-decrement
                    break;
                case '7':
                    bool isEqual = Num1 == Num2;
                    Console.WriteLine("Os números são iguais? {0}", isEqual);
                    bool isNotGreater = !(Num1 > Num2);
                    Console.WriteLine("Num1 NÃO é maior que Num2? {0}", isNotGreater);
                    break;
                case '8':
                    Console.WriteLine("Num1 é maior que Num2? {0}", Num1 > Num2);
                    Console.WriteLine("Num1 é menor ou igual a Num2? {0}", Num1 <= Num2);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

           Console.ReadLine();
       }
   }
}
