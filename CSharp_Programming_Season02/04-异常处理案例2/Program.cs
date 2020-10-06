using System;

namespace _04_异常处理案例2 {
    class Program {
        static void Main(string[] args) {
            int num1, num2;

            Console.WriteLine("input a number");
            while (true) {
                try {
                    num1 = Convert.ToInt32(Console.ReadLine());//有一行代码发生异常，try中的剩余代码都不执行；若是出现异常，会跳出try进入catch中执行语句；
                    break;
                } catch {
                    Console.WriteLine("Not a int, input a int");
                }
            }

            Console.WriteLine("input a second number");
            while (true) {
                try {
                    num2 = Convert.ToInt32(Console.ReadLine());//有一行代码发生异常，try中的剩余代码都不执行；若是出现异常，会跳出try进入catch中执行语句；
                    break;
                } catch {
                    Console.WriteLine("Not a int, input a int");
                }
            }

            int sum = num1 + num2;
            Console.WriteLine(sum);
        }
    }
}
