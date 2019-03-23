namespace ReservaAereas.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class PlaneType : Basic
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        
        public List<PlaneType> Examples()
        {
            List<PlaneType> _planeType = new List<PlaneType> {
                new PlaneType{ Id = 1, Name = "Comercial"},
                new PlaneType { Id = 2, Name = "Privado"},
            };
            return _planeType;
        }
        
    }
}
