namespace Example.Study.OOP.Heranca
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }

        public void ImprimirCpf()
        {
            Console.WriteLine($"CPF: {CPF}");
        }
    }
}
