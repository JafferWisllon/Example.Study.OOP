using Example.Study.OOP.Polimorfismo;

namespace Example.Study.OOP.Encapsulamento
{
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var expresso = new CafeteiraExpressa();
            expresso.Ligar();
            expresso.PrepararCafe();
            expresso.Desligar();
        }
    }
}