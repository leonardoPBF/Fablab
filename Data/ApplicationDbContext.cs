using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fablab.Models.Entitys;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fablab.Data
{
    public class ApplicationDbContext : IdentityDbContext<Usuario>
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Solicitud> Solicitud { get; set; }
    }
}