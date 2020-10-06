using System;

namespace _03_错误处理异常处理 {
    class Program {
        static void Main(string[] args) {

            try {
                int[] myArray = { 1, 2, 3, 4 };
                int myEle = myArray[4];
            }
            //} catch (NullReferenceException e) {
            //    Console.WriteLine("error: IndexOutOfRangeException");
            catch {
                Console.WriteLine("error: IndexOutOfRangeException");
            } finally {
                Console.WriteLine("____");
            }

            
            Console.WriteLine("Test");
        }
    }
}
