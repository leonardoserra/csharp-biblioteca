namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User gimmighione = new User("Ghione", "Gimmi", "gghione@gmail.ghione", "castoroMolesto2023!","392-2378755");
            Console.WriteLine(gimmighione.ToString());

            Document servizioStrisciaLaNotizia = new Document("Cuccioli di cinghiale a Cologno Monzese (feat.Boldi)", 1992, "Cronaca Comica", 78, "Splash Editorial");
            Console.WriteLine(servizioStrisciaLaNotizia.ToString());

        }
    }
}