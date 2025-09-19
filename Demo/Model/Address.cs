﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Model
{
    //[Owned]
    public class Address
    {
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Street { get; set; }
    }
}
