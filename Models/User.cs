using System;
using System.Collections.Generic;

#nullable disable

namespace SVR___Sajermann_Vehicle_Reservations.Models
{
    public partial class User
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pass { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public string Cover { get; set; }
        public string Bio { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? Active { get; set; }
    }
}
