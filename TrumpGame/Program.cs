using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrumpGame {
    internal class Program {
        static void Main(string[] args) {

            int[] num = new int[4];

            // 入力処理
            for(int i = 0; i < num.Length; i++) {
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

            // 判定処理
            // フォーカード
            if ((num[0] == num[1]) && (num[0] == num[2]) && (num[0] == num[3])) {
                Console.WriteLine("フォーカード!!");
                Console.ReadLine();
                return;
            }

            // スリーカード
            int nPoint = 0;

            for (int i = 0; i < 4; i++) {
                nPoint = 0;
                for (int n = 0; n < 4; n++) {
                    if (num[i] == num[n]) {
                        nPoint++;
                    }
                }

                if (nPoint == 3) {
                    Console.WriteLine("スリーカード!!");
                    Console.ReadLine();
                    return;
                }
            }


            // ツーペア
            nPoint = 0;
            int[] usedNum = new int[2];

            for (int i = 0; i < 4; i++) {
                if (num[i] == usedNum[0] || num[i] == usedNum[1]) {
                    continue;
                }

                for (int n = 0; n < 4; n++) {
                    if (i == n) {
                        continue;
                    }
                    if (num[i] == num[n]) {
                        nPoint++;

                        if (usedNum[0] == 0) {
                            usedNum[0] = num[i];
                        }
                        else {
                            usedNum[1] = num[i];
                        }
                        break;
                    }
                }

                if (nPoint == 2) {
                    Console.WriteLine("ツーペア!!");
                    Console.ReadLine();
                    return;
                }
            }

            // ワンペア
            nPoint = 0;
            int used = 0;

            for (int i = 0; i < 4; i++) {
                if (num[i] == used) {
                    continue;
                }

                for (int n = 0; n < 4; n++) {
                    if (i == n) {
                        continue;
                    }
                    if (num[i] == num[n]) {
                        nPoint++;

                        if (used == 0) {
                            used = num[i];
                        }
                        break;
                    }
                }

                if (nPoint == 1) {
                    Console.WriteLine("ワンペア!!");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("ノーペア");
            Console.ReadLine();
            return;
        }
    }
}
