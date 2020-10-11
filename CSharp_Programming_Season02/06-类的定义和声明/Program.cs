using System;

namespace _06_类的定义和声明 {
    class Program {
        static void Main(string[] args) {
            Vehicle car1 = new Vehicle();

            car1.speed = 100;
            car1.Run();
            car1.Stop();

            Console.WriteLine(car1.speed);

            //Vector3 v1 = new Vector3();
            //v1.x = 1;
            //v1.y = 1;
            //v1.z = 1;

            //v1.SetX(1);
            //v1.SetY(1);
            //v1.SetZ(1);

            Vector_3 v1 = new Vector_3(1, 2, 3);

            v1.Name = "siki";
            Console.WriteLine(v1.Name);

            //Console.WriteLine(v1.Length());

            v1.MyIntProperty = 600;

            v1.X = 100;
            Console.WriteLine(v1.X);

            int temp = v1.MyIntProperty;
            Console.WriteLine(temp);
            
        }
    }
}
