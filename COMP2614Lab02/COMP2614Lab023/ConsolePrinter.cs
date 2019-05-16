using System;

namespace COMP2614Lab02
{
    class ConsolePrinter
    {
        public static void PrintMembers(Member[] member)
        {
            Console.WriteLine("{0, -15} {1, -10} {2, 7} {3, 15} ", "FirstName", "LastName", "AgeYears", "AgeDecades");
            Console.WriteLine(new string('-', 51));

            foreach (Member members in member)
            {
                Console.WriteLine("{0, -15} {1, -10} {2, 8} {3, 15:0.0}",
                                        members.FirstName,
                                        members.LastName,
                                        members.Age,
                                        members.AgeInDecades);
            }
            Console.WriteLine("\n");
        }
    }
}
