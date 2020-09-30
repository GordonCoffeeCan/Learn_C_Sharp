using System;

namespace _052_函数的重载 {
    class Program {
        static void Main(string[] args) {
            int res = MaxValue(235, 234, 452, 2342, 242);
            double res2 = MaxValue(2.3523, 43.4534, 213123.5464363563, 4234.46365345, 546.2342345);

            Console.WriteLine(res);
            Console.WriteLine(res2);
        }

        static int MaxValue(params int[] array) {
            Console.WriteLine("int works");

            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++) {
                if(array[i] > maxValue) {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }

        static double MaxValue(params double[] array) {
            Console.WriteLine("double works");

            double maxValue = array[0];

            for (int i = 0; i < array.Length; i++) {
                if(array[i] > maxValue) {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }
    }
}
