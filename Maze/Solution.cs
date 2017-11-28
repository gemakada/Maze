using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Solution
    {
        private Maze maze;
        private List<Path> listPath = new List<Path>();
        private struct parsed
        {
            public int x;
            public int y;
        }

      
        List<parsed> list = new List<parsed>();
        

        public Solution(Maze maze)
        {
            this.maze = maze;
         
        }


        public Boolean Solve(int x, int y)
        {
            String sol_txt;
           if( (x > maze.getx()-1) || (y > maze.gety() - 1) || (x < 0) || (y < 0))
            {
                return false;
            }
            parsed position = new parsed();
            position.x = x;
            position.y = y;
            //Console.Write(x + "," +y);


            int res = list.FindIndex(parsed => ((parsed.x == x) && (parsed.y==y)));
            if ((res>=0)|| (x > maze.getx() - 1) || (y> maze.gety() - 1) ||(x<0)||(y<0))
            {
               

                return false;
            }
            else
            {
                list.Add(position);
            }
            //Console.Write(res);
            




            if (maze.getItem(x, y) == 'G')
            {
                sol_txt = "(" + x.ToString() + ":" + y.ToString() + "(G))  ";
                listPath.Add(new Path(x, y, sol_txt));
                return true;
            }
            if (maze.getItem(x,y)=='X')
            {
                return false;
            }
            else
            {
                if (Solve(x, y + 1))
                {
                    if (maze.getItem(x, y) == 'S')
                    {
                        sol_txt = "(" + x.ToString() + ":" + y.ToString() + "(S))  ";
                        listPath.Add(new Path(x, y, sol_txt));
                    }
                    else
                    {
                        sol_txt = ", (" + x.ToString() + ":" + y.ToString() + ")  ";
                        listPath.Add(new Path(x, y, sol_txt));
                    }
                    return true;
                }
                if (Solve(x+1,y))
                {
                    if (maze.getItem(x, y) == 'S')
                    {
                        sol_txt = "(" + x.ToString() + ":" + y.ToString() + "(S))  ";
                        listPath.Add(new Path(x, y, sol_txt));
                    }
                    else
                    {
                        sol_txt = ", (" + x.ToString() + ":" + y.ToString() + ")  ";
                        listPath.Add(new Path(x, y, sol_txt));
                    }
                    return true;
                }
                if (Solve (x-1,y))
                {
                    if (maze.getItem(x, y) == 'S')
                    {
                        sol_txt = "(" + x.ToString() + ":" + y.ToString() + "(S))  ";
                        listPath.Add(new Path(x, y, sol_txt));
                    }
                    else
                    {
                        sol_txt = ", (" + x.ToString() + ":" + y.ToString() + ")  ";
                        listPath.Add(new Path(x, y, sol_txt));
                    }
                    return true;
                }
              
                if (Solve(x, y-1))
                {
                    if (maze.getItem(x, y) == 'S')
                    {
                        sol_txt = "(" + x.ToString() + ":" + y.ToString() + "(S))  ";
                        listPath.Add(new Path(x, y, sol_txt));
                    }
                    else
                    {
                        sol_txt = ", (" + x.ToString() + ":" + y.ToString() + ")  ";
                        listPath.Add(new Path(x, y, sol_txt));
                    }
                    return true;
                }




                return false;
            }


        }

        public List<Path> getPath()
        {

            listPath.Reverse();
            return listPath;
        }
    }
}
