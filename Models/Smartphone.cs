namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        //Implementado as propriedades faltantes de acordo com o diagrama
        protected string Modelo;
        protected string Imei;
        protected int Memoria;


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}