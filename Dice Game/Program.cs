using System;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Die die1 = new Die();
            Die die2 = new Die();
            double bankAccount = 100.00;
            double betAmount;
            
            Console.WriteLine("Welcome to the Dice Game");
            Thread.Sleep(500);
            Console.WriteLine();

            while (bankAccount > 0)
            {
                Console.ResetColor();
                Console.WriteLine("Choose an outcome: ");
                Console.WriteLine("1. Doubles");
                Console.WriteLine("2. Not double");
                Console.WriteLine("3. Even sum");
                Console.WriteLine("4. Odd sum");
                Console.Write("Enter choice (1-4): ");
                
                int choice = Convert.ToInt32(Console.ReadLine());   

                if (choice < 1 || choice > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invaild Outcome. Choose from choices (1-4).");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("Enter bet amount: ");
                betAmount = Convert.ToInt32(Console.ReadLine());    

                if (betAmount == 0)
                {
                    break;
                }

                if (betAmount > bankAccount)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not enough money, you only have: $" + bankAccount + " in your bank account.");
                    Console.WriteLine();
                    continue;
                }


                Console.WriteLine("Rolling Dice...");
                Thread.Sleep(800);

                int roll1 = die1.RollDie();
                int roll2 = die2.RollDie();
                int total = roll1 + roll2;

                Console.WriteLine();

                Console.WriteLine("You rolled a... ", roll1, roll2);
                Thread.Sleep(500);
                
                die1.DrawRoll();
                die2.DrawRoll();

                bool sumDoubles = (roll1 == roll2);
                bool sumEven = (total % 2 == 0);
                double winnings = 0.00;

                switch (choice)
                {
                    
                    case 0:
                        if (sumDoubles)
                        {
                            winnings = betAmount * 2;
                            bankAccount += winnings;
                            Console.WriteLine("You won ${0.f2}");
                        }
                        break;

                    case 1:
                        if (sumEven)
                        {

                        }
                        break;

                    case 2:
                        if (sumEven)
                        {

                        }
                        break;

                }

                if (total == choice)
                {
                    Console.WriteLine("You won" + (betAmount * 2));
                    bankAccount -= betAmount;

                }
               
                Console.WriteLine("You have $" + bankAccount + " in your bank account");

            }
        }
    }
}