﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelObliOpg.Model
{
    class Room
    {
        public int Room_No { get; set; }

        public int Hotel_No { get; set; }

        public string Types { get; set; }

        public double? Price { get; set; }
    }
}
