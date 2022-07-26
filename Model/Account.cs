using System;
using System.Collections.Generic;

namespace Point_of_Sales.Models
{
    public partial class Account
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;

        public virtual Employee Employee { get; set; } = null!;
    }
}
