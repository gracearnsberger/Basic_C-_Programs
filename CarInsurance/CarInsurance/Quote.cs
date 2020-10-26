﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsurance
{
    public partial class Quote
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string DOB { get; set; }
        public string DUI { get; set; }
        public string Coverage { get; set; }
        public string CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string Quote1 { get; set; }
        public Nullable<int> SpeedingTicket { get; set; }
    }
}