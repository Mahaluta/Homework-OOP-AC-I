using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Cat : Animal, ISound
    {
        // constructors
        public Cat(string name, int age, string gender = "male")
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        // fields

        // methods
        public override string getSound()
        {
            return ("Meow!");
        }
    }
}
