using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class WorkerList
    {
        // constructors
        public WorkerList()
        {
            for (int i = 0; i < 9; i++)
            {
                Worker worker = new Worker(weekSalary[i], hours[i]);
                worker.firstName = firstName[i];
                worker.lastName = lastName[i];
                list.Add(worker);
                // --------------------------------------------------- DACA VREM SA CITIM PROPRIILE DATE ------------------------------------------
                    //Console.WriteLine("You must create 10 Worker objects: ");
                    //for (int i = 0; i < 9; i++)
                    // {
                    //Console.Write("Read the first name: ");
                    //string first = Console.ReadLine();
                    //Console.Write("Read the last neme: ");
                    //string last = Console.ReadLine();
                    //Console.Write("Read the week salary: ");
                    //decimal week = Convert.ToDecimal(Console.ReadLine());
                    //Console.Write("How many hours per day does he work?: ");
                    //int hours = Convert.ToInt32(Console.ReadLine());

                    //Worker worker = new Worker(week, hours);
                    //worker.firstName = first;
                    //worker.lastName = last;

                    //list.Add(worker);
                    //}
                    // --------------------------------------------------------------------------------------------------------------------------------
                }


        }

        // fields
        
        private List<Worker> list = new List<Worker>();

        //--------------------------------- EXEMPLU CA SA NU MAI CITIM PROPRIILE DATE ----------------------------------------------------
        public List<string> firstName = new List<string> { "Harry", "Dele", "Christian", "Hugo", "Antonio", "Manuel", "Marco", "Eden", "Thiago", "Kevin" };
        public List<string> lastName = new List<string> { "Kane", "Alli", "Eriksen", "Lloris", "Martial", "Neuer", "Veratti", "Hazard", "Silva", "DeBruyne" };
        public List<decimal> weekSalary = new List<decimal> { 1000, 2000, 3000, 1500, 1400, 1300, 2000, 1111, 3333, 1010 };
        public List<int> hours = new List<int> { 8, 8, 8, 8, 7, 9, 9, 8, 9, 8 };
        // --------------------------------------------------------------------------------------------------------------------------------

        // methods
        public List<Worker> getWorkerList() { return list; }

        public void PrintWorkerList()
        {
            Console.WriteLine("The current list of workers is: ");
            foreach (Worker worker in list)
                Console.WriteLine($"{worker.firstName} {worker.lastName} - (${worker.MoneyPerHour()})/hour");
            Console.WriteLine();
        }

        public void PrintOrderByMoneyPerHour()
        {
            Console.WriteLine("The ordered list of workers is: ");
            IEnumerable<Worker> Order = list.OrderByDescending(worker => worker.MoneyPerHour());
            foreach (Worker worker in Order)
                Console.WriteLine($"{worker.firstName} {worker.lastName} - (${worker.MoneyPerHour()})/hour");
            Console.WriteLine();
        }


    }
    }

