using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PoupaDev.API.Entities;

namespace PoupaDev.API.Persistence
{
    public class PoupaDevDbContext : DbContext
    {
        public PoupaDevDbContext(DbContextOptions<PoupaDevDbContext> options) : base(options) { }
        public DbSet<ObjetivoFinanceiro> Objetivos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ObjetivoFinanceiro>(n =>
            {
                n.HasKey(e => e.Id);
                n.Property(e => e.ValorObjetivo).HasColumnType("decimal(18,4)");
                n.HasMany(nn => nn.Operacoes)
                .WithOne().HasForeignKey(nn => nn.IdObjetivo).OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Operacao>(e =>
            {
                e.HasKey(op => op.Id);
                e.Property(op => op.Valor).HasColumnType("decimal(18,4)");
            });
        }
    }
}