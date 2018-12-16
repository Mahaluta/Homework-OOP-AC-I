using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class StudsAndWorkers
    {
        // constructors
        public StudsAndWorkers(StudentList students, WorkerList workers)
        {
            foreach (Student human in students.getStudentList())
            {
                list.Add(human);
            }
            foreach (Worker human in workers.getWorkerList())
            {
                list.Add(human);
            }
        }

        // fields
        private List<Human> list = new List<Human>();


        // methods

        public void PrintOrderByFirstNameLastName()
        {
            Console.WriteLine("The ordered list from students and workers is: ");
            IEnumerable<Human> Order = list.OrderBy(human => human.firstName).ThenBy(human => human.lastName);
            foreach (Human human in Order)
            {
                Console.WriteLine($"{human.firstName} {human.lastName}");
            }
            Console.WriteLine();
        }
    }
}
    

