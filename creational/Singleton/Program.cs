using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var imp1 = Impressora.Iniciar;
            var imp2 = Impressora.Iniciar;
            var imp3 = Impressora.Iniciar;

            if (imp1 == imp2 && imp2 == imp3)
            {
                System.Console.WriteLine("Mesma Instância!! \n");
            }

            var func1 = new Funcionario { Nome = "Jose", Matricula = "123"};
            var func2 = new Funcionario { Nome = "Pedro", Matricula = "456"};
            var func3 = new Funcionario { Nome = "Thiago", Matricula = "789"};

            imp1.Print(func1.Matricula);
            imp2.Print(func2.Matricula);
            imp3.Print(func3.Matricula);
            
        }
    }
}
