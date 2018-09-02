using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace firstOfAll.Models
{
    public class firstOfAllContext : DbContext
    {
        public firstOfAllContext (DbContextOptions<firstOfAllContext> options)
            : base(options)
        {
        }

        public DbSet<firstOfAll.Models.Pessoa> Pessoa { get; set; }
    }
}
