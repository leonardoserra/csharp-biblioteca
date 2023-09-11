﻿namespace csharp_biblioteca
{
    internal class Rental
    {
    public string UserLastName {  get; private set; }
    public string UserName {  get; private set; }
    public string DocumentTitle { get; private set; }
    public DateTime StartingDate{  get; private set; }
    public DateTime EndingDate {  get; private set; }
        public Rental(string userLastName, string userName, string documentTitle, DateTime endingDate) {
            this.UserLastName = userLastName;
            this.UserName = userName;
            this.DocumentTitle = documentTitle;
            this.StartingDate = DateTime.Now;
            this.EndingDate = endingDate;
        }
    }
}
