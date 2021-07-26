using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ClientWebAppModel
{
    public class Client
    {
        
        [Key]
        public int IDClient { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        internal string Password { get; set; }

        public Client()
        {

        }
        public void OnModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .HasKey(nameof(Client.IDClient), nameof(Client.Email), nameof(Client.Password));
        }
    }
}

