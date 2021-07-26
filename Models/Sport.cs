using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportWebAppModel
{
    public class Sport
    {
        [Key]
        public int IDSport { get; set; }
        public string NomSport { get; set; }
        public Sport()
        {

        }
    }
}