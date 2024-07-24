﻿namespace CSharp
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Sound");
        }
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bow Bow");
        }
    }
    public class PractiseProgram
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog();
            animal.MakeSound();

          

        }

    }

    //protected class Abc
    //{
    //    //public virtual void MakeSound() {
    //}
}
