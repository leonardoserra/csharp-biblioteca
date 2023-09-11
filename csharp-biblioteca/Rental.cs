using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Rental
    {
    public string UserLastName {  get; private set; }
    public string UserName {  get; private set; }
    public string DocumentCode {  get; private set; }
    public string DocumentTitle { get; private set; }
    public string StartRental {  get; private set; }
    public string EndRental {  get; private set; }
        public Rental(string userLastName, string userName, string documentCode, string documentTitle, string startRental, string endRental) {
            this.UserLastName = userLastName;
            this.UserName = userName;
            this.DocumentCode = documentCode;
            this.DocumentTitle = documentTitle;
            this.StartRental = startRental;
            this.EndRental = endRental;
        }
    }
}
