using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {



        static bool isPalindrome(String s)
        {
            for(int i=0; i<s.Length; i++)
            {
                if (!(s.ElementAt(i) == s.ElementAt(s.Length - i - 1)))
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld");
            Cat ourCat = new Cat();
            Console.WriteLine("The cat says " + ourCat.getSound());
            Console.WriteLine("The cats tail is " + ourCat.getTailLength() + " inches long");
            String s; 
            bool b;
            while (true)
            {
                Console.WriteLine("Enter a string");
               s= Console.ReadLine();
                b = isPalindrome(s);
                Console.Write(s);
                if (b)
                    Console.WriteLine(" is a Palindrome");
                else
                    Console.WriteLine(" is not a Palindrome");
            }

        }
    }
}
