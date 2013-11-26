using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Avtobuska
{
    class Relacija
    {
        public Grad Trgnuva { get; set; }
        public Grad Pristignuva { get; set; }
        public int Kilometraza { get; set; }
        public String Avtobusi { get; set; }
        public String VremePoagjanje { get; set; }
        public String VremeStiganje { get; set; }

        public Relacija(Grad grad1, Grad grad2,int kilometraza, String bus, String trgnuvavo, String pristignuvavo)
        {
            Trgnuva = grad1;
            Pristignuva = grad2;
            Kilometraza = kilometraza;
            Avtobusi = bus;
            VremePoagjanje = trgnuvavo;
            VremeStiganje = pristignuvavo;
        }

        public int Cena()
        {
            int cena = Kilometraza*2;
            return cena;
        }
        public override string ToString()
        {
            return string.Format("{0} - {1:000} den - {2} - {3} ",this.Avtobusi, this.Cena(), this.VremePoagjanje, this.VremeStiganje);
        }
    }

}
