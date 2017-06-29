using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Cat
    {

        private String sound;
        private int tailLength;
        public Cat()
        {
            sound = "meow";
            tailLength = 2;
        }
        public String getSound()
        {
            return sound;
        }
        public int getTailLength()
        {
            return tailLength;
        }

        

    }
}
