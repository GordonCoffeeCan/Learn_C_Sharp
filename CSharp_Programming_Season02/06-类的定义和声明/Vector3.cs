using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace _06_类的定义和声明 {
    public class Vector3 {

        //编程规范，习惯吧所有字段设置为private，只可在类内部访问；
        private float x, y, z, length;
        private float age;
        //private string name;

        //public String Name {
        //    get {
        //        return name;
        //    }
        //    set {
        //        name = value;
        //    }
        //}

        public string Name { get; set; } //这种写法，编译器会自动提供一个小写的name；

        public int Age {

            //通过set方法进行一些校验工作 属性的更多好处需要在之后代码过程中慢慢体会；
            set {
                if (value >= 0) {
                    age = value;
                }
            }
        }

        public float X {
            //在get 或 set前设置private可以确定可否在外界直接调用。
            get {
                return x;
            }
            set {
                x = value;
            }
        }

        public float Y {
            get {
                return y;
            }
            set {
                y = value;
            }
        }

        public float Z {
            get {
                return z;
            }
            set {
                z = value;
            }
        }

        public Vector3() {
            Console.WriteLine("Run!");
        }

        public Vector3(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;

            length = Length();
        }

        //使用set方法来设置字段的值，这是编程规范；
        //public void SetX(float x) {
        //    this.x = x;

        //}
        //public void SetY(float y) {
        //    this.y = y;

        //}
        //public void SetZ(float z) {
        //    this.z = z;

        //}

        public float Length() {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public int MyIntProperty {
            get {
                Console.WriteLine("Get is Running!");
                return 100;
            }
            set {
                Console.WriteLine("Set is Running");
                Console.WriteLine("Value in Set is: " + value);
            }
        }
    }
}
