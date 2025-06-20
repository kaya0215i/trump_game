using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpGame {
    internal class Program {
        static void Main(string[] args) {

            int[] num = new int[4];

            for(int i=0;i<num.Length;i++) {
                while(true) {

                    Console.Write($"{i+1}番目の数字を入力 >");

                    if (!int.TryParse(Console.ReadLine(), out int tmp)) {
                        Console.WriteLine("\n入力された値が正しくありません\n");
                        continue;
                    }

                    if(!(tmp >= 1 && tmp <= 4)) {
                        Console.WriteLine("\n入力された値が正しくありません\n");
                        continue;
                    }

                    num[i] = tmp;

                    break;
                }
            }


            foreach (var val in num) {
                Console.WriteLine(val);
            }

            Console.ReadLine();
        }
    }
}
