using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    internal class AdvanceConcepts
    {
        public delegate void MyDelegate();
        public static void DemoDelegate()
        {
            MyDelegate delObj = new MyDelegate(DemoGenerics);
            delObj();
        }
        public static void DemoGenerics()
        {
            Service<int> a = new Service<int>();
            bool b = a.Compare(10, 10);

            Service<string> c = new Service<string>();
            bool d = c.Compare("Helo", "Hello");
        }
    }

    class Service<PlaceHolder>
    {
        public bool Compare(PlaceHolder obj1, PlaceHolder obj2)
        {
            return obj1.Equals(obj2);
        }
    }
}
