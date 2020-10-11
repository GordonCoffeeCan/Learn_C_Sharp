using System;
using System.Collections.Generic;
using System.Text;

namespace _11_派生类的构造函数 {
    class DerivedClass : BaseClass{
        private int y;
        public DerivedClass():base() { //表示调用父类中无参数的构造函数；若是父类中构造函数无参数，可以不写base();
            Console.WriteLine("This is main method in DerivedClass");
        }

        public DerivedClass(int x, int y):base(x) {
            this.y = y;
            Console.WriteLine("Y value set: " + y);
            base.z = 100;
        }

    }
}
