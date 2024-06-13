namespace MyMachines.API.Entities
{
    public class Machine
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}
