using System;
using System.Collections.Generic;
using System.Text;

namespace _11_派生类的构造函数 {
    class BaseClass {

        private int x;
        protected int z;
        public BaseClass() {
            Console.WriteLine("This is Main method from BaseClass");
        }

        public BaseClass(int x) {
            this.x = x;
            Console.WriteLine("X value set: " + x);
        }
    }
}
