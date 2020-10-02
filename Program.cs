using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IOd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in some text");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\Ryan\Desktop\Coding", text);
            string textr = File.ReadAllText(@"C:\Users\Ryan\Desktop\Coding\ some.txt");
            Console.WriteLine(textr);
            Console.ReadLine();
        }
    }
}
