using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    public class ListOfObjects<T>
    {
        private T[] theList;
        private int noOfElements = 10;
        private int nextIndex;

        public ListOfObjects()
        {
            theList = new T[noOfElements];
            nextIndex = 0;

        }
        public void AddObject(T o)
        {
            theList[nextIndex] = o;
            nextIndex += 1;
        }
        public T GetObject(int index)
        {
            return theList[index];
        }
    }
}
