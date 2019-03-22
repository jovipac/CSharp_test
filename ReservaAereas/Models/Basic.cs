namespace ReservaAereas.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Basic
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

}
