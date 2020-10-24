﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid73
{


    class Rainbow : IEnumerable, IEnumerator
    {
        private short IteratorIndex = -1;

        public IEnumerator GetEnumerator()
        { return this; }

        public object Current
        {
            get
            {
                switch (IteratorIndex)
                {
                    case 0: return "Red";
                    case 1: return "Orange";
                    case 2: return "Yellow";
                    case 3: return "Green";
                    case 4: return "Blue";
                    case 5: return "Indigo";
                    case 6: return "Violet";
                    default: return "*** ERROR ***";
                }
            }
        }

        public bool MoveNext()
        {
            IteratorIndex++;
            if (IteratorIndex == 7)
                return false;
            return true;
        }

        public void Reset()
        { IteratorIndex = -1; }

        public static void Main()
        {
            Rainbow MyRainbow = new Rainbow();
            foreach (string ColorName in MyRainbow)
                Console.WriteLine(ColorName);
        }
    }
}


