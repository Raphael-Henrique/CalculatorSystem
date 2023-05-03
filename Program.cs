using System;
using System.ComponentModel.Design;

namespace CalculatorSystem
{
    class Program : Operacoes
    {
        public static void Main(string[] args)
        {

            double num1, num2, resultado;
            int op = 0;
            
            Operacoes operacoes= new Operacoes();

           


            while (op!=6)
            {
            Console.Clear();
            Console.Write("\n[1]-Adição" + "\n[2]-Subtração" + "\n[3]-Multiplicação" + "\n[4]-Divisão" + "\n[5]-Encerrar");
            Console.Write("\n\nDigite uma das opções acima: ");
            op = int.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("\nDigite o primeiro termo da operação: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("\nDigite o segundo termo da operação: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = operacoes.adicao(num1, num2);
                        Console.WriteLine($"\nO resultado é {resultado}");
                        resultado = 0;
                        Thread.Sleep(3000);
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("\nDigite o primeiro termo da operação: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("\nDigite o segundo termo da operação: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = operacoes.subtracao(num1, num2);
                        Console.WriteLine($"\nO resultado é {resultado}");
                        resultado = 0;
                        Thread.Sleep(3000);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("\nDigite o primeiro termo da operação: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("\nDigite o segundo termo da operação: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = operacoes.multiplicacao(num1, num2);
                        Console.WriteLine($"\nO resultado é {resultado}");
                        resultado = 0;
                        Thread.Sleep(3000);
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("\nDigite o primeiro termo da operação: ");
                        num1 = double.Parse(Console.ReadLine());
                        Console.Write("\nDigite o segundo termo da operação: ");
                        num2 = double.Parse(Console.ReadLine());
                        resultado = operacoes.divisao(num1, num2);
                        Console.WriteLine($"\nO resultado é {resultado}");
                        resultado = 0;
                        Thread.Sleep(3000);
                        break;
                    case 5:
                        Console.WriteLine("\nCalculadora encerrada.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Write("\nOpção inválida!\n");
                        break;
                }

            }
              
        }
    }
}