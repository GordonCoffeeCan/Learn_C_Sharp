using System;
using System.Collections.Generic;

namespace _14_列表List的创建和使用 {
    class Program {
        static void Main(string[] args) {
            List<int> scoreList = new List<int>();//创建了一个空列表，尖括号中写入类型；
            var scoreList2 = new List<int>();
            var scroeList3 = new List<int>() {1, 2, 3}; //创建带有初始值的列表；

            Console.WriteLine("Capacity: " + scoreList.Capacity + "; " + "Count: " + scoreList.Count);

            scoreList.Add(12); //向列表中插入数据；
            scoreList.Add(45);

            Console.WriteLine(scoreList[0]);
            Console.WriteLine("Capacity: " + scoreList.Capacity + "; " + "Count: " + scoreList.Count);
            //Console.WriteLine(scoreList[2]);
        }
    }
}
