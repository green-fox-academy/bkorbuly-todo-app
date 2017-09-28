using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDO
{
    class Program
    {
        static string[] array = new string[] { "-a",  "\"Monkey\"" };
        static void Main(string[] args)
        {
            string text;
            var dolist = new List<string>();
            dolist = File.Read();
            if (args.Length == 0)
                Operations.WelcomeMsgWithoutArguments();
            string arg = args[0];
            switch (arg)
                {
                    case "-l":
                        if (Operations.Counter(dolist) > 0)
                        {
                            Operations.PrintOutList(Operations.AddNumbers(dolist));
                        }
                        else
                        {
                            Console.WriteLine("No todos for today!");
                        }
                        break;
                    case "-a":
                        if (arg.Length > 0)
                        {
                            Console.WriteLine(args[0]);
                            Operations.AddElement(args[1]);
                            File.WriteToFile(dolist);
                        }
                        else
                        {
                            Console.WriteLine("Unable to add: no task provided");
                        }
                        break;
                }
            Console.ReadLine();
        }
    }
}
