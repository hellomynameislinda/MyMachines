using MyMachines.Entities;


namespace MyMachines.Repositories
{
    public interface IMachineRepository
    {
        Task<IEnumerable<Machine>> GetAllAsync();
        Task<Machine> GetAsync(Guid id);
        Task<bool> AnyAsync(Guid id);
        void Add(Machine machine);
        void Update(Machine machine);
        void Remove(Machine machine);
    }
}
