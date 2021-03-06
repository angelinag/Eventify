﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventify.DTOs.Location
{
    public class UpdateLocationDTO
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public double SquareMeters { get; set; }
        public string Address { get; set; }
        public List<Eventify.Models.Event> Events { get; set; }
    }
}
