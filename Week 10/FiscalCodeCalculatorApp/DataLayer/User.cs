using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }

        [Required]
        public bool IsMale { get; set; }

        [Required]
        public string Birthcity { get; set; }

        [StringLength(16)]
        public string FiscalCode { get; set; }
    }
}