using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;


namespace BUILDLet.TestTools.ConsoleApplication.StdOut300
{
    class StandardOutput300
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 300; i++)
            {
                Thread.Sleep(1);

                Console.WriteLine(i);
            }
        }
    }
}
