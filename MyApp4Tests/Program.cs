using MyApp4Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp4Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            VisibleBotMethods vbm = new VisibleBotMethods();
            String Message1 = vbm.SayHiTo("Bren");
            String Message2 = vbm.SayByeTo("Bren");
            Console.WriteLine("Here is your Message: " + Message1);
            Console.WriteLine("Here is your other Message: " + Message2);
            Console.ReadKey();

        }
    }
}
