﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03EF.Entites
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }
}
