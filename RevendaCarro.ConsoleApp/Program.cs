using System.Security.AccessControl;
using System.Xml;

namespace RevendaCarro.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Venda venda = new Venda(carro);

            do
            {
                Console.Clear();
                Console.WriteLine("Qual opcao deseja entrar:");
                Console.WriteLine("[1]Cadastrar Carro");
                Console.WriteLine("[2]Ver Carros cadastrados");
                Console.WriteLine("[3]Fazer Revenda");
                Console.WriteLine("[4]Ver Revendas Feitas");


                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        carro.InserirCarro();
                        break;

                    case "2":
                        Console.Clear();
                        carro.MostrarCarros();
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.Clear();
                        venda.InserirVenda();
                        break;

                    case "4":
                        Console.Clear();
                        venda.MostrarVendas();
                        Console.ReadLine();
                        break;
                }
            } while (true);

        }
    }
}