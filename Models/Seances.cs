using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Microsoft.EntityFrameworkCore;

namespace SeanceWebAppModel
{
    public class Seance
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Gymnase")]
        [Required]

        public int IDGymnase { get; set; }


        
        [Column(Order = 1)]
        [ForeignKey("Sport")]
        [Required]

        public int IDSport { get; set; }


       
        [Column(Order = 3)]
        [Required]

        public DayOfWeek Jour { get; set; }
        
        
        
        [Required]
        [Column(Order = 4)]
        public string Horaire { get; set; }
        //Duree n'est pas une clée ni primaire ni externe
        public TimeSpan Duree { get; set; }
        public Seance()
        {

        }
        public  void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Seance>()
                .HasKey(nameof(Seance.IDGymnase), nameof(Seance.IDSport),nameof(Seance.Jour),nameof(Seance.Horaire));
        }



    }
}