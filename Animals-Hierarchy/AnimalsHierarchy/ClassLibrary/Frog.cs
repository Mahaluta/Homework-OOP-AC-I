using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Frog : Animal, ISound
    {
        // constructors
        public Frog(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        // fields

        // methods

        public override string getSound()
        {
            return ("Ribbit!");
        }
    }
}
