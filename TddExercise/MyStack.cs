using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TddExercise.Exceptions;

namespace TddExercise
{
    class MyStack<T>
    {
        private T[] myStackArray;
        private int maxLen;

        public int Size { get; private set; }

        public MyStack(int lenght)
        {
            maxLen = lenght;
            myStackArray = new T[maxLen];
        }

        internal void Add(T value)
        {
            if (Size == maxLen)
            {
                throw new MyStackOverflowException();
            }

            myStackArray[Size++] = value;
        }

        internal T Remove()
        {
            if(Size == 0)
            {
                throw new CustomException();
            }

            return myStackArray[--Size];
        }

        internal T GetLastElement()
        {
            if (Size == 0)
            {
                throw new CustomException();
            }

            return myStackArray[Size - 1];
        }
    }
}
