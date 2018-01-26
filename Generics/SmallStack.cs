using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class SmallStack
    {
        private int[] pole = new int[10];
        private int index = 0;
        public void Push( int cislo)
        {
            if (index==pole.Length-1)
            {
                throw new IndexOutOfRangeException("prekrocena velkost");
            }
            pole[index] = cislo;
            index++;
            

        }

        public int Pop()
        {
            int res = pole[index];
            index--;
            return res;
                // mozno aj return pole[index--]


        }


    }
}
