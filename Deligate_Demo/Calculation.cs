using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deligate_Demo
{ 

    public delegate int   MyDeligate(int x,int y);
    public  class Calculation
    {
        public int Addition(int a,int b)
        {
            return a + b;
        }
    }
    public delegate void Delegate1(int id, string name, double sallary);

    public class Test
    {
        public void AcceptDetails(int id,string name, double sallary)
        {
            Console.WriteLine($"{id} {name} {sallary}");    
        }
    }
}   

