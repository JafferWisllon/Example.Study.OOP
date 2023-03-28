using Example.Study.OOP.Abstracao;

namespace Example.Study.OOP.Polimorfismo
{
    public class CafeteiraExpressa : Eletrodomestico
    {
        public CafeteiraExpressa(string nome, int voltagem) : base(nome, voltagem) {}

        public CafeteiraExpressa(): base("Padrão", 220){}

        private static void AquecerAgua() { }
        private static void MoerGraos() { }
        
        public void PrepararCage()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
        }
        public override void Desligar()
        {
            // Verificar recipiente de agua
        }

        public override void Ligar()
        {
            // Resfriar aquecedor
        }
    }
}