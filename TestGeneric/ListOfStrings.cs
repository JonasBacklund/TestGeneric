using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    public class ListOfStrings
    {
        private string[] theList;
        private int noOfElements = 10;
        private int nextIndex;
        
        public ListOfStrings()
        {
            theList = new string[noOfElements];
            nextIndex = 0;
        }
        public void AddString(string s)
        {
            theList[nextIndex] = s;
            nextIndex += 1;
        }
        public string GetString(int index)
        {
            return theList[index];
        }
        
    }
}
