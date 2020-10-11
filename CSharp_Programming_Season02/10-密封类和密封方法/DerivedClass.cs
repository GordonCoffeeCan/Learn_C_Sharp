using System;
using System.Collections.Generic;
using System.Text;

namespace _10_密封类和密封方法 {
    class DerivedClass : BaseClass {
        public sealed override void Move() { //重写的方法可以加入sealed关键字，表示该重写方法不能再被重写。
            
        }
    }
}
