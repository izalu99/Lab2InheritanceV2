﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabInheritanceVersion2.Entities
{
    /// <summary>
    ///  this class represents a a waged employee
    /// <remarks> Author: Iza Lumpio</remarks>
    /// <remarks> Date:  Feb 2, 2023 </remarks>
    /// </summary>
    internal class Wages : Employee
    {
        //field
        private double rate;
        private double hours;

        //properties
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public double Hours
        {
            get { return hours; }
            set { hours = value; }
        }


        //constructors
        public Wages(string theid, string thename, string theaddress, double therate, double thehours) 
        {
            ID = theid;
            Name = thename;
            Address = theaddress;
            Rate = therate;
            Hours = thehours;
        }

        public Wages(string theid, string thename, string theaddress, string thephone, long thesin)
        {
            ID = theid;
            Name = thename;
            Address = theaddress;
            string phone = thephone;
            long sin = thesin;
        }

        //methods
        
    }
}
