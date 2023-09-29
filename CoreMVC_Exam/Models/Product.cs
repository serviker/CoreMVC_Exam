using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreMVC_Exam.Models
{
    [Table("MyProduct")]
    public class Product
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("idCategory")]
        [Required]
        [MaxLength(30)]
        [MinLength(1)]
        public string IdCategory { get; set; }

        [Column("serialNumber")]
        [Required]
        [MaxLength(30)]
        [MinLength(4)]
        public string SerialNumber { get; set; }

        [Column("releaseDate")]
        [Required]
        [MaxLength(40)]
        [MinLength(4)]
        public string ReleaseDate { get; set; }

        [Column("price")]
        [Required]
        [MinLength(1)]
        public string Price { get; set; }

        [Column("brand")]
        [Required]
        [MaxLength(30)]
        [MinLength(2)]
        public string Brand { get; set; }

        [Column("modelName")]
        [Required]
        [MaxLength(40)]
        [MinLength(2)]
        public string ModelName { get; set; }
    }
}
