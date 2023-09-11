using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Library
    {   
        private List<Document> Documents { get; }
        private List<User> Users { get; }
        private List<Rental> Rentals { get; }
        public Library() {
            Documents = new List<Document>();
            Users = new List<User>();
            Rentals = new List<Rental>();
        }


    }
}
