using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericSmallStack<T>
    {
        private T[] pole = new T[10];
        private int index = 0;
        public void Push(T objekt)
        {
            //index uz je na konci pola a preto nesmie pridat vyhdzuje vynimku
            if (index == pole.Length - 1)
            {
                throw new IndexOutOfRangeException("prekrocena velkost");
            }
            pole[index] = objekt;
            index++;


        }

        public T Pop()
        {
            if (index - 1 < 0)
            {
                throw new IndexOutOfRangeException("nie je co odobrat");
            }

            return pole[index--];


        }


    }
}
