using System;
using _06_类的定义和声明;

namespace _08_值类型和引用类型_程序运行时内存的占用 {
    class Program {
        static void Main(string[] args) {
            //Test1();
            //Test2();
            //Test3();
            //Test4();
            Test5();
        }

        static void Test1() {
            int i = 34;
            int j = 34;
            int temp = 34;
            char c = 'a';
            bool b = true;
        }

        static void Test2() {
            int i = 34;
            int j = 234;
            string name = "siki"; //字符串会存储在堆里，内存的占用空间根据字符串大小来决定，栈里是一个引用；垃圾回收器会侦测引用格式，自动删除堆里没有引用的数据进行垃圾回收。
        }

        static void Test3() {
            string name = "siki";
            string name2 = "taikr";
            name = name2;
            name = "google";
            Console.WriteLine(name + " " + name2);
        }

        static void Test4() {
            Vector_3 v1 = new Vector_3();
            Vector_3 v2 = new Vector_3();
            v1.X = 100;
            v1.Y = 100;
            v1.Z = 100;

            v2.X = 200;
            v2.Y = 200;
            v2.Z = 200;

            v2 = v1;
            v2.X = 300;

            Console.WriteLine(v1.X);
        }

        static void Test5() {
            Vector_3[] vArray = new Vector_3[] {
                new Vector_3(), new Vector_3(), new Vector_3()
            };

            Vector_3 v1 = vArray[0];
            vArray[0].X = 100;
            v1.X = 200;
            Console.WriteLine(vArray[0].X);
        }
    }
}
