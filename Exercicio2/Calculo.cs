using System;

namespace Exercicio2
{
    public class Calculo
    {
        private double Resultado { get; set; }
        public double ValorA { get; set; }
        public double ValorB { get; set; }

        public void CalcularSoma()
        {
            Resultado = ValorA + ValorB;
        }

        public void CalcularSubtracao()
        {
            Resultado = ValorA - ValorB;
        }

        public void CalcularMultiplicacao()
        {
            Resultado = ValorA * ValorB;
        }

        public double RetornarMaior()
        {
            return (ValorA > ValorB) ? ValorA : ValorB;
        }

        public double SomarGeral(double valor)
        {
            return ValorA + ValorB + valor;
        }

        public double ImprimirResultado()
        {
            return Resultado;
        }
    }

}
