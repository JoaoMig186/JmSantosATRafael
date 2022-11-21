using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JmSantosAT_Final_Rafael.Models;

namespace JmSantosAT_Final_Rafael.Data
{
    public class JmSantosAT_Final_RafaelContext : DbContext
    {
        public JmSantosAT_Final_RafaelContext (DbContextOptions<JmSantosAT_Final_RafaelContext> options)
            : base(options)
        {
        }

        public DbSet<JmSantosAT_Final_Rafael.Models.Amigo> Amigo { get; set; } = default!;

        public DbSet<JmSantosAT_Final_Rafael.Models.Pais> Pais { get; set; }

        public DbSet<JmSantosAT_Final_Rafael.Models.Estado> Estado { get; set; }
    }
}
