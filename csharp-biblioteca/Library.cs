using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {   
        public List<Document> Documents { get; private set; }
        public List<User> Users { get; private set; }
        public Dictionary<User,Document> Rentals { get; private set; }
        public Library() {
            Documents = new List<Document>();
            Users = new List<User>();
            Rentals = new Dictionary<User, Document>();
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
        public void AddRentalInLibrary(User user, Document document)
        {
            this.Rentals.Add(user,document);
        }

    }
}
