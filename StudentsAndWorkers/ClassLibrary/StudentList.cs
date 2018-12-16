using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class StudentList
    {
        // constructors
        public StudentList()
        {
            //Console.WriteLine("You must create 10 Student objects: ");
            for (int i = 0; i < 9; i++)
            {
                Student stud = new Student();
                stud.firstName = firstName[i];
                stud.lastName = lastName[i];
                stud.Grade = grades[i];
                // --------------------------------------------------- DACA VREM SA CITIM PROPRIILE DATE ------------------------------------------
                //Console.Write("Read the first name: ");
                //stud.firstName = Console.ReadLine();
                //Console.Write("Read the last neme: ");
                //stud.lastName = Console.ReadLine();
                //Console.Write("Read the student's grade: ");
                //decimal grade = Convert.ToDecimal(Console.ReadLine());
                //stud.SetGrade(grade);
                //Console.WriteLine();
                // --------------------------------------------------------------------------------------------------------------------------------
                list.Add(stud);
            }
        }

        // fields
        private List<Student> list = new List<Student>();
    
        //--------------------------------- EXEMPLU CA SA NU MAI CITIM PROPRIILE DATE ----------------------------------------------------
        public List<string> firstName = new List<string> { "Cristiano", "Gianluigi","Kylian","David","Paulo","David","Thomas","Antoine","Zlatan","Robert" };
        public List<string> lastName = new List<string> { "Ronaldo", "Buffon", "Mbappe", "DeGea", "Dybala", "Alaba", "Muller","Griezmann","Ibrahimovic","Lewandowski" };
        public List<decimal> grades = new List<decimal> { 10, 10, 9, 8, 9, 6, 5, 6, 7, 9 };
       // --------------------------------------------------------------------------------------------------------------------------------

        // methods
        public List<Student> getStudentList() { return list; }

        public void PrintOrderByGrade()
        {
            Console.WriteLine("The ascendent ordered list of students is: ");
            IEnumerable<Student> Order = list.OrderBy(student => student.Grade);
            foreach(Student student in Order)
                    Console.WriteLine($"{student.firstName} {student.lastName} - {student.Grade}");
            Console.WriteLine();
        }

        public void PrintStudentList()
        {
            Console.WriteLine("The current list of students is: ");
            foreach(Student student in list)
                Console.WriteLine($"{student.firstName} {student.lastName} - {student.Grade}");
            Console.WriteLine();
        }
    }
}
