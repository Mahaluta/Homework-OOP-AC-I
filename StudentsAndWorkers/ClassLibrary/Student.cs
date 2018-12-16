using System;
using System.Collections.Generic;
using System.Text;
namespace ClassLibrary
{
    public class Student : Human
    {
     

        // fields
        public decimal Grade { get; set; }

        // methods

        public void SetGrade(decimal grade)
        {
            this.Grade = grade;
        }

    }
}
