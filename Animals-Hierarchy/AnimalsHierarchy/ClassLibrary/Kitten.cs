using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name,age)
        {
            this.Name = name;
            this.Age = age;
        }

        public new const string Gender = "female";

    }
}
