using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world_inernetional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] HelloWorld = { "hello world", "Hola Mundo", "Ciao mondo", "Привіт Світ", "Hallo Welt" };
            for(int i=0;i<HelloWorld.Length;i++)
            {
                Console.WriteLine(HelloWorld[i]);
            }
            Console.ReadLine();

            Console.WriteLine("First commit done");    

        }
    }
}
