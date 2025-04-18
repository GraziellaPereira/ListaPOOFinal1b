using System;
using System.Collections.Generic;

namespace ProdutoClasse
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { private get; set; }
        public int QuantidadeTotal { get; private set; } = 0;
        public static int QuantidadeTotalGeral { get; private set; } = 0;
        public static double PrecoTotalGeral { get; private set; } = 0;

        public void AdicionarEstoque()
        {
            Console.WriteLine("Informe a quantidade a adicionar: ");
            Quantidade = int.Parse(Console.ReadLine());
            double PrecoTotal = Preco * Quantidade;
            PrecoTotalGeral += PrecoTotal;
            QuantidadeTotal += Quantidade;
            QuantidadeTotalGeral += Quantidade;
            Console.WriteLine($"{Quantidade} {Nome}(s) adicionados(as). Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }

        public void RemoverEstoque(int qtde)
        {
            if (qtde <= QuantidadeTotal)
            {
                QuantidadeTotal -= qtde;
                QuantidadeTotalGeral -= qtde;
                PrecoTotalGeral -= qtde * Preco;
                Console.WriteLine($"{qtde} {Nome}(s) removidos(as). Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Não é possível remover {qtde} {Nome}(s). (Quantia informada maior do que a presente no estoque.). Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            }
        }

        public static Produto BuscarProduto(List<Produto> produtos, string nome)
        {
            return produtos.Find(p => p.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
        }
        public void ValorTotalEmEstoque()
        {
            double total = Preco * QuantidadeTotal;
            Console.WriteLine($"\n Preço total de {Nome} = R${total:F2}. Pressione qualquer tecla para continuar.");
            Console.ReadKey();

        }
        public static void MostrarTotaisGerais()
        {
            Console.WriteLine($"\nQuantidade total do estoque: {QuantidadeTotalGeral}");
            Console.WriteLine($"Valor total do estoque: R$ {PrecoTotalGeral:F2}. Pressione qualquer tecla para continuar.");
            Console.ReadKey();
        }


    }
}
