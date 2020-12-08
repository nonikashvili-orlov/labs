using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public abstract class Transport
    {
        public string Color{ get; set; }

        public int MaxSpeed { get; set; }

        public int Weight { get; set; }

        //абстрактный метод, который нужно обязательно определить в классе наследнике
        public abstract void Move();

        //виртуальный метод, его можно переопредилять, а можно и не переопределять
        public virtual bool NeedOneDriver()
        {
            return true;
        }
    }
    public class Car :Transport
    {
        public override void Move()
        {
            //логика для движения машины
        }
    }
    public class Plane:Transport
    {
        public override void Move()
        {
            //логика для полета самолета
        }
        public override bool NeedOneDriver()
        {
            //переопределяем метод для определния количества людей за рулем
            return false;
        }
}
}
