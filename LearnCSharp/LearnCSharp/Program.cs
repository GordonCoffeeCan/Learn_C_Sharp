using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp {
    class Program {
        static void Main(string[] args) {
            Vector3 _vector3 = new Vector3();

            //_vector3.x = 1;
            //_vector3.y = 1;
            //_vector3.z = 1;

            //_vector3.SetX(1);
            //_vector3.SetY(1);
            //_vector3.SetZ(1);

            

            Console.WriteLine(_vector3.Length());
            Console.ReadKey();

        }
    }
}
