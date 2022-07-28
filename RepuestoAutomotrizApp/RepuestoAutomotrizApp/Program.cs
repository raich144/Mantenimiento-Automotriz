namespace RepuestoAutomotrizApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            GeneralCars pedido = new GeneralCars(new AutomotrizKia());
            
            pedido.CreateRepuestos();
            pedido.realizarProforma();
        }
    }
}