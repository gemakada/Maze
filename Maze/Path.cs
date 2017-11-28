using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze
{
    class Path
    {
        private int x;
        private int y;
        private String str;

        public Path(int x, int y, String str)
        {
            this.x = x;
            this.y = y;
            this.str = str;
        }


       public String getStr()
        {
            return this.str;
        }



    }

  




}
