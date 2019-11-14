using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    public class HanoiGame : IGame
    {
        public  int disk = 0;
        public  int from = 0;
        public  int to = 0;
        public void Setup()
        {
            while(true)
            {
                Console.WriteLine("請輸入河內塔的高度(範圍1~3)：");
                string input = Console.ReadLine();
                if(int.TryParse(input,out disk))
                {
                    disk = int.Parse(input);
                    if(disk >= 1 && disk <= 3)
                    {
                        break;
                    }
                    Console.WriteLine("你輸入的範圍錯誤");
                }
                else
                {
                    Console.WriteLine("你輸入的不是數字");
                }
            }

            while(true)
            {
                Console.WriteLine("起始地的柱子:(1,2,3)");
                string input = Console.ReadLine();
                if(int.TryParse(input,out from))
                {
                    from = int.Parse(input);
                    if(from >= 1 && from <= 3)
                    {
                        break;
                    }
                    Console.WriteLine("你輸入的範圍錯誤");
                }
                else
                {
                    Console.WriteLine("你輸入的不是數字");
                }
            }

            while(true)
            {
                Console.WriteLine("目的地的柱子：(1,2,3)");
                string input = Console.ReadLine();
                if(int.TryParse(input,out to))
                {
                    to = int.Parse(input);
                    if(to >= 1 && to <= 3)
                    {
                        break;
                    }
                    Console.WriteLine("你輸入的範圍錯誤"); 
                }
                else
                {
                    Console.WriteLine("你輸入的不是數字");
                }
            }
        }

        public void Play()
        {
            #region // 取得 第三柱子
            /* 例如 輸入 1 3  得到  2
             *      輸入 1 2  得到  3
             *      輸入 2 3  得到  1
             */
             
            int aux = 0;
            int[] temp = { 1, 2, 3 };
            foreach (int item in temp)
            {
                if (item != from && item != to)
                {
                    aux = item;
                    break;
                }
            }
            
            #endregion 
            //Console.WriteLine($"disk = {disk}");
            //Console.WriteLine($"from = {from}");
            //Console.WriteLine($"to = {to}");
            //Console.WriteLine($"aux = {aux}");
            //Hanoi(3,1,3,2);
           Hanoi(disk, from, to, aux);
            Console.ReadKey();
        }
        void Hanoi(int Disk, int Src, int Dest, int Aux)
        {
            if (Disk == 1)
            {
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
            }
            else
            {
                Hanoi(Disk - 1, Src, Aux, Dest);
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                Hanoi(Disk - 1, Aux, Dest, Src);
            }    
            
        }
    }
}