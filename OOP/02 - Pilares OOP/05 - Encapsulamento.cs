
namespace OOP
{

    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var expresso = new CafeteiraEspressa();
            expresso.Ligar();
            expresso.PrepararCafe();
            expresso.Desligar();
        }
    }
    
}