﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelObliOpg.ViewModel;

namespace HotelObliOpg.Handler
{
    class GuestHandler
    {
        public GuestViewModel GuestViewModel { get; set; }

        public GuestHandler(GuestViewModel gvm)
        {
            this.GuestViewModel = gvm;
        }

        public CreateGuest()
        {
            Guest tempGuest = new Guest(GuestViewModel.Guest_No, GuestViewModel.Name, GuestViewModel.Address);
        }
    }
}
