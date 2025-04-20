using System;
using System.Collections.Generic;


namespace VagaMetodos
{
    public class VagaEstacionamento
    {
        private readonly int numeroVaga;
        private bool ocupada;
        private string tipoVeiculo;

        public int NumeroVaga => numeroVaga;

        public bool Ocupada
        {
            get => ocupada;
            private set => ocupada = value;
        }

        public string TipoVeiculo
        {
            get => tipoVeiculo;
            private set
            {
                if (value.Equals("Carro", StringComparison.OrdinalIgnoreCase) ||
                    value.Equals("Moto", StringComparison.OrdinalIgnoreCase) ||
                    value.Equals("Caminhão", StringComparison.OrdinalIgnoreCase))
                {
                    tipoVeiculo = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower(); 
                }
                else
                {
                    throw new ArgumentException("Tipo de veículo inválido. Deve ser 'Carro', 'Moto' ou 'Caminhão'.");
                }
            }

        }

        public VagaEstacionamento(int numeroVaga, string tipoVeiculo)
        {
            this.numeroVaga = numeroVaga;
            TipoVeiculo = tipoVeiculo;
            Ocupada = false; 
        }

        public void OcuparVaga()
        {
            Ocupada = true;
        }

        public void LiberarVaga()
        {
            Ocupada = false;
        }
        public void AlterarTipoVeiculo(string novoTipo)
        {
            if (Ocupada)
            {
                Console.WriteLine("Não é possível alterar o tipo de veículo enquanto a vaga estiver ocupada.");
            }
            else
            {
                try
                {
                    TipoVeiculo = novoTipo;
                    Console.WriteLine("Tipo de veículo alterado com sucesso.");
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void ExibirInformacoes()
        {
            string status = Ocupada ? "Ocupada" : "Livre";
            Console.WriteLine($"\n Vaga {NumeroVaga}");
            Console.WriteLine($"Tipo permitido: {TipoVeiculo}");
            Console.WriteLine($"Status: {status}");
        }
    }
}
