namespace Example.Study.OOP.Classe
{
    public class Produto
    {
        private int Id;
        public string Descricao {  get; set; }
        //public readonly int Estoque;
        public int Estoque { get; }
        
        public Produto()
        {
            Estoque = 1;
        }

        public void ImprimirDescricao()
        {
            Console.WriteLine($"{Id} - {Descricao}");
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetId()
        {
            return Id;
        }
    }
}