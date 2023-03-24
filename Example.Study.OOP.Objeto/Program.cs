using Example.Study.OOP.Classe;

namespace Example.Study.OOP.Objeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto();
            produto.Descricao = "Teclado";
            produto.SetId(10);

            produto.ImprimirDescricao();
        }
    }
}