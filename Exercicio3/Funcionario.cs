using System;
using System.Globalization;

namespace FuncionarioMetodos
{
    public class Funcionario
    {
        public string NomeCompleto { get; set; }    
        public double Salario { get; set; }

        public virtual void ExibirDados()
        {
            string[] partesNome = NomeCompleto.Split(new char[] { ' ' });
            string ultimoSobrenome = partesNome[partesNome.Length - 1].ToUpper();


            Console.WriteLine($"SOBRENOME: {ultimoSobrenome}");
            Console.WriteLine($"SALÁRIO: {Salario.ToString("C", new CultureInfo("pt-BR"))}");
        }
    }
}
