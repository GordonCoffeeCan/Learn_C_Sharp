using System;
using System.Collections.Generic;
using System.Text;

namespace _17_泛型_泛型类 {
    class ClassA<T> {//T代表一个数据类型，使用ClassA构造时候要确定T的类型

        private T a;
        private T b;
        
        public ClassA(T a, T b) {
            this.a = a;
            this.b = b;
        }

        public string GetSum() {
            return a + " " + b;
        }

    }
}
