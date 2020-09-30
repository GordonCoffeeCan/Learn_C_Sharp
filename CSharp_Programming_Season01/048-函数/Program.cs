using System;

namespace _048_函数 {
    class Program {
        static void Main(string[] args) {
            Write();

            int num1 = 45;
            int num2 = 90;

            int res = Plus(num1, num2);

            Console.WriteLine(res);
        }

        //函数，也叫做方法
        static void Write() {
            Console.WriteLine("Text out put from a function.");
            return;
        }

        static int Plus(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
