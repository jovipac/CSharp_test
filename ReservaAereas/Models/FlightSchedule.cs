namespace ReservaAereas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FlightSchedule")]
    public partial class FlightSchedule
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public DateTime? Admission_time { get; set; }

        [StringLength(100)]
        public string Origin { get; set; }

        public DateTime? Departure_time { get; set; }

        [StringLength(100)]
        public string Destination { get; set; }

        public int Plane_id { get; set; }

        public int Runway_id { get; set; }

        public int Status_id { get; set; }
    }
}
