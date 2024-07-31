using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanced02
{
    internal class FixedSizeList<T>
    {
        
        public T[] Values;
        public int Capacity {get; set;}
        public FixedSizeList(int Capacity_)
        {
            Capacity = Capacity_;
            Values = new T[Capacity];
        }
        public void Add(T item)
        {
            
            if ((!(Values[Capacity - 1]?.Equals(default) ?? true))&&(!(Values[Capacity - 1]?.Equals(0) ?? true)))
            {
                
                throw new IndexOutOfRangeException("Index is out of range."); 
            }
            else
            {
                for (int i = 0; i < Values.Length; i++)
                {
                    if (Values[i]?.Equals(default) ?? true)
                    {
                        Values[i] = item;
                        return;
                    }
                }
            }
        }
        public T GetValue(int index)
        {
            if(index < 0 || index >= Values.Length)
            {
                throw new IndexOutOfRangeException("index");
            }
            return Values[index];
        }

    }
}
