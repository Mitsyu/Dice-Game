using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{

    public class Die
    {
        private Random _generator;
        private int _roll;

        public Die()
        {
            _generator = new Random();
            _roll = _generator.Next(1, 7);
        }
        public Die(int roll)
        {
            _generator = new Random();
            if (roll < 1)
                _roll = 1;
            else if (roll > 6)
                _roll = 6;
            else
                _roll = roll;
        }

        public int Roll { get { return _roll; } }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public int RollDie()
        {
            _roll = _generator.Next(1, 7);
            return _roll;

        }

        public void DrawRoll()
        {
            switch(_roll)
            {
                case 1:
                    Console.WriteLine(" ---------");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|    O    |");
                    Console.WriteLine("|         |");
                    Console.WriteLine(" ---------");
                    break;

                case 2:
                    Console.WriteLine(" ---------");
                    Console.WriteLine("|  O      |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|      O  |");
                    Console.WriteLine(" ---------");
                    break;

                case 3:
                    Console.WriteLine(" ---------");
                    Console.WriteLine("|  O      |");
                    Console.WriteLine("|    O    |");
                    Console.WriteLine("|      O  |");
                    Console.WriteLine(" ---------");
                    break;

                case 4:
                    Console.WriteLine(" ---------");
                    Console.WriteLine("|  O   O  |");
                    Console.WriteLine("|         |");
                    Console.WriteLine("|  O   O  |");
                    Console.WriteLine(" ---------");
                    break;

                case 5:
                    Console.WriteLine(" ---------");
                    Console.WriteLine("|  O   O  |");
                    Console.WriteLine("|    O    |");
                    Console.WriteLine("|  O   O  |");
                    Console.WriteLine(" ---------");
                    break;

                case 6:
                    Console.WriteLine(" ---------");
                    Console.WriteLine("|  O   O  |");
                    Console.WriteLine("|  O   O  |");
                    Console.WriteLine("|  O   O  |");
                    Console.WriteLine(" ---------");
                    break;




            }
        }



       
    }

}
   
    

  
