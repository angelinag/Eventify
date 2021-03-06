﻿using Eventify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventify.DTOs.Event
{
    public class UpdateEventDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public Eventify.Models.Location Location { get; set; }
        public int NumberOfAttendees { get; set; }
        public bool IsDeleted { get; set; }
        public Eventify.Models.User User { get; set; }
    }
}
