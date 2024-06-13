using System;

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

            //Dog dog1 = new Dog();
            Bird bird1 = new Bird();
            bird1.AirLift = "500ft";
            bird1.Beak = "black";
            bird1.Diet = "corn";
            bird1.HasMouth = true;





            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile1 = new Reptile();
            reptile1.Enviroment = "Hot";
            reptile1.ScaleColor = "Camo";
            reptile1.ForkedTongue = "Viper shape"; 
            reptile1.Diet = "Little creatures";


            Console.WriteLine($"{bird1.AirLift} {bird1.Beak}");

            Console.WriteLine($"{reptile1.ForkedTongue} { reptile1.ScaleColor}"); 
            


        }
    }
}
