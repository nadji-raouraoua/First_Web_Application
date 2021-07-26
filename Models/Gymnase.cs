using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace GymnaseWebAppModel
{
    public class Gymnase
    {
        [Key]
        public int IDGymnase{ get; set; }
        public string NomGymnase { get; set; }
        public string Adresse { get; set; }
        public string Ville { get; set; }
        public int Surface { get; set; }

        public Gymnase()
        {

        }
    }

}
