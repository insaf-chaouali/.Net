using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerId{ get; set; }
        [Required(ErrorMessage="le nom client est obligatoire")]
        public string Name { get; set; }

        // Relation plusieurs-à-un avec MembershipType
        [ForeignKey("Type d'adhésion")]
        public int? MembershiptypeID { get; set; }
        public MembershipType? MembreshipType{ get ; set ; }

    // Relation Plusieurs-à-Plusieurs avec Films
     public ICollection<Movie> Movies { get; set; } = new List<Movie>();
        public MembershipType? MembershipType { get; internal set; }
    }
}
