using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class DVD : Document
    {
        public uint TimeDuration { get; set; }
        public DVD(string title, uint productionYear, string sector, uint rack, string author, uint timeDuration) : base(title, productionYear, sector, rack, author)
        {
            this.TimeDuration = timeDuration;
        }

        public override string ToString()
        {
            return $"Info DVD: \n\tCodice: {this.IdCode}\n\tTitolo: {this.Title}\n\tAnno di produzione: {this.ProductionYear}\n\tGenere/Settore: {this.Sector}\n\tScaffale: {this.Rack}\n\tAutore: {this.Author}\n\tDurata filmato in minuti: {this.TimeDuration}";
        }
    }
}
