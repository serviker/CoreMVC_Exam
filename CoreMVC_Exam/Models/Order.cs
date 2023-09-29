using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreMVC_Exam.Models
{
    [Table("MyOrder")]
    public class Order
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("idProduct")]
        [Required]
        [MaxLength(30)]
        [MinLength(1)]
        public string IdProduct { get; set; }

        [Column("idClient")]
        [Required]
        [MaxLength(30)]
        [MinLength(1)]
        public string IdClient { get; set; }

        [Column("startDate")]
        [Required]
        [MaxLength(30)]
        [MinLength(4)]
        public string StartDate { get; set; }

        [Column("endDate")]
        [Required]
        [MaxLength(40)]
        [MinLength(4)]
        public string EndDate { get; set; }

        [Column("price")]
        [Required]
        [MaxLength(11)]
        public string Price { get; set; }
    }
}
