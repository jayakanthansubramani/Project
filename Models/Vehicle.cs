using System;
using System.Collections.Generic;

namespace TransportWeb.Models
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Employees = new HashSet<Employee>();
            Routes = new HashSet<Route>();
        }

        public int VehicleId { get; set; }
        public int? VehicleNo { get; set; }
        public int Capacity { get; set; }
        public int AvailableSeats { get; set; }
        public string Operable { get; set; } = null!;

        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Route> Routes { get; set; }
    }
}
