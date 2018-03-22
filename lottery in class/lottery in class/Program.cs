using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lottery_in_class
{
    class Program
    {
        static void Main(string[] args)
        {
            //產生亂數物件
            Random rand = new Random();
            
            //印出亂數
            Console.WriteLine(rand.Next(50,100));

            //暫停螢幕
            Console.ReadLine();
        }
    }
}
