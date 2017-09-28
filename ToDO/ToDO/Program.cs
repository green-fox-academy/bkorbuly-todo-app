using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDO
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            WelcomeMsgWithoutArguments();
            Console.ReadLine();
        }
        static void WelcomeMsgWithoutArguments()
        {
            Console.WriteLine("Command Line Todo application");
            Console.WriteLine("=============================\n");
            Console.WriteLine("Command Line arguments:");
            Console.WriteLine("-l List all the task");
            Console.WriteLine("-a Adds a new task");
            Console.WriteLine("-r Removes a task");
            Console.WriteLine("-c Completes a task");
        }
    }
}
