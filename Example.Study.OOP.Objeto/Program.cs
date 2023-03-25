using Example.Study.OOP.Classe;

namespace Example.Study.OOP.Objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto();
            produto.SetId(10);
            produto.Descricao = "Teclado";
            
            produto.ImprimirDescricao();
            Console.WriteLine(produto.Estoque);
        }
    }
}