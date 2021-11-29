using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    internal class UC5_Snake
    {
        public static int PlayerPosition = 0;
        public void ExactWinning()
        {
            int No_Play = 0;
            int ladder = 1;
            int snake = 2;
            int exactwinningposition = 100;
            Console.WriteLine("The start position of player is : " + PlayerPosition);
            Console.WriteLine();
            Random ranval = new Random();
            while (PlayerPosition < exactwinningposition)
            {
                while (PlayerPosition != exactwinningposition)
                {
                    int diceroll = ranval.Next(1, 7);
                    int check_play = ranval.Next(3);
                    {
                        switch (check_play)
                        {
                            case 1:
                                PlayerPosition += diceroll;
                                if (PlayerPosition > exactwinningposition)
                                {
                                    PlayerPosition = exactwinningposition;
                                    PlayerPosition -= diceroll;
                                }
                                Console.WriteLine("U got Ladder and your position is: " + PlayerPosition);
                                break;
                            case 2:
                                PlayerPosition -= diceroll;
                                if (PlayerPosition < 0)
                                {
                                    PlayerPosition = 0;
                                }
                                Console.WriteLine("U got Snake and your position is: " + PlayerPosition);
                                break;
                            case 0:
                                Console.WriteLine("No Play and your position is: " + PlayerPosition);
                                break;
                        }
                    }
                    Console.WriteLine("New position is= " + PlayerPosition);
                }
                Console.WriteLine("********************************************");
                Console.WriteLine("U arrived at the Finish Point");

            }
        }

    }
}
