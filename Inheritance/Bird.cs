using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string Feathers { get; set; }
        public string Beak { get; set; }
        public string AirLift { get; set; }
        public string Color { get; set; }


        public void Speak()
        {
            Console.WriteLine($"The bird makes this sound: flutter, flutter");
        }



    }




}


