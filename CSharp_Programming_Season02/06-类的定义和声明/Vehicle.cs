using System;
using System.Collections.Generic;
using System.Text;

namespace _06_类的定义和声明 {
    class Vehicle {
        public float speed;
        public float maxSpeed;
        public float weight;

        public void Run() {
            Console.WriteLine("Is moving with " + speed + "m/s");
        }

        public void Stop() {
            speed = 0;
            Console.WriteLine("Stopped!");
        }
    }
}
