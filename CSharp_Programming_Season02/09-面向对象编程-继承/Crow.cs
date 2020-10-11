using System;
using System.Collections.Generic;
using System.Text;

namespace _09_面向对象编程_继承 {
    class Crow : Bird {

        public override void Fly() {
            Console.WriteLine("Crow is flying");
        }
    }
}
