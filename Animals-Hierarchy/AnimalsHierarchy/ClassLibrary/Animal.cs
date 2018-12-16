using System;

namespace ClassLibrary
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

        public abstract string getSound();
    }
}
