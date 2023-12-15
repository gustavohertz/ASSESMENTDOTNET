using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tESTE.Models;

namespace tESTE.Data
{
    public class tESTEContext : DbContext
    {
        public tESTEContext (DbContextOptions<tESTEContext> options)
            : base(options)
        {
        }

        public DbSet<tESTE.Models.Cliente> Cliente { get; set; } = default!;
    }
}
