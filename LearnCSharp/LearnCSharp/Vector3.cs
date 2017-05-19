using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp {
    class Vector3 {

        private float x, y, z, length;
        private float age;

        //private string name;

        //public string Name {
        //    get {
        //        return name;
        //    }
        //    set {
        //        name = value;
        //    }

        //}

        public string Name {
            get;
            set;
        }

        public int Age {
            set {
                if (value > 0) {
                    age = value;
                }
            }
        }


        public float X {
            get {
                return x;
            }
            set {
                x = value;
            }
        }

        public Vector3() {
            
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

        public int MyIntProperty {
            get {
                Console.WriteLine("get");
                return 100;
            }

            set {
                Console.WriteLine("set " + value);
            }
        }

    }
}
