using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    class MyList<T>
    {
        private T[] Data = new T[0];
        private int Number = 0;

        public int Capacity
        {
            get { return Data.Length; }
        }
        public int Count 
        { 
            get { return Number;} 
        }

        public void Add(T value)
        {
            if (Data.Length == 0) 
            {
                Data = new T[4];
            }
                
            if (Number == Data.Length)
            {
                T[] Amid = new T[Data.Length * 2];
                for (int i = 0; i < Data.Length; i++)
                {
                    Amid[i] = Data[i];

                }
                Data = Amid;
            }
            Data[Number] = value;
            Number++;
        }

        public T this[int index]
        {
            get
            {
                if((index < 0) || (index > Count - 1))
                {
                    throw new ArgumentOutOfRangeException("序列号超出范围");
                }

                return Data[index];
            }
            set
            {
                Data[index] = value;
            }
        }

    }
}
