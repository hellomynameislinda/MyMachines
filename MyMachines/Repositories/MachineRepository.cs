using Microsoft.EntityFrameworkCore;
using MyMachines.Entities;
using MyMachines.Repositories;
using MyMachines.Data;

namespace MyMachines.Repositories
{
    public class MachineRepository : IMachineRepository
    {
        private readonly IDbContextFactory<MyMachinesContext> _contextFactory;
        public MachineRepository(IDbContextFactory<MyMachinesContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Machine>> GetAllAsync()
        {
            using (var _context = _contextFactory.CreateDbContext())
            {
                return await _context.Machine.ToListAsync();
            }
        }

        public async Task<Machine> GetAsync(Guid id)
        {
            using (var _context = _contextFactory.CreateDbContext())
            {
                // return await _context.Game.Where(g => g.Id == id).FirstOrDefaultAsync();
                return await _context.Machine.FindAsync(id);
            }
        }

        public async Task<bool> AnyAsync(Guid id)
        {
            using (var _context = _contextFactory.CreateDbContext())
            {
                return await _context.Machine.AnyAsync(g => g.Id == id);
            }
        }

        public void Add(Machine machine)
        {
            using (var _context = _contextFactory.CreateDbContext())
            {
                _context.Machine.Add(machine);
                _context.SaveChanges();
            }
        }

        public void Update(Machine machine)
        {
            using (var _context = _contextFactory.CreateDbContext())
            {
                _context.Machine.Update(machine);
                _context.SaveChanges();
            }
        }
        public void Remove(Machine machine)
        {
            using (var _context = _contextFactory.CreateDbContext())
            {
                _context.Machine.Remove(machine);
                _context.SaveChanges();
            }
        }
    }
}
