namespace OOP
{
    public abstract class Eletrodomestico
    {
        private readonly _nome;
        private readonly _voltagem;

        public Eletrodomestico(string nome, int voltagem) {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();
        public abstract void Desligar();

        public virtual void Testar(){
            //teste do equipamento 
        }
    }

    public class Microondas : Eletrodomestico 
    {
        public Microondas() : base("", 12)
        {

        }

        public override void Desligar()
        {
            throw new System.NotImplementedException();
        }

        public override void Ligar()
        {
            throw new System.NotImplementedException();
        }

    }
}