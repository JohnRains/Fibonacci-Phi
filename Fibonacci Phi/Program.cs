using ExtendedNumerics;
using System;

namespace Fibonacci_Phi
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 =2;
            ulong num2 = 3;
            ulong newNum;
            decimal phi = 1M;
            decimal phiOld;
            int x = 4;
            do
            {
                phiOld = phi;
                newNum = num1 + num2;
                phi = (decimal)num2 / num1;
                Console.WriteLine($"{x}: {num1}, {num2},{phi}\n");
                num1 = num2;
                num2 = newNum;
                x++;
            } while ((phiOld != phi));
            Console.WriteLine("Hit Enter to continue");
            Console.ReadLine();

        }
    }
}
