using System;

namespace Produto
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { private get; set; }
        public int QuantidadeTotal { get; private set; } = 0;

        public void AdicionarEstoque()
        {
            QuantidadeTotal += Quantidade;  
            Console.WriteLine("Produtos adicionados!");
        }

        public void RemoverEstoque(int qtde)
        {
            if (qtde <= QuantidadeTotal)
            {
                QuantidadeTotal -= qtde;
                Console.WriteLine("Produtos removidos!");
            }
            else
            {
                Console.WriteLine("Não é possível remover essa quantidade de produtos. (Quantia maior do que a presente no estoque.");
            }
        }
        public void ValorTotalEmEstoque()
        {
            double precoTotal;
            precoTotal = Preco * QuantidadeTotal;
            Console.WriteLine($"Preço total: R${precoTotal: F2}");
        }
    }
}
