using System;
using System.Collections.Generic;

namespace What_i_know
{
    class Program
    {
        static void Main(string[] args)
        {
            
         byte b = 100;
            int i = b;
            Console.WriteLine(i);
            var numbers = new List<int>();
            string s = "1234";
            int u = Convert.ToInt32(s);
            Console.WriteLine(u);
            while (true)
            {
                Console.WriteLine("Enter a name: ");
                var name = Console.ReadLine();
                Console.WriteLine("@Echo: "+ name);

                if (string.IsNullOrWhiteSpace(" "))
                {
                    Console.WriteLine("there is no name!!");
                }
                else;
                {
                    Console.WriteLine("Hello there nice to meet you");
                }

            }
           



        }
    }
}
