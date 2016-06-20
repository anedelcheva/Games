using System;

namespace GenericList
{
    class GenericList<T>
    {
        private int nextIndex = 0;
        private int capacity;
        private T[] array;

        public GenericList(int capacity)
        {
            this.capacity = capacity;
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

        public int NextIndex
        {
            get
            {
                return nextIndex;
            }
            set
            {
                this.nextIndex = value;
            }
        }

        public T this[int idx]
        {
            get
            {
                if (idx < 0 || idx > this.nextIndex - 1)
                {
                    throw new IndexOutOfRangeException(String.Format("Index should be in the range [0, {0}]", this.nextIndex - 1));
                }
                return this.array[idx];
            }

            set
            {
                if (idx < 0 || idx > this.nextIndex - 1)
                {
                    throw new ArgumentOutOfRangeException(String.Format("Index should be in the range [0, {0}]", this.nextIndex - 1));
                }

                this.array[idx] = value;
            }
        }

        public void Remove(int index)
        {
            if (index >= nextIndex)
            {
                throw new ArgumentOutOfRangeException(String.Format("An element ar position {0} doesn't exist", index));
            }
            for (int i = index; i < nextIndex && i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            this.nextIndex--;
            this.array[nextIndex] = default(T);
        }

        public void Add(T element)
        {
            if (nextIndex == capacity)
            {
                T[] oldarray = this.array;
                capacity *= 2;
                this.array = new T[capacity];
                Array.Copy(oldarray, this.array, this.nextIndex);
            }
            this.array[nextIndex] = element;
            this.nextIndex++;
        }

        public void Insert(int index, T element)
        {
            if (this.nextIndex == this.array.Length)
            {
                T[] oldarray = this.array;
                capacity *= 2;
                this.array = new T[capacity];
                Array.Copy(oldarray, this.array, this.nextIndex);
            }
            for (int i = this.nextIndex - 1; i >= index && i > 0; i--)
            {
                this.array[i] = this.array[i - 1];

            }
            this.nextIndex++;
        }
    }
}