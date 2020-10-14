using System;

namespace _17_泛型_泛型类 {
    class Program {
        static void Main(string[] args) {
            ClassA<int> o1 = new ClassA<int>(12, 15); //泛型类构造时候需要指定泛型的类型；

            ClassA<string> o2 = new ClassA<string>("test", "new");

            string s = o1.GetSum();
            string s2 = o2.GetSum();
            Console.WriteLine(s2);
        }
    }
}
