using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreMVC_Exam.Models
{
    [Table("MyCategory")]
    public class Category
    {
        [Key]
        [Column("id")]
        [StringLength(1, ErrorMessage = "Length limit exceeded")]
        [Required(ErrorMessage = "Field is required")]
        public string Id { get; set; }

        [Column("nameCategory")]
        [Required(ErrorMessage = "Field is required")]
        [StringLength(20, ErrorMessage = "Length limit exceeded")]
        public string NameCategory { get; set; }
    }
}
