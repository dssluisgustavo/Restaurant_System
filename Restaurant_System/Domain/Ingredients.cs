﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Ingredients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public bool IsActive { get; set; }
    }
}