using System;
using System.Reflection.Metadata.Ecma335;

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

            Console.WriteLine($"You have ${bankAccount} in your bank account");
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
                Console.Write("Enter bet amount: ");
                betAmount = Convert.ToInt32(Console.ReadLine());    

                if (betAmount == 0)
                {
                    break;
                }

                if (betAmount > bankAccount)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Not enough money, you only have ${bankAccount} in your bank account.");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("Rolling Dice...");
                Thread.Sleep(800);

                int roll1 = die1.RollDie();
                int roll2 = die2.RollDie();
                int total = roll1 + roll2;

                Console.WriteLine();

                Console.WriteLine($"You rolled a {roll1} and {roll2}");

                Thread.Sleep(500);
                
                die1.DrawRoll();
                die2.DrawRoll();

                double winnings = 0.00;

                switch (choice)
                {

                    case 1:
                        if (choice == 1 && roll1 == roll2)
                        {
                            winnings = betAmount * 2;
                            bankAccount += winnings;
                            Console.WriteLine($"You won ${winnings} !!!");
                            Console.WriteLine();
                            Console.WriteLine($"You have ${bankAccount} in your bank account");
                        }
                        
                        else 
                        {
                            Console.WriteLine($"You lost ${betAmount}");
                            bankAccount -= betAmount;
                            Console.WriteLine();
                            Console.WriteLine($"You now have ${bankAccount} in your bank account");
                        }
                        break;
     
                    case 2:
                        if (choice == 2 && roll1 == roll2)
                        {
                            Console.WriteLine($"You lost ${betAmount}");
                            bankAccount -= betAmount;
                            Console.WriteLine();
                            Console.WriteLine($"You now have ${bankAccount} in your bank account");
                        }
                        else
                        {
                            winnings = betAmount / 2;
                            bankAccount += winnings;
                            Console.WriteLine($"Woohoo! You won ${winnings} !!");
                            Console.WriteLine();
                            Console.WriteLine($"You have ${bankAccount} in your bank account");
                        }
                        break;

                    case 3:
                        if(choice == 3 && total % 2 == 0)
                        {
                            winnings += betAmount;
                            Console.WriteLine("WooHoo! You won $" + betAmount + ".");
                            Console.WriteLine();
                            Console.WriteLine($"You have ${bankAccount} in your bank account");
                        }
                        else
                        {
                            Console.WriteLine($"You lost ${betAmount}");
                            bankAccount -= betAmount;
                            Console.WriteLine();
                            Console.WriteLine($"You now have ${bankAccount} in your bank account");
                        }
                        break;

                    case 4:
                        if(choice == 4 && total % 2 != 0)
                        {
                            winnings += betAmount;
                            Console.WriteLine($"Woohoo! You won ${winnings} !!");
                            Console.WriteLine();
                            Console.WriteLine($"You have ${bankAccount} in your bank account");
                        }
                        else
                        {
                            Console.WriteLine($"You lost ${betAmount}");
                            bankAccount -= betAmount;
                            Console.WriteLine();
                            Console.WriteLine($"You now have ${bankAccount} in your bank account");
                        }
                        break;

                }

                if (total == choice)
                {
                    Console.WriteLine("You won" + (betAmount * 2));
                    bankAccount -= betAmount;

                }

                if (bankAccount <= 0)
                {
                    Console.WriteLine("GAME OVER. You have no more money to bet");
                    Console.WriteLine();
                    Console.Write("Add more money to bank account and play again? (y/n):");
                    string tryAgain = Console.ReadLine();
                    Console.WriteLine();

                    switch (tryAgain)
                    {
                        case "y":
                            Console.Write("Enter deposit amount: ");
                            double depositAmount = double.Parse(Console.ReadLine());
                            bankAccount += depositAmount;
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.WriteLine($"You now have ${bankAccount} in your bank account");
                            break;

                        case "n":
                            Console.WriteLine();
                            Console.WriteLine("See you next time.");
                            break;

                    }
                  
                    
                }

                Console.WriteLine();

            }
        }
    }
}