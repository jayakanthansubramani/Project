using System;
using System.Collections.Generic;

namespace TransportWeb.Models
{
    public partial class Route
    {
        public int RoutetId { get; set; }
        public int? RouteNo { get; set; }
        public string Stop1 { get; set; } = null!;
        public string Stop2 { get; set; } = null!;
        public int? VehicleNo { get; set; }

        public virtual Vehicle? VehicleNoNavigation { get; set; }
    }
}
