
using System.Data.Entity.ModelConfiguration;

namespace Jouer
{
    public class Jouer
    {
        
        public int IDClient { get; set; }
        
        public int IDSport { get; set; }
        public Jouer()
        {

        }

        public class Joue : EntityTypeConfiguration<Jouer>
        {
            public Joue()
            {
                ToTable("Jouer");
                HasKey(x => new { x.IDClient, x.IDSport });
            }
        }


    }
}