using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            FourOperations fourOperations = new FourOperations();
            Console.WriteLine("6 + 9 = " + fourOperations.Collect(6,9));
        }
    }
}
