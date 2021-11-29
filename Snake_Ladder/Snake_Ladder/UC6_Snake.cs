using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    internal class UC6_Snake
    {
        public static int PlayerPosition = 0;
        const int No_Play = 0;
        const int ladder = 1;
        const int snake = 2;
        public void TimesPlayed()
        {
            int counter = 0;
            int exactwinningposition = 100;
            Random ranval = new Random();
            while (PlayerPosition < exactwinningposition)
            {
                while (PlayerPosition != exactwinningposition)
                {
                    int diceroll = ranval.Next(1, 7);
                    counter++;
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
                                break;
                            case 2:
                                PlayerPosition -= diceroll;
                                if (PlayerPosition < 0)
                                {
                                    PlayerPosition = 0;
                                }
                                break;
                            case 0:
                                break;
                        }
                    }
                }
                Console.WriteLine("U arrived at the Finish Point: " + PlayerPosition);
                Console.WriteLine("The number of times the dice played is: " + counter);
            }
        }
    }
}
