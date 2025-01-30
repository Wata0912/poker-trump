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
            //カード枚数の配列を作成
           int [] cards = new int [5];
            //入力された数字
            string num;
            //文字列から数字への変換判定
            bool result ;
            //継続判定
            int next = 0;
            string Next;


            while (true)
            {
                for (int i = 0; i < cards.Length; i++)
                {
                    while(true)
                    {
                        Console.Write($"{i + 1}番目のカードの数字(1～13)を入力してください＞");
                        num = Console.ReadLine();
                        result = int.TryParse(num, out cards[i]);
                        if (result == true　&& cards[i] > 0 && cards[i] < 14)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("再入力してください");
                        }
                    }
                    
                }

                //ペアの数
                int count = 0;
                //比較元の設定
                for (int j = 0; j < 5; j++)
                {
                    //比較先の設定、残り枚数分繰り返す
                    for (int i = j + 1; i < 5; i++)
                    {
                        //比較元と比較先の値が等しいときCountを+する
                        if ((cards[i] & 0xf) == (cards[j] & 0xf))
                        {
                            //ペアの数をカウントする
                            count++;
                        }
    
                    }
                }
                //役の判定と出力
                switch(count)
                {
                    case 0:
                        Console.WriteLine("訳なし");
                        break;
                    case 1:
                        Console.WriteLine("ワンペア!");
                        break;
                    case 2:
                        Console.WriteLine("ツーペア!!");
                        break;
                    case 3:
                        Console.WriteLine("スリーカード!!!");
                        break;
                    case 4:
                        Console.WriteLine("フルハウス!!!!!");
                        break;
                        case 5:
                        Console.WriteLine("ファイブカード(存在なし)");
                        break;
                    case 6:
                        Console.WriteLine("フォー・オブ・カインド!!!!");
                        break;
                }


                while(true)
                    {
                    Console.Write("続けますか？ YES:1 NO:0＞");
                    Next = Console.ReadLine();
                    result = int.TryParse(Next, out next);
                    if (result == true)
                    {
                        if (next == 1)
                        {
                            Console.WriteLine("継続!");
                            break ;
                        }
                        else if (next == 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("再入力してください");
                        }
                    }
                }
                
                if(next==0)
                {
                    break;
                }

               

            }

            Console.WriteLine("Enterを押してください");
            Console.ReadLine();
        }

        
    }
}
