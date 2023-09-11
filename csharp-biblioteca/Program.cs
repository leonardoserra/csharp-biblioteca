namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User gimmighione = new User("Ghione", "Gimmi", "gghione@gmail.ghione", "castoroMolesto2023!","392-2378755");
            Console.WriteLine(gimmighione.ToString());
            Console.WriteLine();

            Document servizioStrisciaLaNotizia = new Document("Cuccioli di cinghiale a Cologno Monzese (feat.Boldi)", 1992, "Cronaca Comica", 78, "Splash Editorial");
            Console.WriteLine(servizioStrisciaLaNotizia.ToString());
            Console.WriteLine();

            Book storiaDelCinepanettone = new Book("Storia del Cinepanettone", 2020, "Storia", 165, "MEDUSA", 256);
            Console.WriteLine(storiaDelCinepanettone.ToString());
            Console.WriteLine();


        }
    }
}