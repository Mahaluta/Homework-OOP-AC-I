using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Dog  : Animal, ISound
    {
        // constructors
        public Dog(string name,int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        // fields

        // methods
        public override string getSound()
        {
            return ("Woof!");
        }
    }
}
