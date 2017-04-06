﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelObliOpg.Model
{
   public class Guest
    {
        public int Guest_No { get; set; }

        
        public string Name { get; set; }

        
        public string Address { get; set; }

        public Guest(int Guest_No, string Name, string Address)
        {
            this.Guest_No = Guest_No;
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return $"{Name}  -  {Address}  -  {Guest_No}";
        }
    }
}
