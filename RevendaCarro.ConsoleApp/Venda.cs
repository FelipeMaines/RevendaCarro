namespace RevendaCarro.ConsoleApp
{
    public class Venda
    {
        public Carro carro;
        public List<Venda> listaVendas = new List<Venda>();
        public DateTime data;
        public int id;
        public string nome;

        public Venda(Carro carro)
        {
            this.carro = carro;
        }

        public Venda(Carro carro, DateTime data, int id, string nome)
        {
            this.carro = carro;
            this.data = data;
            this.id = id;
            this.nome = nome;
        }
        public Venda CadastrarVenda()
        {
            carro.MostrarCarros();

            Carro carroVenda = carro.BuscarCarroPorId();

            DateTime data = DateTime.Now;

            int id = listaVendas.Count + 1;

            Console.WriteLine("Qual o nome do cliente: ");
            string nome = Console.ReadLine();

            return new Venda(carroVenda, data, id, nome);
        }

        public void InserirVenda()
        {
            Venda venda = CadastrarVenda();

            listaVendas.Add(venda);
        }

        public void MostrarVendas()
        {
            foreach (Venda v in listaVendas)
            {
                Console.WriteLine($"Nome do Carro: {v.carro.nome} | Valor: {v.carro.valor} | Nome Cliente: {v.nome} | Id: {v.id}");
            }
        }



    }
}