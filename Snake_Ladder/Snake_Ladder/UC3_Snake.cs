using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    internal class UC3_Snake
    {
        public void PositionCheck()
        {
            int no_Play = 0;
            int ladder = 1;
            int snake = 2;
            //variables
            int playerPosition = 0;
            Random ran = new Random();
            int optionCheck = ran.Next(0, 3);
            int diceValue = ran.Next(0, 7);

            switch (optionCheck)
            {
                case 0:
                    Console.WriteLine("No play, pass the dice");
                    break;
                case 1:
                    playerPosition += diceValue;
                    Console.WriteLine("You got ladder " + "and your position is now: " + playerPosition);
                    break;
                case 2:
                    if (playerPosition <= 0)
                    {
                        Console.WriteLine("U got snake but");
                        Console.WriteLine("You are still in Zero(0) position");
                    }
                    break;
            }
        }
    }
}
