namespace CSharp.Concepts
{
    using System;

    public class BaseClass
    {
        public virtual void GetMethod1()
        {
            Console.WriteLine("Hi Base class");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void GetMethod1()
        {
            base.GetMethod1();
            Console.WriteLine("Hi Derived class");
        }
    }

    public class Polymorphism
    {
        static void Main(string[] args)
        {
            BaseClass obj = new DerivedClass();

            obj.GetMethod1();
        }
    }
}
