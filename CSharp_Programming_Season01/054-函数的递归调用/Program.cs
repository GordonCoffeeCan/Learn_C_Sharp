using System;

namespace _054_函数的递归调用 {
    class Program {

        

        static void Main(string[] args) {
            int res = F(40); //函数调用自身叫做，函数的递归调用；递归函数必须有终止条件，否则就是无限死循环；
            Console.WriteLine(res);

            int res2 = F(2);
            Console.WriteLine(res2);

        }


        static int F(int n) {
            if (n == 1) return 3;//函数终止递归的条件；
            if(n == 0) return 2;
            return F(n - 1) + F(n - 2);
        }

    }



}
