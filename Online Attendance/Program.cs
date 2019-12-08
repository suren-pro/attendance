using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Attendance
{

     
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            Action action;

            switch (name)
            {
                case "Steven":
                case "Jack":
                 case "Mathew":

                    action = Alarm;

                    break;
                default:
                    action = ()=> Console.WriteLine($"Welcome {name} ");

                    break;

            }

            action();
            Console.ReadKey();
        }

        static void Alarm()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You are banned.Logging out!!!");
            for (int i = 0; i < 5; i++)
            {
                Console.Beep();
            }
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
