﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsInfo
{
    class MyList<T>
    {
        T[] items;
        // constructor = Mylist classini new lersen alttaki public Mylist calisir.
        public MyList()
        {
            items = new T[0];


        }

        public void Add(T item)
        {
            T[] tempArray = items;
            //tempArray komutu ile items arrayindeki veriler newlenince kaybolmasin diye icine atadik.
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }

            items[items.Length - 1] = item;


        }



        
    }
}
