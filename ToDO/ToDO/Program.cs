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
                            dolist.Add(args[1]);
                            
                        }
                        else
                        {
                            Console.WriteLine("Unable to add: no task provided");
                        }
                    break;
                    case "-r":
                        {
                            Operations.RemoveParamater(args, dolist.Count, dolist);
                        }
    
                    break;
                }
            File.WriteToFile(dolist);
            Console.ReadLine();
        }
    }
}
