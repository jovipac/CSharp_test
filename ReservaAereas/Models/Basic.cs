namespace ReservaAereas.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Basic
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
