namespace StringExtensions
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine($"Her er et random tal med den nye øvre grænse: {Extensions.NextDouble(3.0)} ");
            //var random = new Random();
            //bool platEllerKrone = Extensions.CoinFlip(random);

            //if (platEllerKrone)
            //{
            //    Console.WriteLine("Det blev plat");
            //}

            //else 
            //{
            //    Console.WriteLine("Det blev krone");
            //}

            string[] retning  = { "Nord", "Syd", "Øst", "Vest" };

            
            Console.WriteLine(Extensions.NextString(retning));
            Console.ReadKey();
        }
    }
}
