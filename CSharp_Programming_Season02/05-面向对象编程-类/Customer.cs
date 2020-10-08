using System;
using System.Collections.Generic;
using System.Text;

namespace _05_面向对象编程_类 {

    class Customer {
        public string name;
        public string address;
        public int age;
        public string buyTime;

        public void Show() {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Buy Time: " + buyTime);
        }
    }
}
