namespace ReservaAereas.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Users")]
    public partial class User
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Fullname { get; set; }

        [Required]
        [StringLength(25)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
