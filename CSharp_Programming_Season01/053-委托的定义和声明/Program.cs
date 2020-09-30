using System;

namespace _053_委托的定义和声明 {

    public delegate double MyDelegate(double p1, double p2);

    class Program {
        static void Main(string[] args) {
            MyDelegate de;

            de = Multiply;
            Console.WriteLine(de(1.0, 2.5));

            de = Devide;
            Console.WriteLine(de(1.0, 2.5));
        }

        static double Multiply(double param1, double param2) {
            return param1 * param2;
        }

        static double Devide(double param1, double param2) {
            return param1 / param2;
        }
    }
}
