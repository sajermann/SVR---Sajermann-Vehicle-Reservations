using System;
using System.Collections.Generic;

#nullable disable

namespace SVR___Sajermann_Vehicle_Reservations.Models
{
    public partial class Vehicle
    {
        public long Id { get; set; }
        public string Model { get; set; }
        public string Marca { get; set; }
        public string Placa { get; set; }
        public long Year { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Active { get; set; }
    }
}
