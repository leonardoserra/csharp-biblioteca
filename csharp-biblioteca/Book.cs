using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Book : Document
    {
        public uint PageNumber { get; set; }
        public Book(string title, uint productionYear, string sector, uint rack, string author, uint pageNumber) : base(title, productionYear, sector, rack, author)
        {
            this.PageNumber = pageNumber;
        }

        public override string ToString()
        {
            return $"Info libro: \n\tCodice: {this.IdCode}\n\tTitolo: {this.Title}\n\tAnno di produzione: {this.ProductionYear}\n\tGenere/Settore: {this.Sector}\n\tScaffale: {this.Rack}\n\tAutore: {this.Author}\n\tNumero pagine: {this.PageNumber}";
        }
    }
}
