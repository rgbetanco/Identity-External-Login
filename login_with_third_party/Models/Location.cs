﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login_with_third_party.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public int LocationX { get; set; }
        public int LocationY { get; set; }
    }
}
