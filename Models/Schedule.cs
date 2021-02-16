using System;
using System.Collections.Generic;

#nullable disable

namespace SVR___Sajermann_Vehicle_Reservations.Models
{
    public partial class Schedule
    {
        public long Id { get; set; }
        public long IdDriver { get; set; }
        public long IdVehicle { get; set; }
        public long Origin { get; set; }
        public long Destination { get; set; }
        public string Note { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateUntil { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Active { get; set; }
    }
}
