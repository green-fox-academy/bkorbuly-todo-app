using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDO
{
    class File
    {
        static string filename = @"C:\Users\Balazs\Greenfox_misc\ToDO\ToDO\obj\Debug\text.txt";
        public static List<string> filecontain = new List<string>();

        public static void CreateFile()
        {
            if (System.IO.File.Exists(filename) != true)
            {
                System.IO.File.CreateText(filename);
            }
        }

        public static List<string> Read()
        {
            try
            {
                string line;
                using (var read = new StreamReader(filename))
                {
                    line = read.ReadLine();
                    while ((line = read.ReadLine()) != null)
                    {
                        filecontain.Add(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                CreateFile();
                Read();
            }
            return filecontain;
        }

        public static void WriteToFile(List<string> todolist)
        {
            try
            {
                using (var write = new StreamWriter(filename))
                {
                    for (int i = 0; i < todolist.Count; i++)
                    {
                        write.WriteLine(todolist[i]);
                    }                
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
