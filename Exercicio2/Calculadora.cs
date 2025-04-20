using System;

namespace Exercicio2
{
    public class Calculadora
    {
        private Calculo calculo = new Calculo();
        public void LerValores()
        {
            Console.WriteLine("Olá! Essa calculadora consegue manipular dois valores. Vamos começar?");
            Console.WriteLine("Digite o valor A: ");
            calculo.ValorA = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor B: ");
            calculo.ValorB = double.Parse(Console.ReadLine());
        }

        public void ExecutarCalculadora()
        {
            bool executando = true;
            LerValores();
            while (executando) {

                Console.WriteLine("\n O que deseja fazer?");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Maior Valor");
                Console.WriteLine("5 - Somar com valor adicional");
                Console.WriteLine("6 - Reiniciar com novos valores");
                Console.WriteLine("7 - Sair");

                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        calculo.CalcularSoma();
                        Console.WriteLine($"Resultado: {calculo.ImprimirResultado()}");
                        break;
                    case 2:
                        calculo.CalcularSubtracao();
                        Console.WriteLine($"Resultado: {calculo.ImprimirResultado()}");
                        break;
                    case 3:
                        calculo.CalcularMultiplicacao();
                        Console.WriteLine($"Resultado: {calculo.ImprimirResultado()}");
                        break;
                    case 4:
                        Console.WriteLine($"Maior valor: {calculo.RetornarMaior()}");
                        break;
                    case 5:
                        Console.Write("Digite o valor adicional: ");
                        double extra = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Soma geral: {calculo.SomarGeral(extra)}");
                        break;
                    case 6:
                        LerValores();
                        break;
                    case 7:
                        executando = false;
                        Console.WriteLine("Encerrando o programa...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        return;

                        
                }
                if (executando)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            
        }
    
}
}
