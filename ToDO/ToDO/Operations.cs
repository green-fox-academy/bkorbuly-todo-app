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

        public static void PrintOutList(List<string> todolist, int original)
        {
            string text;
            AddNumbers(todolist, original);
            for (int i = 0; i < todolist.Count; i++)
            {
                Console.WriteLine(text = todolist[i]);
            }
        }

        public static List<string> AddNumbers(List<string> todolist, int original)
        {
            for (int i = 0; i < todolist.Count; i++)
            {
                if ((original != todolist.Count) && (char.IsDigit(todolist[i][0])))
                {
                    todolist[i] = todolist[i].Substring(todolist[i].IndexOf('-'));
                    todolist[i] = todolist[i].Insert(0, (i + 1) + " ");
                }
                else if (!char.IsDigit(todolist[i][0]))
                {
                    todolist[i] = todolist[i].Insert(0, (i + 1) + " - [ ] ");
                }
            }
            return todolist;
        }

        public static int Counter(List<string> todolist)
        {
            counter = todolist.Count;
            return counter;
        }

        public static bool Errorhandling(string[] arg, int listlength, List<string> dolist, string text)
        {
            int num = arg.Count();
            if (num == 1)
            {
                Console.WriteLine("Unable to {0}: no index provided", text);
                return false;
            }
            else
            {
                try
                {
                    int convert = Convert.ToInt32(arg[1]);
                    if ( listlength < convert)
                    {
                        Console.WriteLine("Unable to {0}: index is out of bound", text);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to {0}: index is not a number", text);
                    return false;
                }
            }
        }

        public static void Check(int num, List<string> dolist)
        {
           dolist[num - 1] = dolist[num - 1].Replace("[ ]", "[x]");
        }
    }
}
