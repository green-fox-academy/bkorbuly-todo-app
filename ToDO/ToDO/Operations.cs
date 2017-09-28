using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDO
{
    class Operations
    {
        static int counter = 0;
        static List<string> todolist = new List<string>();

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

        public static void PrintOutList(List<string> todolist)
        {
            string text;
            AddNumbers(todolist);
            for (int i = 0; i < todolist.Count; i++)
            {
                Console.WriteLine(text = todolist[i]);
            }
        }

        public static List<string> AddNumbers(List<string> todolist)
        {
            for (int i = 0; i < todolist.Count; i++)
            {
                if(!char.IsDigit(todolist[i][0]))
                todolist[i] = todolist[i].Insert(0, (i + 1) + " - [ ] ");
            }
            return todolist;
        }

        public static int Counter(List<string> todolist)
        {
            counter = todolist.Count;
            return counter;
        }

        public static void RemoveParamater(string[] arg, int listlength, List<string> dolist)
        {
            int num = arg.Count();
            if (num == 1)
            {
                Console.WriteLine("Unable to remove: no index provided");
            }
            else
            {
                try
                {
                    int convert = Convert.ToInt32(arg[1]);
                    if (listlength == convert || listlength < convert)
                    {
                        Console.WriteLine("Unable to remove: index is out of bound");
                    }
                    else
                    {
                        dolist.RemoveAt(Convert.ToInt32(arg[1]));
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to remove: index is not a number");
                    return;
                }
            }
        }
    }
}
