using System;
using VagaMetodos;

class Program
{
    static void Main(string[] args)
    {
        VagaEstacionamento vaga = null;
        bool executando = true;

        Console.WriteLine("Bem-vindo ao Controle de Vagas do Estacionamento! \n");

        while (executando)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Criar nova vaga");
            Console.WriteLine("2 - Ocupar vaga");
            Console.WriteLine("3 - Liberar vaga");
            Console.WriteLine("4 - Alterar tipo de veículo");
            Console.WriteLine("5 - Exibir informações da vaga");
            Console.WriteLine("6 - Sair");
            Console.Write("Opção: ");

            int opcao;
            bool entradaValida = int.TryParse(Console.ReadLine(), out opcao);

            if (!entradaValida)
            {
                Console.WriteLine("Opção inválida. Digite um número de 1 a 6.");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o número da vaga: ");
                    int numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("Digite o tipo de veículo permitido (Carro, Moto ou Caminhão): ");
                    string tipo = Console.ReadLine();

                    try
                    {
                        vaga = new VagaEstacionamento(numero, tipo);
                        Console.WriteLine("Vaga criada com sucesso.");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Erro: {ex.Message}");
                    }
                    break;

                case 2:
                    if (vaga != null)
                    {
                        vaga.OcuparVaga();
                        Console.WriteLine("Vaga ocupada.");
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma vaga foi criada ainda.");
                    }
                    break;

                case 3:
                    if (vaga != null)
                    {
                        vaga.LiberarVaga();
                        Console.WriteLine("Vaga liberada.");
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma vaga foi criada ainda.");
                    }
                    break;

                case 4:
                    if (vaga != null)
                    {
                        Console.WriteLine("Digite o novo tipo de veículo (Carro, Moto ou Caminhão): ");
                        string novoTipo = Console.ReadLine();
                        vaga.AlterarTipoVeiculo(novoTipo);
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma vaga foi criada ainda.");
                    }
                    break;

                case 5:
                    if (vaga != null)
                    {
                        vaga.ExibirInformacoes();
                    }
                    else
                    {
                        Console.WriteLine("Nenhuma vaga foi criada ainda.");
                    }
                    break;

                case 6:
                    executando = false;
                    Console.WriteLine("Encerrando o sistema...");
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
