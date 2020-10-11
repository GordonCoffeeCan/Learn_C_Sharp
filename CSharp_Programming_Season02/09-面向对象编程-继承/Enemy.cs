using System;
using System.Collections.Generic;
using System.Text;

namespace _09_面向对象编程_继承 {
    class Enemy {
        private float hp;
        private float speed;
        
        public float HP {
            get {
                return hp;
            }
            set {
                hp = value;
            }
        }

        public float Speed {
            get {
                return speed;
            }
            set {
                speed = value;
            }
        }

        public void AI() {
            //Move();
            Console.WriteLine("This is Enemy1's common AI method.");
        }

        //public virtual void Move() {
        //    Console.WriteLine("This is Enemy1's common Move method.");
        //}

        public void Move() {
            Console.WriteLine("This is Enemy1's common Move method.");
        }
    }
}
