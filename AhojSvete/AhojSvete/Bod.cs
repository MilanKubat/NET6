using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhojSvete
{
    class Bod
    {
        //KONSTRUKTORY
        
        //ATRIBUTY
        public float X { get; set; }
        public float Y { get; set; }

        //METODY
        public override string ToString()
        {
            return X + "\t" + Y;
        }

    }
}
