using System;
using System.Collections.Generic;

namespace TransportWeb.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; } = null!;
        public int Age { get; set; }
        public string Location { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int? VehicleId { get; set; }

        public virtual Vehicle? Vehicle { get; set; }
    }
}
