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
        public Bod (float x, float y)
        {
            X = x;
            Y = y;
        }
        
        //ATRIBUTY
        public float X { get; set; }
        public float Y { get; set; }


        //METODY
        public override string ToString()
        {
            return "BOD:" + "\t" + X + "\t" + Y;
        }

        public float Obsah()
        {
            return X * Y;
        }

    }
}
