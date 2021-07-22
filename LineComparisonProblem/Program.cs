using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Length line = new Length(3, 2, 7, 5);
            int lineLength = Convert.ToInt32(line.CalculateLength());
            Console.WriteLine("Length of the line: " + lineLength);
        }
    }
}
