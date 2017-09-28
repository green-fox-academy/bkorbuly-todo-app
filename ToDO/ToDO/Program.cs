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
            string text;
            var dolist = new List<string>();
            {
                dolist.Add("Walk the dog");
                dolist.Add("Buy milk");
                dolist.Add("Do homework");
            }
            if (args.Length == 0)
                WelcomeMsgWithoutArguments();
            File.CreateFile();
            dolist = File.Read();
            File.WriteToFile(dolist);
            Console.ReadLine();
        }

        public static void WelcomeMsgWithoutArguments()
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
