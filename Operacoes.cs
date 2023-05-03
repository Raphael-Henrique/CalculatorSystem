using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorSystem
{
    public class Operacoes
    {
        /*
            Metodos: Adição, subtração, Multiplicação, Divisão
        */
        
        public double adicao(double num1, double num2)
        {
            return num1 + num2;
        }

        public double subtracao(double num1, double num2)
        {    
            return num1 - num2;
        }

        public double multiplicacao(double num1, double num2)
        {
            return num1 * num2;
        }

        public double divisao(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
