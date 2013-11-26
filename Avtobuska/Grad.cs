using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avtobuska
{
    class Grad
    {
        public String Ime { get; set; }
        

        public Grad(String ime)
        {
            Ime = ime;
           
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Ime);
        }
    }
}
