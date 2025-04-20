using FuncionarioMetodos;
using System;
using System.Collections.Generic;

namespace GerenteMetodos
{

    public class Gerente : Funcionario
    {
        public string Departamento { get; set; }

        public override void ExibirDados()
        {
            base.ExibirDados(); 
            Console.WriteLine($"DEPARTAMENTO: {Departamento}");

            if (Salario > 10000)
            {
                Console.WriteLine("STATUS: Alta Gestão.");
            }
        }
    }
}
