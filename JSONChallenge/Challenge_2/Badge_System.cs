﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONChallenge.Challenge_2
{
    class Badge_System
    {
        public string BadgeId { get; set; }
        public List<string> ListOfDoors { get; set; }
        public bool HasSecurityClearance { get; set; }
        public string EmployeeId { get; set; }
        public DateTime CreatedOn { get; set; }

    }
}
