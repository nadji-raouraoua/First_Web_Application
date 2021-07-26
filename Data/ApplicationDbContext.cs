using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ClientWebAppModel;
using GymnaseWebAppModel;
using SportWebAppModel;
using SeanceWebAppModel;

namespace WebApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ClientWebAppModel.Client> Client { get; set; }
        public DbSet<GymnaseWebAppModel.Gymnase> Gymnase { get; set; }
        public DbSet<SportWebAppModel.Sport> Sport { get; set; }
        public DbSet<SeanceWebAppModel.Seance> Seance { get; set; }
    }
}
