using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using operators_Library;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(1,2);
            Fraction b = new Fraction(3,7);
            Fraction suma = a + b;
            Fraction difference = a - b;
            Fraction product = a * b;
            Fraction fraction = a / b;
            Console.WriteLine($"a + b = {suma.ToString()}");
            Console.WriteLine($"a - b = {difference.ToString()}");
            Console.WriteLine($"a * b = {product.ToString()}");
            Console.WriteLine($"a / b = {fraction.ToString()}");
            if (a==b)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
