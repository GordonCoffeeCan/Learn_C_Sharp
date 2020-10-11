using System;
using System.Collections.Generic;
using System.Text;

namespace _09_面向对象编程_继承 {
    class Boss : Enemy {


        public void Attack() {

            //父类中公有的函数和数据成员才可以从子类中访问。
            AI();
            Move();
            Console.WriteLine("Boss is Attacking you.");
        }

        //public override void Move() {
        //    Console.WriteLine("This is move method in Boss");
        //}

        public new void Move() { //当子类中有与父类完全一样的方法是，父类的里的同样方法会被隐藏。用new关键字加以区分；父类方法仍然存在。
            Console.WriteLine("This is move method in Boss");
        }
    }
}
