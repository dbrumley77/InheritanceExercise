using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Animal
    {
        
        public bool HasEars { get; set; }
        public bool HasMouth { get; set; }
        public string Diet { get; set; }
        public string Enviroment { get; set; }

        public void Speak(string sound)
        {
            Console.WriteLine($"This is a test {sound}");


        }


    }



}
