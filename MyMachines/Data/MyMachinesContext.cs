using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMachines.Entities;

namespace MyMachines.Data
{
    public class MyMachinesContext : DbContext
    {
        public MyMachinesContext (DbContextOptions<MyMachinesContext> options)
            : base(options)
        {
        }

        public DbSet<MyMachines.Entities.Machine> Machine { get; set; } = default!;
    }
}
