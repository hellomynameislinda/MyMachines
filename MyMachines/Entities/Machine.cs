using System.ComponentModel.DataAnnotations;

namespace MyMachines.Entities
{
    public class Machine
    {
        public Guid Id { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "The name must exceed three characters")]
        public string Name { get; set; }
        [Required]
        public bool Status { get; set; }
        [Required]
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}
