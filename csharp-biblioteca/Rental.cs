using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Rental
    {
        public User User { get; set; }
        public Document Document { get; set; }
        public Rental(User user, Document document) { 
            this.User = user;
            this.Document = document;
        }
    }
}
