using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bismillahir Rahmanir Rahim.");
            Console.WriteLine("\n" + "Type Your Name Please: ");
            string name = "";
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name + ". Nice to meet you.");
            string contact;
            Console.WriteLine("your contact number please: ");
            contact = (Console.ReadLine());
            Console.WriteLine("Can I save your number " + contact + "?" + "\n" + "Thanks!!");
            Console.WriteLine("Now, give me two numbers to add ok? The first number is: ");
            int num1, num2, sum;
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The second number is: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num2 + num1;
            Console.WriteLine("The sum is: " + sum + ". Thank you..");

            Console.ReadKey();
        }
    }
}
