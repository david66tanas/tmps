﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Weapons
{
    internal class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Impuscam din arbaleta");
        }
    }
}