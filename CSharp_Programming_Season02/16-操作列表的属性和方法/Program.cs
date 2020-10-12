using System;
using System.Collections.Generic;

namespace _16_操作列表的属性和方法 {
    class Program {
        static void Main(string[] args) {
            List<int> scoreList = new List<int>();

            scoreList.Add(100);
            scoreList.Add(200);
            scoreList.Add(300);
            scoreList.Add(100);

            foreach (var item in scoreList) {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            //scoreList.Insert(1, -1);

            //foreach (var item in scoreList) {
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(" ");

            //scoreList.RemoveAt(3);
            //foreach (var item in scoreList) {
            //    Console.WriteLine(item);
            //}

            scoreList.IndexOf(100);
            Console.WriteLine(scoreList.LastIndexOf(100));

            scoreList.Sort();
            foreach (var item in scoreList) {
                Console.WriteLine(item);
            }
        }
    }
}
