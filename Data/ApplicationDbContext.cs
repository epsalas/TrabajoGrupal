using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

//dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 3.1.4
//dotnet add package Microsoft.EntityFrameworkCore --version 3.1.4
namespace TrabajoGrupal.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TrabajoGrupal.Models.Cuentas> Cuentas { get; set; }

    }
}