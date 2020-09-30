using System;

namespace _050_参数数组
{
    class Program
    {
        static void Main(string[] args){

            int[] myArray = { 23, 4, 34, 32, 32, 42, 4 };

            int sum = Sum(myArray);

            int sum2 = Plus(23, 54, 5434, 23, 434, 234, 5, 23, 23, 55);

            Console.WriteLine(sum);
            Console.WriteLine(sum2);
        }

        static int Sum(int[] array) {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }
            return sum;
        }

        static int Plus(params int[] array) {
            int sum = 0;
            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }
            return sum;
        }
    }
}
