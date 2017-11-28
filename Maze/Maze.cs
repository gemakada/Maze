using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Maze
    {
        private char[,] maze;
        private int mazex;
        private int mazey;
        private int startx=-1;
        private int starty=-1;

        public Maze(int dimx, int dimy, String[] data)
        {
            this.maze = new char[dimx, dimy];
            this.mazex = dimx;
            this.mazey = dimy;

            int i;
            int j;

            for (i=0; i< dimx; i++)
            {
                for (j=0; j< dimy; j++)
                {
                    maze[i, j] = '_';
                }
            }

            for (i=0; i<data.Length; i++)
            {
                for (j = 0; j < data[i].Length; j++)
                {
                    if (data[i][j]!='_')
                    {
                        maze[i, j] = data[i][j];
                    }
                }
            }

            for (i = 0; i < mazex; i++)
            {
                for (j = 0; j <mazey; j++)
                {
                    if (maze[i,j] == 'S')
                    {
                        startx = i;
                        starty = j;
                        break;
                    }
                }
            }
           
            


            // maze[0, 0] = 'S';
            //  maze[0, 4] = '|';
            //   maze[1, 2] = '|';
            //   maze[1, 3] = '|';
            //   maze[2, 2] = '|';
            //   maze[2, 2] = '|';
            //   maze[3, 1] = '|';
            //  maze[4, 3] = '|';
            //   maze[1,4] = 'G';


        }

        public char getItem(int x, int y)
        {
            return maze[x, y];
        }

        public int getx()
        {
            return this.mazex;
        }
        public int gety()
        {
            return this.mazey;
        }

        public int getstart_x()
        {
            return this.startx;
        }
        public int getstart_y()
        {
            return this.starty;
        }

    }
}
