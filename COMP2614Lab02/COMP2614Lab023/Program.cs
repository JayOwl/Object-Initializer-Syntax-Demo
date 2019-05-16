using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "COMP2614 Lab02";

            Member[] members =
            {
              new Member("Tim", "Conway", 48),
              new Member("Larry", "Sanders", 60),
              new Member("Howard", "Stern", 58),
              new Member("Stern", "Wright", 56),
              new Member("Lewis", "Black", 64)
            };

            ConsolePrinter.PrintMembers(members);
        }
    }
    }

