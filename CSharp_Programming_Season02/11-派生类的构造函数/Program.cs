using System;

namespace _11_派生类的构造函数 {
    class Program {
        static void Main(string[] args) {
            //先调用父类的构造函数，再调用子类的构造函数；
            //DerivedClass d1 = new DerivedClass();

            //DerivedClass d2 = new DerivedClass(1, 2);

            BaseClass baseClass = new BaseClass();

            ClassXYZ.z = 100;
            ClassXYZ.TestMethod();
            Console.WriteLine(ClassXYZ.z); 
        }
    }
}
