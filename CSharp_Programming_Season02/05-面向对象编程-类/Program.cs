using System;

namespace _05_面向对象编程_类 {
    class Program {
        static void Main(string[] args) {
            Customer customer1 = new Customer();
            customer1.name = "SiKi";
            customer1.Show();
            Console.WriteLine(customer1.name);


        }
    }
}
