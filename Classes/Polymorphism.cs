using System;
using System.Collections.Generic;
using System.Text;

namespace netcore_csharp_basic_learning.Polymorphism
{
    /*
        Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.

        Like we specified in the previous chapter; Inheritance lets us inherit fields and methods from another class. 
        Polymorphism uses those methods to perform different tasks. This allows us to perform a single action in different ways.

        For example, think of a base class called Animal that has a method called animalSound(). Derived classes of Animals could be Pigs, 
        Cats, Dogs, Birds - And they also have their own implementation of an animal sound (the pig oinks, and the cat meows, etc.):
     */


    //class Animal  // Base class (parent) 
    //{
    //    public void animalSound()
    //    {
    //        Console.WriteLine("The animal makes a sound");
    //    }
    //}

    //class Pig : Animal  // Derived class (child) 
    //{
    //    public void animalSound()
    //    {
    //        Console.WriteLine("The pig says: wee wee");
    //    }
    //}

    //class Dog : Animal  // Derived class (child) 
    //{
    //    public void animalSound()
    //    {
    //        Console.WriteLine("The dog says: bow wow");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Animal myAnimal = new Animal();  // Create a Animal object
    //        Animal myPig = new Pig();  // Create a Pig object
    //        Animal myDog = new Dog();  // Create a Dog object

    //        myAnimal.animalSound();     //output The animal makes a sound
    //        myPig.animalSound();        //output The animal makes a sound
    //        myDog.animalSound();        //output The animal makes a sound

    //    }
    //}

    //change to this
    class Animal  // Base class (parent) 
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog : Animal  // Derived class (child) 
    {
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();         //output The animal makes a sound
            myPig.animalSound();            //output The Pig makes a sound
            myDog.animalSound();            //output The Dog makes a sound
        }
    }
}
