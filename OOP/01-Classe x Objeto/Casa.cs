namespace  OOP
{

    //Definição de Classe
    protected class Casa {
        public Casa()
        {
        }

        private int TamanhoM2 {get; set;}
        private int Andares {get; set;}
        private decimal Valor {get; set;}
        private int NumeroVagas {get; set;}
    }

    public class Objeto  
    {
        public Objeto()
        {
            //Definição de Objeto
            var casa = new Casa 
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3
            }
        }
    }
}