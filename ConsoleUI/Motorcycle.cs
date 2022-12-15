﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Driving motorcycle abstractly!");
        }
        public bool HasSideCart { get; set; }

        public override void DriveVirtual()
        {
            Console.WriteLine("Driving motorcycle virtually");
        }
    }
}
