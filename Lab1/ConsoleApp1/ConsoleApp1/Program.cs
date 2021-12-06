using System;

namespace ConsoleApp1
{
    class Program
    {
        class A
        {

        }

        class B : A
        {
            public object a;
        }

        class C : B
        {
            public object b;
        }
        static void Main(string[] args)
        {
            A a1 = new A();

            B b2 = new B();
            B b3 = new B();
            B b5 = new B();

            C c4 = new C();

            b2.a = a1;
            b3.a = b2;
            c4.b = b3;
            c4.a = a1;
            b5.a = c4;

        }
    }
}
