using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
       public string Nome { get; set; } 

       public int Idade { get; set; }

       public double Salario { get; set; }

       public void Apresentar()
       {
           Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos e minha renda salárial é {Salario}");
       }
    }
}