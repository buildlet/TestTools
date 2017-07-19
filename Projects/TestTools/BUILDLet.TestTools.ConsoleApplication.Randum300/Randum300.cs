using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;


namespace BUILDLet.TestTools.ConsoleApplication.Randum300
{
    class Randum300
    {
        static void Main(string[] args)
        {
            Random rand = new Random();


            for (int i = 1; i <= 300; i++)
            {
                Thread.Sleep(1);

                if (rand.Next(2) % 2 == 0) { Console.WriteLine(i); }
                else { Console.Error.WriteLine(i); }                
            }
        }
    }
}
