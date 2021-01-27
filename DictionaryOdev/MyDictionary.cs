using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryOdev
{
    class MyDictionary<T,X>
    {
        T[] keys;
        X[] values;

        public MyDictionary()
        {
            keys = new T[0];

            values = new X[0];

        }
        
        public void Add(T key, X value)
        {
            T[] tempKeys = keys;
            X[] tempValues = values;
            keys = new T[keys.Length + 1];
            values = new X[values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
            }

            for (int j = 0; j < tempValues.Length; j++)
            {
                values[j] = tempValues[j];


            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

            
        }
        public void Sonuc()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " : " + values[i]);

            }
        }


    }
}
