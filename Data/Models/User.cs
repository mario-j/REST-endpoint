using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIDemo.Data.Models
{
    [Table("Department", Schema = "dbo")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "User Id")]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Required]
        [Column(TypeName = "int")]
        [Display(Name = "Age")]
        public int Age { get; set; }


        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        [Display(Name = "Interests")]
        public string Interests { get; set; }
    }
}
