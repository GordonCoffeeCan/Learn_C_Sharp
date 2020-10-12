using System;
using System.Collections.Generic;

namespace _15_列表的遍历 {
    class Program {
        static void Main(string[] args) {
            List<int> scoreList = new List<int>();
            scoreList.Add(34);
            scoreList.Add(334);
            scoreList.Add(3434);
            scoreList.Add(3754);
            scoreList.Add(3234);
            scoreList.Add(387864);
            scoreList.Add(3234);

            for (int i = 0; i < scoreList.Count; i++) {
                Console.WriteLine(scoreList[i]);
            }

            foreach (var item in scoreList) {
                Console.WriteLine(item);
            }
        }
    }
}
