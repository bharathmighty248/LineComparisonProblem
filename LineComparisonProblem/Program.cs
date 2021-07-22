using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Length line1 = new Length(3, 2, 7, 5);
            Length line2 = new Length(3, 2, 8, 5);
            int line1Length = Convert.ToInt32(line1.CalculateLength());
            int line2Length = Convert.ToInt32(line2.CalculateLength());
            if (line1Length.CompareTo(line2Length) >0)
                Console.WriteLine("Line 1 is Greaterthan Line 2");
            else if (line1Length.CompareTo(line2Length) < 0)
                Console.WriteLine("Line 1 is Lessthan Line 2");
            else
                Console.WriteLine("Both Lines are Equal");
        }
    }
}
