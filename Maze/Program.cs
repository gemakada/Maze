using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Program
    {
        static void Main(string[] args)
        {
            int size1;
            int size2;
            int start_X;
            int start_y;
            Boolean result;
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");
            String path = "";
            List<Path> listPath = new List<Path>();


            size1 = lines.Length;
            size2 = lines[0].Length;




            Maze x = new Maze(size1, size2, lines);

            for (int i = 0; i < size1; i++)
            {
                for (int j = 0; j < size2; j++)
                {
                    Console.Write(x.getItem(i, j));
                }
                Console.Write("\n");
            }


            //Console.WriteLine(x.getItem());
            start_X = x.getstart_x();
            start_y = x.getstart_y();
            if (start_X != -1 && start_y != -1)
            {
                Solution sol = new Solution(x);
                // Console.WriteLine(x.getstart_x() + " "+x.getstart_y());
                result = sol.Solve(x.getstart_x(), x.getstart_y());
                if (result)
                {
                    listPath = sol.getPath();
                    for (int i = 0; i < listPath.Count; i++)
                    {
                        path = path + listPath[i].getStr();
                    }


                }
                Console.WriteLine(path);
                Console.Write(result);

                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No Starting Point Found");
                Console.ReadLine();
            }
        }
    }
}
