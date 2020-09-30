using System;

namespace _051_结构函数 {

    struct CustomerName {
        public string firstName;
        public string lastName;

        public string GetName() {
            return firstName + " " + lastName;
        }
    }

    struct Vector3 {
        public float x;
        public float y;
        public float z;
        public double Distance() {
            return Math.Sqrt(x * x + y * y + z * z);
        }
    }

    class Program {
        static void Main(string[] args) {
            CustomerName myName;
            myName.firstName = "Siki";
            myName.lastName = "Liang";

            Console.WriteLine("My name is " + myName.GetName());

            Vector3 myVector3;
            myVector3.x = 3;
            myVector3.y = 3;
            myVector3.z = 3;

            Console.WriteLine(myVector3.Distance());
        }
    }
}
