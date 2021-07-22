using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Length line1 = new Length(3, 2, 7, 5);
            Length line2 = new Length(3, 2, 7, 5);
            int line1Length = Convert.ToInt32(line1.CalculateLength());
            int line2Length = Convert.ToInt32(line2.CalculateLength());
            if (line1Length.Equals(line2Length))
                Console.WriteLine("Both Lines are Equal");
            else
                Console.WriteLine("Both Lines are Not Equal");
        }
    }
}
