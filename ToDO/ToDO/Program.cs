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
            var dolist = new List<string>();
            dolist = File.Read();
            int original = dolist.Count;
            if (args.Length == 0)
                Operations.WelcomeMsgWithoutArguments();
            string arg = args[0];
            switch (arg)
                {
                    case "-l":
                        if (Operations.Counter(dolist) > 0)
                        {
                            Operations.PrintOutList(dolist, original);
                        }
                        else
                        {
                            Console.WriteLine("No todos for today!");
                        }
                    break;

                    case "-a":
                        if (arg.Length > 0)
                        {
                            dolist.Add(args[1]);
                        }
                        else
                        {
                            Console.WriteLine("Unable to add: no task provided");
                        }
                    break;

                    case "-r":
                    {
                        if(Operations.Errorhandling(args, dolist.Count, dolist, "remove"))
                            {
                            int nums = Convert.ToInt32(args[1]);
                            dolist.RemoveAt(nums - 1);
                            }
                    }
                    break;

                    case "-c":
                    {
                        if (Operations.Errorhandling(args, dolist.Count, dolist, "check"))
                        {
                            int nums = Convert.ToInt32(args[1]);
                            Operations.Check(nums, dolist);
                        }
                    }
                    break;

                    default:
                        {
                            Console.WriteLine("Unsupported argument");
                        }
                    break;
                }
            Operations.PrintOutList(dolist, original);
            File.WriteToFile(dolist);
            Console.ReadLine();
        }
    }
}