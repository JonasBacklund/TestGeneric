using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSample<string> dss = new DataSample<string>("forty-two");
            DataSample<int> dsi = new DataSample<int>(42);
            ListOfStrings LoS = new ListOfStrings();
            ListOfObjects<string> loos = new ListOfObjects<string>();
            ListOfObjects<int> looi = new ListOfObjects<int>();
            ListOfObjects<object> list = new ListOfObjects<object>();
            

            String s = dss.GetData();
            int i = dsi.GetData();

            String[] words = { "C++", "MacOS", "C#", "Android", "Python" };
            String middle = DataSample<string>.getMiddleElement(words);

            LoS.AddString("1");
            LoS.AddString("2");
            LoS.AddString("3");

            loos.AddObject("hej");
            looi.AddObject(22);

            list.AddObject("ett");
            list.AddObject(1);
            Console.WriteLine(list.GetObject(0));
            Console.WriteLine(list.GetObject(1));
            Console.WriteLine(LoS.GetString(0));
            Console.WriteLine(LoS.GetString(1));
            Console.WriteLine(LoS.GetString(2));
            Console.WriteLine(middle);
            Console.WriteLine(String.Format("s={0}, i={1}", s, i));
            Console.ReadKey();
        }
    }

}
