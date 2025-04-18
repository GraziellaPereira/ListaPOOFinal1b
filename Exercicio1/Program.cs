using System;
using System.Collections.Generic;
using System.Globalization;
using ProdutoClasse;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            bool executando = true;

            Console.WriteLine("Bem-vindo ao sistema de estoque de produtos!");

            while (executando)
            {
                Console.Clear();
                Console.WriteLine("\nO que deseja fazer agora?");
                Console.WriteLine("1 - Adicionar produto ao estoque");
                Console.WriteLine("2 - Remover produto do estoque");
                Console.WriteLine("3 - Verificar o preço total de um produto no estoque");
                Console.WriteLine("4 - Ver valor total geral do estoque");
                Console.WriteLine("5 - Sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o nome do produto: ");
                        string nomeAdd = Console.ReadLine();

                        Produto produtoAdd = Produto.BuscarProduto(produtos, nomeAdd);
                        if (produtoAdd == null)
                        {
                            produtoAdd = new Produto();
                            produtoAdd.Nome = nomeAdd;
                            Console.WriteLine($"Digite o preço unitário de {nomeAdd}: ");
                            produtoAdd.Preco = double.Parse(
                            Console.ReadLine().Replace(',', '.'),
                            CultureInfo.InvariantCulture
                            );
                        }

                        produtoAdd.AdicionarEstoque();
                        break;

                    case 2:
                        Console.WriteLine("Digite o nome do produto: ");
                        string nomeRemove = Console.ReadLine();

                        Produto produtoRemove = Produto.BuscarProduto(produtos, nomeRemove);
                        if (produtoRemove == null)
                        {
                            Console.WriteLine("Produto não encontrado!");
                            break;
                        }

                        Console.WriteLine($"Digite a quantidade a remover de {produtoRemove.Nome}: ");
                        int qtdeRemove = int.Parse(Console.ReadLine());
                        produtoRemove.RemoverEstoque(qtdeRemove);
                        break;

                    case 3:
                        Console.WriteLine("Digite o nome do produto: ");
                        string nomeConsulta = Console.ReadLine();

                        Produto produtoConsulta = Produto.BuscarProduto(produtos, nomeConsulta);
                        if (produtoConsulta == null)
                        {
                            Console.WriteLine("Produto não encontrado!");
                        }
                        else
                        {
                            produtoConsulta.ValorTotalEmEstoque();
                        }
                        break;

                    case 4:
                        Produto.MostrarTotaisGerais();
                        break;

                    case 5:
                        executando = false;
                        Console.WriteLine("Sistema encerrado.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Digite um número de 1 a 5!");
                        break;
                }
            }
        }
    }
}
