using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AprenderMVC.Models;

    public class AprenderMVCContext : DbContext
    {
        public AprenderMVCContext (DbContextOptions<AprenderMVCContext> options)
            : base(options)
        {
        }

        public DbSet<AprenderMVC.Models.Area> Area { get; set; } = default!;

        public DbSet<AprenderMVC.Models.Tipo> Tipo { get; set; }

        public DbSet<AprenderMVC.Models.Curso> Curso { get; set; }

        public DbSet<AprenderMVC.Models.Pessoa> Pessoa { get; set; }

        public DbSet<AprenderMVC.Models.Turma> Turma { get; set; }
    }
