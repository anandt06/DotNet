//S stands for SRP (Single responsibility principle):-A class should take care of only one responsibility.

//O stands for OCP (Open closed principle):-Extension should be preferred over modification.

//L stands for LSP (Liskov substitution principle):-A parent class object should be able to refer child objects seamlessly during runtime polymorphism
//It states the object of a subclass should be substitutable for superclass without affecting correctness of a program       
// the objects of subclass should be able to access all methods and properties of super class.

//I stands for ISP (Interface segregation principle):-Client should not be forced to use a interface if it does not need it.

//D stands for DIP (Dependency inversion principle) :-High level modules should not depend on low level modules but should depend on abstraction.

namespace CSharp.Concepts
{
    //Liskovs principle Violation example

    public interface IBird
    {
        public void Fly();

        public void Walk();
    }


    public class Parrot : IBird
    {
        public void Fly()
        {

        }
        public void Walk()
        {

        }
    }

    public class Penguin : IBird
    {
        public void Fly()
        {

        }
        public void Walk()
        {

        }  // it's break the principle of LSP. Penguin can not fly.

    }

    //It states the object of a subclass should be substitutable for superclass without affecting correctness of a program       
    // the objects of subclass should be able to access all methods and properties of super class

    public interface IWalkingBird
    {
        public void Walk();
    }

    public interface IFlyingBird
    {
        public void Fly();
    }

    public class Parrot1 : IFlyingBird, IWalkingBird
    {
        public void Fly()
        {

        }
        public void Walk()
        {

        }
    }

    public class Penguin1 : IWalkingBird
    {
        public void Walk()
        {

        }
    }
    public class LiskovSubstitution
    {
        static void Main()
        {


        }
    }
}