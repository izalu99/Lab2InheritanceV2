﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritanceVersion2.Entities
{
    internal class Salaried : Employee
    {
        //field
        private double salary;

        //properties
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        //constructors
        public Salaried(string theid, string thename, string theaddress, double thesalary)
        {
            ID = theid;
            Name = thename;
            Address = theaddress;
            Salary = thesalary;
        }

        public Salaried(string theid, string thename, string address, string thephone, long thesin)
        {
            ID = theid;
            Name = thename;
            Address = address;
            string phone = thephone;
            long sin = thesin;
        }

    }
}
