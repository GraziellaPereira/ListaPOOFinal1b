using FuncionarioMetodos;
using GerenteMetodos;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        bool executando = true;

        Console.WriteLine("Bem-vindo ao Sistema de Recursos Humanos! \n");

        while (executando)
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Cadastrar Funcionário");
            Console.WriteLine("2 - Cadastrar Gerente");
            Console.WriteLine("3 - Sair");
            int entrada = int.Parse(Console.ReadLine());

            switch (entrada)
            {
                case 1:
                    Funcionario f = new Funcionario();

                    Console.WriteLine("Digite o nome completo do funcionário: ");
                    f.NomeCompleto = Console.ReadLine();

                    Console.WriteLine("Digite o seu salário: ");
                    f.Salario = double.Parse(Console.ReadLine().Replace(',', '.'),
                            CultureInfo.InvariantCulture
                            );

                    Console.WriteLine("\n DADOS DO FUNCIONÁRIO:");
                    f.ExibirDados();
                    break;

                case 2:
                    Gerente g = new Gerente();

                    Console.WriteLine("Digite o nome completo do gerente: ");
                    g.NomeCompleto = Console.ReadLine();

                    Console.WriteLine("Digite o seu salário: ");
                    g.Salario = double.Parse(Console.ReadLine().Replace(',', '.'),
                            CultureInfo.InvariantCulture
                            );

                    Console.WriteLine("Digite o seu departamento: ");
                    g.Departamento = Console.ReadLine().ToUpper();

                    Console.WriteLine("\n DADOS DO GERENTE:");
                    g.ExibirDados();
                    break;

                case 3:
                    executando = false;
                    Console.WriteLine("\t Encerrando o programa...");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
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
