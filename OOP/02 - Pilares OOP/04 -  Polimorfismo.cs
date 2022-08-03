namespace OOP
{
    // Poli-morfismo
    public class CafeteiraEspressa : Eletrodomestico
    {
        public CafeteiraEspressa(string nome, int voltagem) 
          : base(nome, voltagem) { }

        public CafeteiraEspressa() 
           : base("Padrão", 220) { }

        private static void AquecerAgua(){}

        private static void MoerGraos(){}

        public void PrepararCafe()
        {

        }

        public override void Testar()
        {
            //teste de cafeteira
        }

        public override void Ligar() 
        {
            //verificar recipiente de agua
        }

        public override void Desligar ()
        {
            // Resfriar aquecedor
        }
    }
}