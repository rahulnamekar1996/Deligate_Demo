using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate_Demo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            MyDeligate myDeligate = new MyDeligate(c.Addition);
            Console.WriteLine(myDeligate.Invoke(20, 30));

            Test t1 = new Test();
            Delegate1 d1 = new Delegate1(t1.AcceptDetails);
            d1.Invoke(1, "rahul", 25000);
        }
    }
}
