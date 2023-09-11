using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Document
    {
        internal string IdCode { get; private set; }
        internal string Title { get;  set; }
        internal uint ProductionYear { get; set; }
        internal string Sector { get; set; }
        internal uint Rack { get; set; }
        internal string Author { get; set; }

        public Document(string title, uint productionYear, string sector, uint rack, string author) {
            this.IdCode = "n." + Random.Shared.Next(0, 99999).ToString("D8");
            this.Title = title;
            this.ProductionYear = productionYear;
            this.Sector = sector;
            this.Rack = rack;
            this.Author = author;
        }

        public override string ToString()
        {
            return $"Info documento: \n\tCodice: {this.IdCode}\n\tTitolo: {this.Title}\n\tAnno di produzione: {this.ProductionYear}\n\tGenere/Settore: {this.Sector}\n\tScaffale: {this.Rack}\n\tAutore: {this.Author}";
        }
    }
}
