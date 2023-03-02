namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int bankAccount = 100;
            int betAmount;
            

            Console.WriteLine("Welcome to the Casino");

            while (bankAccount > 0)
            {
                Console.WriteLine("");
                betAmount = Convert.ToInt32(Console.ReadLine());    

                if (betAmount == 0)
                {
                    break;
                }

    
                if (betAmount > bankAccount)
                {
                    Console.WriteLine("Not enough money, you have:", bankAccount);
                    continue;
                }

                Console.WriteLine("Rolling dice.....");
                Die die1 = new Die();
                Die die2 = new Die();
               
                die1.DrawRoll();
                die2.DrawRoll();

                Console.WriteLine(die1);
                Console.WriteLine(die2);

            }
        }
    }
}