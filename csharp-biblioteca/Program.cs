namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User gimmighione = new User("Ghione", "Gimmi", "gghione@gmail.ghione", "castoroMolesto2023!","392-2378755");
            User yoda = new User("Maestro", "Yoda", "com@yoda.maestro", "0987654321", "505050505");
            Document servizioStrisciaLaNotizia = new Document("Cuccioli di cinghiale a Cologno Monzese (feat.Boldi)", 1992, "Cronaca Comica", 78, "Splash Editorial");
            Book storiaDelCinepanettone = new Book("Storia del Cinepanettone", 2020, "Storia", 165, "MEDUSA", 256);
            DVD agenteSpecialeBonolis = new DVD("Agente Speciale Bonolis", 1999, "Azione/Drammatico", 12, "DeLaurentis Production", 178);
            Library bibliotecaComunale = new Library();

            bibliotecaComunale.AddUserInLibrary(gimmighione);
            bibliotecaComunale.AddUserInLibrary(yoda);

            bibliotecaComunale.AddDocumentInLibrary(servizioStrisciaLaNotizia);
            bibliotecaComunale.AddDocumentInLibrary(storiaDelCinepanettone);
            bibliotecaComunale.AddDocumentInLibrary(agenteSpecialeBonolis);
            
            bibliotecaComunale.PrintAllUsers();
            bibliotecaComunale.PrintAllDocuments();

            gimmighione.SearchDocument("00283991" ,"Cuccioli di cinghiale a Cologno Monzese (feat.Boldi)", bibliotecaComunale.Documents);

            gimmighione.rentDocument("Agente Speciale Bonolis", "25 Marzo 2023", bibliotecaComunale);
            yoda.rentDocument("Cuccioli di cinghiale a Cologno Monzese (feat.Boldi)", "28 Novembre 2023", bibliotecaComunale);

            bibliotecaComunale.PrintAllRentals();
        }
    }
}