using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avtobuska
{
    class RelacijaItem
    {
        public Relacija relacija1 { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} ", relacija1.Avtobusi, relacija1.Cena(), relacija1.VremePoagjanje, relacija1.VremeStiganje);
        }
    }
}
