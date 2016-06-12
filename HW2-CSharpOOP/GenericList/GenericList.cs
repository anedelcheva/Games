using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericList
{
    class GenericList<T>
    {
        private const int starting_index = 0;
        private int index;
        private int capacity;
        private T[] array;

        public GenericList(int capacity)
        {
            this.capacity = capacity;
            this.index = starting_index;
            array = new T[capacity];
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value < 1 || value > int.MaxValue)
                {
                    throw new ArgumentException("Capacity cannot be less than 1 and bigger than 4294967296");
                }

                capacity = value;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {

            }
        }

        static void Main(string[] args)
        {
        }
    }
}