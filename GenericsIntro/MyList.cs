﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
              //gecicidizi
            T[] tempArray = items; 
            items = new T[items.Length + 1]; //new dediğin zaman önceki referans gitmesin diye yukarıda geçiçi diziye emanet ettik
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }
    }
}
