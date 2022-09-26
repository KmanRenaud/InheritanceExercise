using System;
using System.IO;



namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Birds b1 = new Birds();

            b1.favFood = "fish";
            b1.canFly = true;
            b1.canSwim = true;
            b1.legs = 2;
            b1.eyes = 2;
            b1.age = 3;
            b1.name = "Bob";
            b1.eatsMeat = true;

            Console.WriteLine($"{b1.name} the pelican loves {b1.favFood}! True or false... can it fly? {b1.canFly}! True or false... Can it swim? {b1.canSwim}! {b1.name} the pelican has {b1.legs} legs, {b1.eyes} eyes, and he is {b1.age} years old. True or false... Does he eat meat? {b1.eatsMeat}");




            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */



            Reptiles r1 = new Reptiles();

            r1.scalesOrScutes = "scales";
            r1.layEggs = true;
            r1.lungsNum = 2;
            r1.legs = 4;
            r1.eyes = 2;
            r1.age = 7;
            r1.name = "Komdrag";
            r1.typeOfReptile = "Komodo Dragon";

            Console.WriteLine($"{r1.name} the {r1.typeOfReptile} has {r1.scalesOrScutes}! True or false... can it lay eggs? {r1.layEggs}! How many lungs does it have? {r1.lungsNum}! {r1.name} the Komodo Dragon has {r1.legs} legs, {r1.eyes} eyes, and he is {r1.age} years old.");



        }
    }
}
