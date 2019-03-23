namespace ReservaAereas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Plane")]
    public partial class Plane: Basic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Capacity { get; set; }

        public int? Airline_id { get; set; }
        public string Airline { get; set; }

        public int? Status_id { get; set; }
        public string Status { get; set; }

        public int? Type_id { get; set; }
        public string Type { get; set; }
    }
}
