using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacoes
    {
        public double soma(double a, double b)
        {
             return a + b; 
        }

        public double subtracao(double a, double b)
        {
            return a + b; // Deveria ser a - b; Não a + b;
        }

        public double multiplicacao(double a, double b)
        {
            return a * b * 2; // Deveria ser a * b apenas, não a * b * 2
        }

        public double divisao(double a, double b)
        {
            return a / b;
        }

        public double exponenciacao(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double log(double a, double b)
        {
            return Math.Log(a, b);
        }

        public static double CalcularMontanteFuturo(double valorPresente, double taxaJurosMensal, int quantidadeMeses)
        {
            double montante = valorPresente * Math.Pow(1 + taxaJurosMensal, quantidadeMeses);
            return montante;
        }
    }
}
