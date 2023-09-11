using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class User
    {
        public string LastName { get; private set; }
        public string Name{ get; private set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }

        public User(string lastName, string name, string email, string password, string phoneNumber)
        {
            this.LastName = lastName;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phoneNumber;
        }

        //metodi
        public void SearchDocument(string idToSearch, string titleToSearch, List<Document> documentList)
        {
            Console.WriteLine("---------Risultati ricerca:---------");
            Console.WriteLine();
            foreach (var document in documentList)
            {
                if (idToSearch == document.IdCode || titleToSearch == document.Title)
                {
                    Console.WriteLine(document.ToString());
                }
            }
            Console.WriteLine();
            Console.WriteLine("--------Fine Ricerca--------");

        }

        public void rentDocument(string documentName, DateTime endingDate, Library library)
        {
            Rental rent = new Rental(this.LastName,this.Name,documentName, endingDate);
            library.AddRentalInLibrary(rent);
        }
        public override string ToString()
        {
            return $"Heilà amici di Striscia, da Cologno Monzese è tutto!\n\tIo sono: {this.LastName} {this.Name}!\n\tLa mia email è: {this.Email}\n\tLa mia password é: {this.Password}\n\tVideochiamami! -> {this.PhoneNumber}";
        }
    }
}
