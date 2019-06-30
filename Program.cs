using System;
using System.Collections.Generic;

namespace IsUnique
{
    class Program
    {
        public static int IsUnique(List<char> c)
        {
            int flag = 0;
            if (c.Count == 1)
                return flag;
            while (c.Count >= 2)
            {
                if (flag == 1)
                    return flag;
                char bruteForce = c[0];
                c.RemoveAt(0);

                if (c.Contains(bruteForce))
                {
                    Console.WriteLine("Got em");
                    flag++;
                }
                Console.WriteLine(flag);

            }
            return flag;
        }

        static void Main(string[] args)
        {
            
            List<char> userInput = new List<char>();
            userInput.AddRange(Console.ReadLine());
            int flags = IsUnique(userInput);
            
            if (flags == 0)
                Console.WriteLine("The string contains unique characters");
            else
                Console.WriteLine("The string does not contain unique characters");
            
                
            
            Console.ReadKey();
        }
    }
}
