using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class ParameterezettSzal
    {
        public void ValameddigSzamol(object meddig)
        {
            var eddig = (int)meddig;
            Console.Write($"\n Elszámolok {eddig}-ig!");
            for (int i = 0; i < eddig; i++)
            {
                Console.Write('.');
                Thread.Sleep(1000);
            }
            Console.Write($"\n {eddig}");
        } 
    }
}
