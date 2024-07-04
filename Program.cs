using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CS1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            list.Add(1);
            list.Add(22);
            list.Add(333);
            list.Add(4444);
            list.Add(55555);
            list.Add(666666);
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadLine();
        }
    }
}
