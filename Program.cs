using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokergame
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int [] cards = new int [4];

            string num;
            bool result ;

            while (true)
            {
                for (int i = 0; i < cards.Length; i++)
                {
                    while(true)
                    {
                        Console.WriteLine($"{i + 1}番目のカードの数字を入力してください＞");
                        num = Console.ReadLine();
                        result = int.TryParse(num, out cards[i]);
                        if (result == true)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("再入力してください");
                        }
                    }
                    
                }





            }
        }
    }
}
