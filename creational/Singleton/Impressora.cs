namespace Singleton
{
    public class Impressora
    {
        public string Marca { get; private set; }
        public string Endereco { get; private set; }
        public string Porta { get; private set; }
        private static readonly Impressora _instancia = new Impressora();

        private Impressora()
        {
            this.Marca = "HP Deskjet F300 Series";
            this.Endereco = "10.211.55.1";
            this.Porta = "9100";
        }

        public static Impressora Iniciar
        {
            get { return _instancia; }
        }

		public void Print(string matricula)
		{
			System.Console.WriteLine("imprimindo...");
			System.Console.WriteLine($"Matricula do Funcionário: {matricula}\n{this} \n");
		}

        public override string ToString()
        {
            return $"Marca: {this.Marca}\nIP: {this.Endereco}\nPorta: {this.Porta}";
        }
    }
}