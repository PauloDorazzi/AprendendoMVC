using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeuPrimeiroProjetoMVC.Models;

namespace MeuPrimeiroProjetoMVC.Data
{
    public class MeuPrimeiroProjetoMVCContext : DbContext
    {
        public MeuPrimeiroProjetoMVCContext (DbContextOptions<MeuPrimeiroProjetoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MeuPrimeiroProjetoMVC.Models.Department> Department { get; set; } = default!;
    }
}
