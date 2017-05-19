using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp {
    class Vector3 {

        private float x, y, z, length;

        public Vector3() {
            Console.WriteLine("run");
        }

        public Vector3(float _x, float _y, float _z) {
            this.x = _x;
            this.y = _y;
            this.z = _z;

            length = Length();
        }

        public float Length() {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

    }
}
