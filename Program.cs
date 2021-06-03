using System;
namespace MyfirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            String s;
            char c;
            Console.WriteLine("Enter the number");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the String");
            s = Console.ReadLine();
            Console.WriteLine("Enter the character");
            c = Convert.ToChar(Console.ReadLine());
            Console.ReadLine();
        }
    }
}
