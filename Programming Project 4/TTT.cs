using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Project_4
{
    class TTT
    {
        //returns int array with 0's and 1's. x = 1 and o = 0
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

        //returns char O or X depending on value
        public char Interpret(int num)
        {
            char p;
            
            if (num == 1)
            {
                p = 'X';
            }
            else
            {
                p = 'O';
            }
            return p;
        }

        //int returned determines winner, tie = 2, x = 1, o = 0
        public int Results(int[,] game)
        {
            var winner = 2;
            var x_winner = false;
            var o_winner = false;

            //check is 'x' is the winner
            if (game[0,0] == 1 && game[0,1] == 1 && game[0,2] == 1)
            {
                x_winner = true;
            }
            else if (game[1, 0] == 1 && game[1, 1] == 1 && game[1, 2] == 1)
            {
                x_winner = true;
            }
            else if (game[2, 0] == 1 && game[2, 1] == 1 && game[2, 2] == 1)
            {
                x_winner = true;
            }
            else if (game[0, 0] == 1 && game[1, 0] == 1 && game[2, 0] == 1)
            {
                x_winner = true;
            }
            else if (game[0, 1] == 1 && game[1, 1] == 1 && game[2, 1] == 1)
            {
                x_winner = true;
            }
            else if (game[0, 2] == 1 && game[1, 2] == 1 && game[2, 2] == 1)
            {
                x_winner = true;
            }
            else if (game[0, 0] == 1 && game[1, 1] == 1 && game[2, 2] == 1)
            {
                x_winner = true;
            }
            else if (game[2, 2] == 1 && game[1, 1] == 1 && game[0, 0] == 1)
            {
                x_winner = true;
            }

            //check if 'o' is the winner
            if (game[0, 0] == 0 && game[0, 1] == 0 && game[0, 2] == 0)
            {
                o_winner = true;
            }
            else if (game[1, 0] == 0 && game[1, 1] == 0 && game[1, 2] == 0)
            {
                o_winner = true;
            }
            else if (game[2, 0] == 0 && game[2, 1] == 0 && game[2, 2] == 0)
            {
                o_winner = true;
            }
            else if (game[0, 0] == 0 && game[1, 0] == 0 && game[2, 0] == 0)
            {
                o_winner = true;
            }
            else if (game[0, 1] == 0 && game[1, 1] == 0 && game[2, 1] == 0)
            {
                o_winner = true;
            }
            else if (game[0, 2] == 0 && game[1, 2] == 0 && game[2, 2] == 0)
            {
                o_winner = true;
            }
            else if (game[0, 0] == 0 && game[1, 1] == 0 && game[2, 2] == 0)
            {
                o_winner = true;
            }
            else if (game[2, 2] == 0 && game[1, 1] == 0 && game[0, 0] == 0)
            {
                o_winner = true;
            }

            //if both x and have three in a row, its a draw game
            if (x_winner && o_winner)
            {
                winner = 2;
            }
            else if (x_winner && !o_winner)
            {
                winner = 1;
            }
            else if (!x_winner && o_winner)
            {
                winner = 0;
            }
            return winner;
        }
    }
}
