using System;

namespace _09_面向对象编程_继承 {
    class Program {
        static void Main() {
            Boss boss = new Boss();
            Enemy enemy = new Enemy();

            //Crow crow = new Crow();
            //crow.Fly();

            Bird bird = new Crow();
            bird.Fly(); //通过抽象类声明对象，但是不能用抽象类构造。需要用完整子类构造；

            //boss.AI();//Boss继承了父类Enemy里所有的数据成员及函数成员。子类自动拥有这些字段，并能直接从对象中调用；
            //boss.Attack();

            //Enemy enemy;
            //enemy = new Boss();

            ////父类，使用子类构造，实际为子类类型。
            //Boss boss2 = (Boss)enemy;
            //boss.Attack();

            boss.Attack();
            boss.AI();

            boss.Move();

            enemy.AI();
        }
    }
}
