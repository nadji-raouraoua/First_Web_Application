using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace ArbitreWebApp
{
    public class Arbitre
    {
        [Key]
        [ForeignKey("Client")]
        public int IDClient { get; set; }
        [Key]
        [ForeignKey("Sport")]
        
        public int IDSport { get; set; }

    }
}