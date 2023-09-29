using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreMVC_Exam.Models
{
    [Table("MyClient")]
    public class Client
    {
        [Key]
        [Column("id")]
        [StringLength(1, ErrorMessage = "Length limit exceeded")]
        [Required(ErrorMessage = "Field is required")]
        public string Id { get; set; }

        [Column("idPassport")]
        [Required(ErrorMessage = "Field is required")]
        [StringLength(6, ErrorMessage = "Length limit exceeded")]
        public string IdPassport { get; set; }

        [Column("firstName")]
        [StringLength(100, ErrorMessage = "Length limit exceeded")]
        [Required(ErrorMessage = "Field is required")]
        [RegularExpression("^[A-Za-zа-яА-Я]+(?:[-\\s][A-Za-zа-яА-Я]+)*$", ErrorMessage = "Invalid name")]
        public string FirstName { get; set; }

        [Column("lastName")]
        [Required(ErrorMessage = "Field is required")]
        [MaxLength(40)]
        [MinLength(4)]
        public string LastName { get; set; }

        [Column("address")]
        [Required(ErrorMessage = "Field is required")]
        [MaxLength(40)]
        [MinLength(4)]
        public string Address { get; set; }

        [Column("phone")]
        [RegularExpression("^\\+?\\d{1,3}(\\(\\d{1,3}\\))?[-\\d]+$", ErrorMessage = "Invalid phone number")]
        [MaxLength(11)]
        public string Phone { get; set; }

        [Column("dateBirth")]
        public string DateBirth { get; set; }
    }
}
