using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {   
        public List<Document> Documents { get; private set; }
        public List<User> Users { get; private set; }
        public List<Rental> Rentals { get; private set; }
        public Library() {
            Documents = new List<Document>();
            Users = new List<User>();
            Rentals = new List<Rental>();
        }

        //metodi per aggiungere alle liste
        public void AddDocumentInLibrary(Document document)
        {
            this.Documents.Add(document);
        }
        public void AddUserInLibrary(User user)
        {
            this.Users.Add(user);
        }
        public void AddRentalInLibrary(Rental rental)
        {
            this.Rentals.Add(rental);
        }

        public void PrintAllDocuments()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------LISTA DOCUMENTI BIBLIOTECA--------------");

            foreach (Document document in this.Documents)
            {
                Console.WriteLine(document.ToString());
            }
        }
        public void PrintAllRentals()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-------------------LISTA PRESTITI--------------");

            foreach (Rental rental in this.Rentals)
            {
                Console.WriteLine(rental.ToString());
            }
        }

    }
}
