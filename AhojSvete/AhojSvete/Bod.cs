﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhojSvete
{
    class Bod
    {
        //KONSTRUKTORY
        public Bod()
        {
            X = 100;
            Y = 100;
        }

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

        /// <summary>
        /// Vrátí obsah čtyřúhelníku, který je daný bodem 0,0 a bodem X,Y
        /// </summary>
        /// <returns>float</returns>
        public float Obsah()
        {
            return Math.Abs(X * Y);
        }

    }
}
