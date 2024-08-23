using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {

        public string ScaleColor { get; set; }
        public string ForkedTongue { get; set; }
        public string WarmBlooded { get; set; }
        public string ToeNails { get; set; }


        public void Speak()
        {
            Console.WriteLine($"The reptile makes this sound: hiss, hiss ");
        }


    }



}
