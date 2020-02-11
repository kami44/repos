﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    class ArrayCatalog<T>
    {
        private T[] _arrayOfItems;

        public ArrayCatalog(int size)
        {
            _arrayOfItems = new T[size];
        }
        public void SetItems(int index, T t)
        {
            _arrayOfItems[index] = t;

        }

        public T getItem(int index)
        {
            return _arrayOfItems[index];
        }

        
    }
}
