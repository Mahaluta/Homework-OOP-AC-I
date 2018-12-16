using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Worker : Human
    {
        // constructors
        public Worker(decimal weekSalary,int workHoursPerDay) {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
                }

        // fields
        private decimal WeekSalary { get; }
        private int WorkHoursPerDay { get; }

        // methods
        public decimal MoneyPerHour()
        {
            return Math.Round((WeekSalary / 7 / WorkHoursPerDay),2);
        }

    }
}
