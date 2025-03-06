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
        [ForeignKey("MembershipType")]
        public int? MembershiptypeID { get; set; }
        public MembershipType? MembershipType{ get ; set ; }

       public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    }
}
