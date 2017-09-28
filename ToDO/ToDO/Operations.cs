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
            for (int i = 0; i < todolist.Count; i++)
            {
                Console.WriteLine(text = todolist[i]);
            }
        }

        public static List<string> AddNumbers(List<string> todolist)
        {
            for (int i = 0; i < todolist.Count; i++)
            {
                todolist[i] = todolist[i].Insert(0, (i + 1) + " - ");
            }
            return todolist;
        }

        public static int Counter(List<string> todolist)
        {
            counter = todolist.Count;
            return counter;
        }

        public static List<string> AddElement(string text)
        {
            todolist.Add(text = text.Substring(text.IndexOf('"')));
            return todolist;
        }

    }
}
