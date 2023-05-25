namespace DesafioPOO.Models
{
    // Herdado da classe "Smartphone"
    public class Nokia : Smartphone

    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        
        }

        // Sobrescrito o método atraves de Polimorfismo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia");
        }
    }
}