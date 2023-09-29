using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CoreMVC_Exam.Models
{
    [Table("MyClientOrder")]
    public class ClientOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("idPassport")]
        [Required]
        [ForeignKey("idPassport")]
        [StringLength(6)]
        public string IdPassport { get; set; }

        [ForeignKey("idUser")]
        [StringLength(450)]
        [Column("idUser")]
        [Required]
        public string IdUser { get; set; }


    }
}
