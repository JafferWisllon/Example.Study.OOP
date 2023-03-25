namespace Example.Study.OOP.Heranca
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }

        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Codigo: {Id}");
            Console.WriteLine($"Endereco: {Endereco}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Cep: {Cep}");
        }
    }
}