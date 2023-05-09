namespace RevendaCarro.ConsoleApp
{
    public class Carro
    {
        public string nome { get; set; }
        public int valor { get; set; }
        public int id { get; set; }

        public List<Carro> listaCarros = new List<Carro>();

        public Carro(string nome, int valor, int id)
        {
            this.nome = nome;
            this.valor = valor;
            this.id = id;
        }

        public Carro()
        {
        }

        public Carro CadastrarCarro()
        {
            Console.WriteLine("Qual o nome do carro: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual o valor do carro: ");
            int valor = int.Parse(Console.ReadLine());

            int id = listaCarros.Count + 1;

            return new Carro(nome, valor, id);
        }

        public void InserirCarro()
        {
            Carro carro = CadastrarCarro();

            listaCarros.Add(carro);
        }

        public void MostrarCarros()
        {
            foreach (Carro c in listaCarros)
            {
                Console.WriteLine($"Nome: {c.nome} | Valor: {c.valor} | Id: {c.id}");
            }
        }

        public Carro BuscarCarroPorId()
        {
            Console.WriteLine("Qual o id do carro: ");
            int idCarro = int.Parse(Console.ReadLine());
            Carro carro = null;

            foreach (Carro c in listaCarros)
            {
                if(c.id == idCarro)
                {
                    carro = c;
                }
            }
            return carro;
        }
    }
}