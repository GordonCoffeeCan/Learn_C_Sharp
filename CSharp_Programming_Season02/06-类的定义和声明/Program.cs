using System;

namespace _06_类的定义和声明 {
    class Program {
        static void Main(string[] args) {
            Vehicle car1 = new Vehicle();

            car1.speed = 100;
            car1.Run();
            car1.Stop();

            Console.WriteLine(car1.speed);

            Vector3 v1 = new Vector3();
            //v1.x = 1;
            //v1.y = 1;
            //v1.z = 1;

            v1.SetX(1);
            v1.SetY(1);
            v1.SetZ(1);

            Console.WriteLine(v1.Length());
        }
    }
}
