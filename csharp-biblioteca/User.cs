using System;
using System.Collections.Generic;
using System.Linq;
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

        public override string ToString()
        {
            return $"Heilà amici di Striscia, da Cologno Monzese è tutto! Io sono: {this.LastName} {this.Name}!\nLa mia email è: {this.Email} e la mia password é: {this.Password}...\nVideochiamami! -> {this.PhoneNumber}";
        }
    }
}
