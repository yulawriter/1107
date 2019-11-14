using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //int choose = 0;
            IGame game = null;
            Console.WriteLine("請輸入1或2");
            int result = GameHelper.GetInt(1,2);
            //string input = Console.ReadLine();
            //int result = int.Parse(input);
            switch(result)
            {
                case 1:
                    game = new HanoiGame();
                    break;
                case 2:
                    game = new GuessGame();
                    break;
            }
            /*
            if (choose == 1)
            {
                game = new HanoiGame();      
            }
            if(choose == 2)
            {
                game = new GuessGame();      
            }
            */
            game.Setup();
            game.Play();

            Console.ReadKey();
        }
    }
}
