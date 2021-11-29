using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Ladder
{
    internal class UC7_Snake
    {
        public void TwoPlayer()
        {
            int max = 100;
            int Player1 = 0;
            int Player2 = 0;
            int StartPosition = 0;
            const int snake = 1;
            const int ladder = 2;
            int[] playerRecord1 = new int[100];
            int[] playerRecord2 = new int[100];

            while (Player1 < max && Player2 < max)
            {
                Random random = new Random();
                int m = random.Next(0, 2);
                playerMove(m);

                if (Player1 == max)
                    Console.WriteLine("Player1 is the Winner");
                if (Player2 == max)
                    Console.WriteLine("Player2 is the Winner");

            }

            int RollDice()
            {
                Random random = new Random();
                int diceValue = random.Next(1, 7);
                return diceValue;
            }

            int conditionCheck(int position, int dieNo)
            {
                position = position;

                if (position < StartPosition)
                {
                    position = 0;
                }
                if (position > max)
                {
                    position = position - dieNo;
                }
                else position = position;
                return position;
            }
            void playerMove(int num)
            {
                int dieNo = RollDice();
                int flag = num;
                int playerPosition = 0;

                Random random = new Random();
                int option = random.Next(0, 3);
                Console.WriteLine("Dice Option is : " + option);

                if (option == snake)

                    playerPosition = playerPosition - dieNo;

                else if (option == ladder)
                    playerPosition = playerPosition + dieNo;
                else
                    playerPosition = playerPosition;


                if (flag == 0)
                {
                    Player1 = Player1 + playerPosition;
                    Player1 = conditionCheck(Player1, dieNo);
                    playerRecord1[dieNo] = Player1;
                }
                if (flag == 1)
                {
                    Player2 = Player2 + playerPosition;
                    Player2 = conditionCheck(Player2, dieNo);
                    playerRecord2[dieNo] = Player2;
                }

            }
        }
    }
}
