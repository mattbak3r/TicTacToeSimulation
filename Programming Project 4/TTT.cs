using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project_4
{
    class TTT
    {
        public int[,] Play()
        {
            int[,] game = new int[3, 3];
            Random r = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    game[i, j] = r.Next(0, 2);
                }
            }
            return game;
        }
    }
}
