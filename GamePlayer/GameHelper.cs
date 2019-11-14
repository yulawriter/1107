using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    public class GameHelper
    {
        public static int GetInt(int min,int Max)
        {
            int result = -1;
            try
            {
                do
                {
                    string input = Console.ReadLine();
                    int temp = 0;
                    if (!int.TryParse(input,out temp))
                    {
                        Console.WriteLine("不是數字");
                        continue;
                    }
                    //copy temp
                    result = temp;
                    if (result < min)
                    {
                        Console.WriteLine($"輸入太小，範圍在[{min},{Max}]");
                        continue;
                    }
                    if (result > Max)
                    {
                        Console.WriteLine($"輸入太大，範圍在[{min},{Max}]");
                        continue;
                    }
                    break;
                }while(true);

            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            return result;
        }
    }
}