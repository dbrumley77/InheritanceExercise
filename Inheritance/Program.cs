using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {


            //Objects of Bird Class

            Bird bird1 = new Bird();
            bird1.AirLift = "500ft";
            bird1.Beak = "black";
            bird1.Diet = "corn";
            bird1.HasMouth = true;

            var bird2 = new Bird();
            bird2.Color = "white";
            bird2.Feathers = "water resistant";
            bird2.Enviroment = "Tree Habitat";



            //Objects of Reptile Class

            Reptile reptile1 = new Reptile();
            reptile1.Enviroment = "Hot";
            reptile1.ScaleColor = "camo";
            reptile1.ForkedTongue = "Viper shaped"; 
            reptile1.Diet = "Little creatures";

            var reptile2 = new Reptile();
            reptile2.Diet = "insects";
            reptile2.HasMouth = true;
            reptile2.Enviroment = "caves";


            Console.WriteLine($"The North American blackbird has an ceiling of {bird1.AirLift} with a beak color of {bird1.Beak}.");
            Console.WriteLine();
            Console.WriteLine($"The South American Hummingbird has a body color of {bird2.Color} and its feathers are {bird2.Feathers}.");
            Console.WriteLine();
            Console.WriteLine($"The snake's tongue is {reptile1.ForkedTongue} and its body has {reptile1.ScaleColor} color for protection.");
            Console.WriteLine();
            Console.WriteLine($"The spider is located in many {reptile2.Enviroment} and it does have a diet that involes {reptile2.Diet}.");
            Console.WriteLine();
            bird1.Speak("buzz");
            bird2.Speak();
            reptile1.Speak("zoom");
            reptile2.Speak();

        }
    }
}
