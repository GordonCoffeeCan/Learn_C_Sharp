using System;
using System.Collections.Generic;
using System.Text;

namespace _06_类的定义和声明 {
    class Vector3 {

        //编程规范，习惯吧所有字段设置为private，只可在类内部访问；
        private float x, y, z;

        //使用set方法来设置字段的值，这是编程规范；
        public void SetX(float x) {
            this.x = x;

        }
        public void SetY(float y) {
            this.y = y;

        }
        public void SetZ(float z) {
            this.z = z;

        }

        public float Length() {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }
    }
}
