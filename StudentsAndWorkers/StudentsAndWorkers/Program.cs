using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {

            StudentList students = new StudentList();
            students.PrintStudentList(); // current list
            students.PrintOrderByGrade(); // ordered list

            WorkerList workers = new WorkerList();
            workers.PrintWorkerList(); // current list
            workers.PrintOrderByMoneyPerHour(); // ordered list

            // creating Human list
            StudsAndWorkers S_and_W = new StudsAndWorkers(students,workers);
            S_and_W.PrintOrderByFirstNameLastName();

            Console.ReadKey();
        }
    }
 }

