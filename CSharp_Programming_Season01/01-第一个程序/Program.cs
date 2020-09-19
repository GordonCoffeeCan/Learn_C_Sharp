using System;

namespace _01_第一个程序
{
    class Program
    {
        static void Main() {
            int myInt = 100;
            string testStr;
            String resString = myInt < 10 ? "yes" : "no";

            Console.WriteLine(resString);

            switch (myInt) {
                case 1:
                    testStr = "not 1";
                    break;

                case 2:
                    testStr = "not 2";
                    break;

                default:
                    testStr = "you can't guess";
                    break;
            }

            Console.WriteLine(testStr);

        }
    }
}
