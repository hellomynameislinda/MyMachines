using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyMachines.API.Entities;

namespace MyMachines.API.Data
{
    public class MyMachinesAPIContext : DbContext
    {
        public MyMachinesAPIContext (DbContextOptions<MyMachinesAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MyMachines.API.Entities.Machine> Machine { get; set; } = default!;
    }
}
